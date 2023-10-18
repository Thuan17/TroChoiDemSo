namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sentDataTextBox = new System.Windows.Forms.TextBox();
            this.sendDataTextBox = new System.Windows.Forms.TextBox();
            this.receivedDataTextBox = new System.Windows.Forms.TextBox();
            this.clientStatusLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.list_Client = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // sentDataTextBox
            // 
            this.sentDataTextBox.Location = new System.Drawing.Point(138, 145);
            this.sentDataTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.sentDataTextBox.Name = "sentDataTextBox";
            this.sentDataTextBox.Size = new System.Drawing.Size(227, 20);
            this.sentDataTextBox.TabIndex = 6;
            this.sentDataTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sentDataTextBox_KeyPress);
            // 
            // sendDataTextBox
            // 
            this.sendDataTextBox.Location = new System.Drawing.Point(138, 41);
            this.sendDataTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.sendDataTextBox.Name = "sendDataTextBox";
            this.sendDataTextBox.Size = new System.Drawing.Size(227, 20);
            this.sendDataTextBox.TabIndex = 7;
            // 
            // receivedDataTextBox
            // 
            this.receivedDataTextBox.Location = new System.Drawing.Point(138, 89);
            this.receivedDataTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.receivedDataTextBox.Name = "receivedDataTextBox";
            this.receivedDataTextBox.Size = new System.Drawing.Size(227, 20);
            this.receivedDataTextBox.TabIndex = 8;
            // 
            // clientStatusLabel
            // 
            this.clientStatusLabel.AutoSize = true;
            this.clientStatusLabel.Location = new System.Drawing.Point(9, 7);
            this.clientStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientStatusLabel.Name = "clientStatusLabel";
            this.clientStatusLabel.Size = new System.Drawing.Size(35, 13);
            this.clientStatusLabel.TabIndex = 5;
            this.clientStatusLabel.Text = "label1";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(287, 464);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(130, 47);
            this.ConnectButton.TabIndex = 3;
            this.ConnectButton.Text = "ConnectButton";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(104, 464);
            this.SendButton.Margin = new System.Windows.Forms.Padding(2);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(130, 47);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "SendButton";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nội Dung Gửi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nội Dung Nhận";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 129);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Con Số";
            // 
            // list_Client
            // 
            this.list_Client.FormattingEnabled = true;
            this.list_Client.Location = new System.Drawing.Point(104, 191);
            this.list_Client.Name = "list_Client";
            this.list_Client.Size = new System.Drawing.Size(278, 251);
            this.list_Client.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 577);
            this.Controls.Add(this.list_Client);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sentDataTextBox);
            this.Controls.Add(this.sendDataTextBox);
            this.Controls.Add(this.receivedDataTextBox);
            this.Controls.Add(this.clientStatusLabel);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.SendButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sentDataTextBox;
        private System.Windows.Forms.TextBox sendDataTextBox;
        private System.Windows.Forms.TextBox receivedDataTextBox;
        private System.Windows.Forms.Label clientStatusLabel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox list_Client;
    }
}

