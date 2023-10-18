namespace Client2
{
    partial class F_Client2
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
            this.list_Client = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sendDataTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clientStatusLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_Client
            // 
            this.list_Client.FormattingEnabled = true;
            this.list_Client.Location = new System.Drawing.Point(12, 150);
            this.list_Client.Name = "list_Client";
            this.list_Client.Size = new System.Drawing.Size(303, 251);
            this.list_Client.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Con Số";
            // 
            // sendDataTextBox
            // 
            this.sendDataTextBox.Location = new System.Drawing.Point(22, 90);
            this.sendDataTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.sendDataTextBox.Multiline = true;
            this.sendDataTextBox.Name = "sendDataTextBox";
            this.sendDataTextBox.Size = new System.Drawing.Size(293, 45);
            this.sendDataTextBox.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(125, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 56;
            this.label6.Text = "CLIENT 2";
            // 
            // clientStatusLabel
            // 
            this.clientStatusLabel.AutoSize = true;
            this.clientStatusLabel.Location = new System.Drawing.Point(9, 9);
            this.clientStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientStatusLabel.Name = "clientStatusLabel";
            this.clientStatusLabel.Size = new System.Drawing.Size(35, 13);
            this.clientStatusLabel.TabIndex = 57;
            this.clientStatusLabel.Text = "label1";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(175, 423);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(130, 47);
            this.ConnectButton.TabIndex = 52;
            this.ConnectButton.Text = "ConnectButton";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(12, 423);
            this.SendButton.Margin = new System.Windows.Forms.Padding(2);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(130, 47);
            this.SendButton.TabIndex = 53;
            this.SendButton.Text = "SendButton";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // F_Client2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 490);
            this.Controls.Add(this.list_Client);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sendDataTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clientStatusLabel);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.SendButton);
            this.Name = "F_Client2";
            this.Text = "F_Client2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_Client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sendDataTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label clientStatusLabel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button SendButton;
    }
}