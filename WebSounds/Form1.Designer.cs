namespace WebSounds
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
            this.tbIP = new System.Windows.Forms.TextBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.bSendMessage = new System.Windows.Forms.Button();
            this.lIPaddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(12, 56);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(163, 20);
            this.tbIP.TabIndex = 0;
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(13, 83);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(75, 23);
            this.bConnect.TabIndex = 1;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // rtbChat
            // 
            this.rtbChat.Location = new System.Drawing.Point(12, 132);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.Size = new System.Drawing.Size(348, 207);
            this.rtbChat.TabIndex = 2;
            this.rtbChat.Text = "";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(12, 354);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(348, 20);
            this.tbMessage.TabIndex = 3;
            // 
            // bSendMessage
            // 
            this.bSendMessage.Location = new System.Drawing.Point(13, 380);
            this.bSendMessage.Name = "bSendMessage";
            this.bSendMessage.Size = new System.Drawing.Size(75, 23);
            this.bSendMessage.TabIndex = 4;
            this.bSendMessage.Text = "Send";
            this.bSendMessage.UseVisualStyleBackColor = true;
            this.bSendMessage.Click += new System.EventHandler(this.bSendMessage_Click);
            // 
            // lIPaddress
            // 
            this.lIPaddress.AutoSize = true;
            this.lIPaddress.Location = new System.Drawing.Point(13, 37);
            this.lIPaddress.Name = "lIPaddress";
            this.lIPaddress.Size = new System.Drawing.Size(58, 13);
            this.lIPaddress.TabIndex = 5;
            this.lIPaddress.Text = "IP Address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 435);
            this.Controls.Add(this.lIPaddress);
            this.Controls.Add(this.bSendMessage);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.rtbChat);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.tbIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button bSendMessage;
        private System.Windows.Forms.Label lIPaddress;
    }
}

