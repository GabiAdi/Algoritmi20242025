using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24242025TCP_K_UDP_S {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            serverIp = "127.0.0.1";
            serverPort = 8889;

            connected = false;
        }

        string serverIp;
        int serverPort;
        TcpClient client;
        NetworkStream stream;
        bool connected;
        Thread clientThread;
        string username;

        int port = 11000;

        private void button1_Click(object sender, EventArgs e) {
            client = new TcpClient(serverIp, serverPort);
            if (!connected) {
                stream = client.GetStream();
                connected = true;
                MessageBox.Show("Spojeno");

                username = tb_username.Text;
                byte[] bytes = Encoding.UTF8.GetBytes(username);
                stream.Write(bytes, 0, bytes.Length);

                clientThread = new Thread(HandleServer);
                clientThread.Start();
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            if (!connected) { return; }
            string message = tb_poruka.Text;
            byte[] bytes = Encoding.UTF8.GetBytes(message);

            stream.Write(bytes, 0, bytes.Length);
            lb_poruke.Items.Add(username + ": " + message);

        }

        private void HandleServer() {
            byte[] buffer = new byte[1024];
            int bytesRead;
            try {
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0) {
                    string receivedData = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    lb_poruke.Invoke((MethodInvoker)delegate
                    {
                        lb_poruke.Items.Add(receivedData);
                    });
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error handling client: " + ex.Message);
            }
            finally {
                client.Close();
            }
        }
    }
}
