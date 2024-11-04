namespace _28102024 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.rb_img1normal = new System.Windows.Forms.RadioButton();
            this.rb_img1stretch = new System.Windows.Forms.RadioButton();
            this.rb_img1auto = new System.Windows.Forms.RadioButton();
            this.cb_choice = new System.Windows.Forms.ComboBox();
            this.cm_1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.obrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_choice = new System.Windows.Forms.ListBox();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.gb_img1 = new System.Windows.Forms.GroupBox();
            this.rb_img1zoom = new System.Windows.Forms.RadioButton();
            this.rb_img1center = new System.Windows.Forms.RadioButton();
            this.gb_img2 = new System.Windows.Forms.GroupBox();
            this.rb_img2zoom = new System.Windows.Forms.RadioButton();
            this.rb_img2center = new System.Windows.Forms.RadioButton();
            this.rb_img2stretch = new System.Windows.Forms.RadioButton();
            this.rb_img2normal = new System.Windows.Forms.RadioButton();
            this.rb_img2auto = new System.Windows.Forms.RadioButton();
            this.bt_addImg = new System.Windows.Forms.Button();
            this.tb_image = new System.Windows.Forms.TextBox();
            this.tb_imgName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ms_1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            this.gb_img1.SuspendLayout();
            this.gb_img2.SuspendLayout();
            this.ms_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_img1normal
            // 
            this.rb_img1normal.AutoSize = true;
            this.rb_img1normal.Checked = true;
            this.rb_img1normal.Location = new System.Drawing.Point(6, 25);
            this.rb_img1normal.Name = "rb_img1normal";
            this.rb_img1normal.Size = new System.Drawing.Size(58, 17);
            this.rb_img1normal.TabIndex = 0;
            this.rb_img1normal.TabStop = true;
            this.rb_img1normal.Text = "Normal";
            this.rb_img1normal.UseVisualStyleBackColor = true;
            this.rb_img1normal.CheckedChanged += new System.EventHandler(this.rb_img1normal_CheckedChanged);
            // 
            // rb_img1stretch
            // 
            this.rb_img1stretch.AutoSize = true;
            this.rb_img1stretch.Location = new System.Drawing.Point(6, 48);
            this.rb_img1stretch.Name = "rb_img1stretch";
            this.rb_img1stretch.Size = new System.Drawing.Size(59, 17);
            this.rb_img1stretch.TabIndex = 1;
            this.rb_img1stretch.Text = "Stretch";
            this.rb_img1stretch.UseVisualStyleBackColor = true;
            this.rb_img1stretch.CheckedChanged += new System.EventHandler(this.rb_img1stretch_CheckedChanged);
            // 
            // rb_img1auto
            // 
            this.rb_img1auto.AutoSize = true;
            this.rb_img1auto.Location = new System.Drawing.Point(6, 71);
            this.rb_img1auto.Name = "rb_img1auto";
            this.rb_img1auto.Size = new System.Drawing.Size(47, 17);
            this.rb_img1auto.TabIndex = 2;
            this.rb_img1auto.Text = "Auto";
            this.rb_img1auto.UseVisualStyleBackColor = true;
            this.rb_img1auto.CheckedChanged += new System.EventHandler(this.rb_img1auto_CheckedChanged);
            // 
            // cb_choice
            // 
            this.cb_choice.ContextMenuStrip = this.cm_1;
            this.cb_choice.FormattingEnabled = true;
            this.cb_choice.Location = new System.Drawing.Point(324, 58);
            this.cb_choice.Name = "cb_choice";
            this.cb_choice.Size = new System.Drawing.Size(121, 21);
            this.cb_choice.TabIndex = 3;
            this.cb_choice.SelectedIndexChanged += new System.EventHandler(this.cb_choice_SelectedIndexChanged);
            // 
            // cm_1
            // 
            this.cm_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrišiToolStripMenuItem});
            this.cm_1.Name = "cm_1";
            this.cm_1.Size = new System.Drawing.Size(181, 48);
            // 
            // obrišiToolStripMenuItem
            // 
            this.obrišiToolStripMenuItem.Name = "obrišiToolStripMenuItem";
            this.obrišiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.obrišiToolStripMenuItem.Text = "Obrisi";
            this.obrišiToolStripMenuItem.Click += new System.EventHandler(this.obrišiToolStripMenuItem_Click);
            // 
            // lb_choice
            // 
            this.lb_choice.ContextMenuStrip = this.cm_1;
            this.lb_choice.FormattingEnabled = true;
            this.lb_choice.Location = new System.Drawing.Point(324, 111);
            this.lb_choice.Name = "lb_choice";
            this.lb_choice.Size = new System.Drawing.Size(120, 95);
            this.lb_choice.TabIndex = 4;
            this.lb_choice.SelectedIndexChanged += new System.EventHandler(this.lb_choice_SelectedIndexChanged);
            // 
            // img1
            // 
            this.img1.Location = new System.Drawing.Point(503, 58);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(100, 50);
            this.img1.TabIndex = 5;
            this.img1.TabStop = false;
            // 
            // img2
            // 
            this.img2.Location = new System.Drawing.Point(503, 235);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(100, 50);
            this.img2.TabIndex = 6;
            this.img2.TabStop = false;
            // 
            // gb_img1
            // 
            this.gb_img1.Controls.Add(this.rb_img1zoom);
            this.gb_img1.Controls.Add(this.rb_img1center);
            this.gb_img1.Controls.Add(this.rb_img1stretch);
            this.gb_img1.Controls.Add(this.rb_img1normal);
            this.gb_img1.Controls.Add(this.rb_img1auto);
            this.gb_img1.Location = new System.Drawing.Point(89, 58);
            this.gb_img1.Name = "gb_img1";
            this.gb_img1.Size = new System.Drawing.Size(200, 148);
            this.gb_img1.TabIndex = 7;
            this.gb_img1.TabStop = false;
            this.gb_img1.Text = "Image 1";
            // 
            // rb_img1zoom
            // 
            this.rb_img1zoom.AutoSize = true;
            this.rb_img1zoom.Location = new System.Drawing.Point(6, 117);
            this.rb_img1zoom.Name = "rb_img1zoom";
            this.rb_img1zoom.Size = new System.Drawing.Size(52, 17);
            this.rb_img1zoom.TabIndex = 4;
            this.rb_img1zoom.Text = "Zoom";
            this.rb_img1zoom.UseVisualStyleBackColor = true;
            this.rb_img1zoom.CheckedChanged += new System.EventHandler(this.rb_img1zoom_CheckedChanged);
            // 
            // rb_img1center
            // 
            this.rb_img1center.AutoSize = true;
            this.rb_img1center.Location = new System.Drawing.Point(6, 94);
            this.rb_img1center.Name = "rb_img1center";
            this.rb_img1center.Size = new System.Drawing.Size(56, 17);
            this.rb_img1center.TabIndex = 3;
            this.rb_img1center.Text = "Center";
            this.rb_img1center.UseVisualStyleBackColor = true;
            this.rb_img1center.CheckedChanged += new System.EventHandler(this.rb_img1center_CheckedChanged);
            // 
            // gb_img2
            // 
            this.gb_img2.Controls.Add(this.rb_img2zoom);
            this.gb_img2.Controls.Add(this.rb_img2center);
            this.gb_img2.Controls.Add(this.rb_img2stretch);
            this.gb_img2.Controls.Add(this.rb_img2normal);
            this.gb_img2.Controls.Add(this.rb_img2auto);
            this.gb_img2.Location = new System.Drawing.Point(89, 212);
            this.gb_img2.Name = "gb_img2";
            this.gb_img2.Size = new System.Drawing.Size(200, 148);
            this.gb_img2.TabIndex = 8;
            this.gb_img2.TabStop = false;
            this.gb_img2.Text = "Image 2";
            // 
            // rb_img2zoom
            // 
            this.rb_img2zoom.AutoSize = true;
            this.rb_img2zoom.Location = new System.Drawing.Point(6, 117);
            this.rb_img2zoom.Name = "rb_img2zoom";
            this.rb_img2zoom.Size = new System.Drawing.Size(52, 17);
            this.rb_img2zoom.TabIndex = 4;
            this.rb_img2zoom.Text = "Zoom";
            this.rb_img2zoom.UseVisualStyleBackColor = true;
            this.rb_img2zoom.CheckedChanged += new System.EventHandler(this.rb_img2zoom_CheckedChanged);
            // 
            // rb_img2center
            // 
            this.rb_img2center.AutoSize = true;
            this.rb_img2center.Location = new System.Drawing.Point(6, 94);
            this.rb_img2center.Name = "rb_img2center";
            this.rb_img2center.Size = new System.Drawing.Size(56, 17);
            this.rb_img2center.TabIndex = 3;
            this.rb_img2center.Text = "Center";
            this.rb_img2center.UseVisualStyleBackColor = true;
            this.rb_img2center.CheckedChanged += new System.EventHandler(this.rb_img2center_CheckedChanged);
            // 
            // rb_img2stretch
            // 
            this.rb_img2stretch.AutoSize = true;
            this.rb_img2stretch.Location = new System.Drawing.Point(6, 48);
            this.rb_img2stretch.Name = "rb_img2stretch";
            this.rb_img2stretch.Size = new System.Drawing.Size(59, 17);
            this.rb_img2stretch.TabIndex = 1;
            this.rb_img2stretch.Text = "Stretch";
            this.rb_img2stretch.UseVisualStyleBackColor = true;
            this.rb_img2stretch.CheckedChanged += new System.EventHandler(this.rb_img2stretch_CheckedChanged);
            // 
            // rb_img2normal
            // 
            this.rb_img2normal.AutoSize = true;
            this.rb_img2normal.Checked = true;
            this.rb_img2normal.Location = new System.Drawing.Point(6, 25);
            this.rb_img2normal.Name = "rb_img2normal";
            this.rb_img2normal.Size = new System.Drawing.Size(58, 17);
            this.rb_img2normal.TabIndex = 0;
            this.rb_img2normal.TabStop = true;
            this.rb_img2normal.Text = "Normal";
            this.rb_img2normal.UseVisualStyleBackColor = true;
            this.rb_img2normal.CheckedChanged += new System.EventHandler(this.rb_img2normal_CheckedChanged);
            // 
            // rb_img2auto
            // 
            this.rb_img2auto.AutoSize = true;
            this.rb_img2auto.Location = new System.Drawing.Point(6, 71);
            this.rb_img2auto.Name = "rb_img2auto";
            this.rb_img2auto.Size = new System.Drawing.Size(47, 17);
            this.rb_img2auto.TabIndex = 2;
            this.rb_img2auto.Text = "Auto";
            this.rb_img2auto.UseVisualStyleBackColor = true;
            this.rb_img2auto.CheckedChanged += new System.EventHandler(this.rb_img2auto_CheckedChanged);
            // 
            // bt_addImg
            // 
            this.bt_addImg.Location = new System.Drawing.Point(124, 437);
            this.bt_addImg.Name = "bt_addImg";
            this.bt_addImg.Size = new System.Drawing.Size(116, 38);
            this.bt_addImg.TabIndex = 9;
            this.bt_addImg.Text = "Add Image";
            this.bt_addImg.UseVisualStyleBackColor = true;
            this.bt_addImg.Click += new System.EventHandler(this.bt_addImg_Click);
            // 
            // tb_image
            // 
            this.tb_image.Location = new System.Drawing.Point(89, 411);
            this.tb_image.Name = "tb_image";
            this.tb_image.Size = new System.Drawing.Size(200, 20);
            this.tb_image.TabIndex = 10;
            // 
            // tb_imgName
            // 
            this.tb_imgName.Location = new System.Drawing.Point(89, 385);
            this.tb_imgName.Name = "tb_imgName";
            this.tb_imgName.Size = new System.Drawing.Size(200, 20);
            this.tb_imgName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Link";
            // 
            // ms_1
            // 
            this.ms_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.ms_1.Location = new System.Drawing.Point(0, 0);
            this.ms_1.Name = "ms_1";
            this.ms_1.Size = new System.Drawing.Size(800, 24);
            this.ms_1.TabIndex = 15;
            this.ms_1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zatvoriToolStripMenuItem,
            this.oProgramuToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // zatvoriToolStripMenuItem
            // 
            this.zatvoriToolStripMenuItem.Name = "zatvoriToolStripMenuItem";
            this.zatvoriToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.zatvoriToolStripMenuItem.Text = "Zatvori";
            this.zatvoriToolStripMenuItem.Click += new System.EventHandler(this.zatvoriToolStripMenuItem_Click);
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.oProgramuToolStripMenuItem.Text = "O Programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.ms_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_imgName);
            this.Controls.Add(this.tb_image);
            this.Controls.Add(this.bt_addImg);
            this.Controls.Add(this.gb_img2);
            this.Controls.Add(this.gb_img1);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.lb_choice);
            this.Controls.Add(this.cb_choice);
            this.MainMenuStrip = this.ms_1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.cm_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            this.gb_img1.ResumeLayout(false);
            this.gb_img1.PerformLayout();
            this.gb_img2.ResumeLayout(false);
            this.gb_img2.PerformLayout();
            this.ms_1.ResumeLayout(false);
            this.ms_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_img1normal;
        private System.Windows.Forms.RadioButton rb_img1stretch;
        private System.Windows.Forms.RadioButton rb_img1auto;
        private System.Windows.Forms.ComboBox cb_choice;
        private System.Windows.Forms.ListBox lb_choice;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.GroupBox gb_img1;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.RadioButton rb_img1zoom;
        private System.Windows.Forms.RadioButton rb_img1center;
        private System.Windows.Forms.GroupBox gb_img2;
        private System.Windows.Forms.RadioButton rb_img2zoom;
        private System.Windows.Forms.RadioButton rb_img2center;
        private System.Windows.Forms.RadioButton rb_img2stretch;
        private System.Windows.Forms.RadioButton rb_img2normal;
        private System.Windows.Forms.RadioButton rb_img2auto;
        private System.Windows.Forms.Button bt_addImg;
        private System.Windows.Forms.TextBox tb_image;
        private System.Windows.Forms.TextBox tb_imgName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cm_1;
        private System.Windows.Forms.MenuStrip ms_1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zatvoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrišiToolStripMenuItem;
    }
}

