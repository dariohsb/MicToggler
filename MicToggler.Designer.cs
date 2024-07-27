namespace MicToggler
{
    partial class MicToggler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MicToggler));
            top_panel = new Panel();
            minimizeApp_but = new Button();
            closeApp_but = new Button();
            label2 = new Label();
            label1 = new Label();
            applyHotkey_but = new Button();
            notifyIcon1 = new NotifyIcon(components);
            modifierCombo = new ComboBox();
            keyCombo = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            top_panel.SuspendLayout();
            SuspendLayout();
            // 
            // top_panel
            // 
            top_panel.BackColor = Color.FromArgb(60, 60, 60);
            top_panel.Controls.Add(minimizeApp_but);
            top_panel.Controls.Add(closeApp_but);
            top_panel.Controls.Add(label2);
            top_panel.Controls.Add(label1);
            top_panel.Dock = DockStyle.Top;
            top_panel.Location = new Point(0, 0);
            top_panel.Name = "top_panel";
            top_panel.Size = new Size(432, 37);
            top_panel.TabIndex = 0;
            top_panel.MouseDown += top_panel_MouseDown;
            top_panel.MouseMove += top_panel_MouseMove;
            // 
            // minimizeApp_but
            // 
            minimizeApp_but.Location = new Point(381, 7);
            minimizeApp_but.Name = "minimizeApp_but";
            minimizeApp_but.Size = new Size(24, 23);
            minimizeApp_but.TabIndex = 3;
            minimizeApp_but.Text = "-";
            minimizeApp_but.UseVisualStyleBackColor = true;
            minimizeApp_but.Click += minimizeApp_but_Click;
            // 
            // closeApp_but
            // 
            closeApp_but.Location = new Point(405, 7);
            closeApp_but.Name = "closeApp_but";
            closeApp_but.Size = new Size(24, 23);
            closeApp_but.TabIndex = 2;
            closeApp_but.Text = "X";
            closeApp_but.UseVisualStyleBackColor = true;
            closeApp_but.Click += closeApp_but_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 35);
            label2.TabIndex = 1;
            label2.Text = "MT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(165, 7);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 0;
            label1.Text = "MicToggler";
            // 
            // applyHotkey_but
            // 
            applyHotkey_but.Dock = DockStyle.Bottom;
            applyHotkey_but.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            applyHotkey_but.ForeColor = Color.Black;
            applyHotkey_but.Location = new Point(0, 167);
            applyHotkey_but.Name = "applyHotkey_but";
            applyHotkey_but.Size = new Size(432, 23);
            applyHotkey_but.TabIndex = 1;
            applyHotkey_but.Text = "Aplicar";
            applyHotkey_but.UseVisualStyleBackColor = true;
            applyHotkey_but.Click += applyHotkey_but_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "MicToggler";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseClick += notifyIcon1_MouseClick;
            // 
            // modifierCombo
            // 
            modifierCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            modifierCombo.FormattingEnabled = true;
            modifierCombo.Items.AddRange(new object[] { "None", "Alt", "Control", "Shift", "Windows" });
            modifierCombo.Location = new Point(129, 121);
            modifierCombo.Name = "modifierCombo";
            modifierCombo.Size = new Size(73, 23);
            modifierCombo.TabIndex = 0;
            // 
            // keyCombo
            // 
            keyCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            keyCombo.FormattingEnabled = true;
            keyCombo.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            keyCombo.Location = new Point(235, 121);
            keyCombo.Name = "keyCombo";
            keyCombo.Size = new Size(73, 23);
            keyCombo.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(126, 70);
            label3.Name = "label3";
            label3.Size = new Size(188, 18);
            label3.TabIndex = 4;
            label3.Text = "Asignar atajo de teclado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(208, 121);
            label4.Name = "label4";
            label4.Size = new Size(21, 21);
            label4.TabIndex = 5;
            label4.Text = "+";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.MediumSlateBlue;
            linkLabel1.Location = new Point(0, 149);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(43, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Github";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // MicToggler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(432, 190);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(keyCombo);
            Controls.Add(modifierCombo);
            Controls.Add(applyHotkey_but);
            Controls.Add(top_panel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MicToggler";
            ShowInTaskbar = false;
            Text = "MicToggler";
            WindowState = FormWindowState.Minimized;
            top_panel.ResumeLayout(false);
            top_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel top_panel;
        private Label label1;
        private Button applyHotkey_but;
        private Label label2;
        private Button minimizeApp_but;
        private Button closeApp_but;
        private NotifyIcon notifyIcon1;
        private ComboBox modifierCombo;
        private ComboBox keyCombo;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}
