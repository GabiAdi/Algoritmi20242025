using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        struct clientData
        {
            public TcpClient client;
            public string name;
        }

        public Form1() {
            InitializeComponent();
            ipAddress = "127.0.0.1";
            port = 8889;
            spojen = false;

            server = new TcpListener(IPAddress.Parse(ipAddress), port);
            clients = new List<clientData>();
        }

        string ipAddress;
        int port;
        bool spojen;
        TcpListener server;
        List<clientData> clients;
        object lockObj = new object();

        private void button1_Click(object sender, EventArgs e) {
            server.Start();
            Thread thread = new Thread(AcceptClients);
            thread.Start();
        }

        private void AcceptClients() {
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                clientData clientData = new clientData();
                clientData.client = client;
                clientData.name = "Client" + (clients.Count + 1).ToString();

                lock (lockObj) clients.Add(clientData);
                MessageBox.Show("Connected: " + clients.Count);
                Thread clientThread = new Thread(() => HandleClient(clientData));
                clientThread.Start();
            }
        }

        private void HandleClient(clientData client) {
            NetworkStream stream = client.client.GetStream();
            byte[] buffer = new byte[1024];
            spojen = true;
            try {
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                if(bytesRead == 0) return;
                
                string firstMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                client.name = firstMessage;
                lb_users.Invoke((MethodInvoker)delegate
                {
                    lb_users.Items.Add(firstMessage);
                });

                while (true) {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if(bytesRead == 0) break;
                    string receivedData = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    lb_porukeServer.Invoke((MethodInvoker)delegate
                    {
                        lb_porukeServer.Items.Add(client.name + ": " + receivedData);
                    });
                    Broadcast(receivedData, client);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error handling client: " + ex.Message);
            }
            finally {
                lock (lockObj) clients.Remove(client);
                client.client.Close();
            }
        }

        private void Broadcast(string receivedData, clientData client) {
            byte[] buffer = Encoding.UTF8.GetBytes(client.name + ": " + receivedData);

            lock (lockObj)
            {
                foreach (clientData clData in clients) {
                    if(clData.client != client.client) {
                        try {
                            NetworkStream stream = clData.client.GetStream();
                            stream.Write(buffer, 0, buffer.Length);
                            // stream.Flush();
                        }
                        catch (Exception ex) {
                            MessageBox.Show($"{ex.Message}");
                        }
                    }

                }
            }
        }

        private void bt_posalji_Click(object sender, EventArgs e) {
            //string message = tb_poruka.Text;
            //byte[] data = Encoding.UTF8.GetBytes(message);

            //stream.Write(data, 0, data.Length);
            //stream.Flush();
        }

        private void bt_zaustavi_Click(object sender, EventArgs e) {
            server.Stop();
        }
    }
}
