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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbIP = new System.Windows.Forms.TextBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.bSendMessage = new System.Windows.Forms.Button();
            this.lIPaddress = new System.Windows.Forms.Label();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.bKick = new System.Windows.Forms.Button();
            this.bSnare = new System.Windows.Forms.Button();
            this.mpBasic = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.mpBasic)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(16, 69);
            this.tbIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(216, 22);
            this.tbIP.TabIndex = 0;
            this.tbIP.Text = "192.168.220.97";
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(17, 102);
            this.bConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(100, 28);
            this.bConnect.TabIndex = 1;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(16, 436);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(463, 22);
            this.tbMessage.TabIndex = 3;
            // 
            // bSendMessage
            // 
            this.bSendMessage.Location = new System.Drawing.Point(17, 468);
            this.bSendMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bSendMessage.Name = "bSendMessage";
            this.bSendMessage.Size = new System.Drawing.Size(100, 28);
            this.bSendMessage.TabIndex = 4;
            this.bSendMessage.Text = "Send";
            this.bSendMessage.UseVisualStyleBackColor = true;
            this.bSendMessage.Click += new System.EventHandler(this.bSendMessage_Click);
            // 
            // lIPaddress
            // 
            this.lIPaddress.AutoSize = true;
            this.lIPaddress.Location = new System.Drawing.Point(17, 46);
            this.lIPaddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lIPaddress.Name = "lIPaddress";
            this.lIPaddress.Size = new System.Drawing.Size(76, 17);
            this.lIPaddress.TabIndex = 5;
            this.lIPaddress.Text = "IP Address";
            // 
            // lbChat
            // 
            this.lbChat.FormattingEnabled = true;
            this.lbChat.ItemHeight = 16;
            this.lbChat.Location = new System.Drawing.Point(17, 138);
            this.lbChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(461, 276);
            this.lbChat.TabIndex = 6;
            // 
            // bKick
            // 
            this.bKick.Location = new System.Drawing.Point(705, 171);
            this.bKick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bKick.Name = "bKick";
            this.bKick.Size = new System.Drawing.Size(100, 28);
            this.bKick.TabIndex = 7;
            this.bKick.Text = "Kick";
            this.bKick.UseVisualStyleBackColor = true;
            this.bKick.Click += new System.EventHandler(this.bKick_Click);
            // 
            // bSnare
            // 
            this.bSnare.Location = new System.Drawing.Point(705, 222);
            this.bSnare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bSnare.Name = "bSnare";
            this.bSnare.Size = new System.Drawing.Size(100, 28);
            this.bSnare.TabIndex = 8;
            this.bSnare.Text = "Snare";
            this.bSnare.UseVisualStyleBackColor = true;
            this.bSnare.Click += new System.EventHandler(this.bSnare_Click);
            // 
            // mpBasic
            // 
            this.mpBasic.Enabled = true;
            this.mpBasic.Location = new System.Drawing.Point(566, 267);
            this.mpBasic.Name = "mpBasic";
            this.mpBasic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mpBasic.OcxState")));
            this.mpBasic.Size = new System.Drawing.Size(239, 191);
            this.mpBasic.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 572);
            this.Controls.Add(this.mpBasic);
            this.Controls.Add(this.bSnare);
            this.Controls.Add(this.bKick);
            this.Controls.Add(this.lbChat);
            this.Controls.Add(this.lIPaddress);
            this.Controls.Add(this.bSendMessage);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.tbIP);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mpBasic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button bSendMessage;
        private System.Windows.Forms.Label lIPaddress;
        private System.Windows.Forms.ListBox lbChat;
        private System.Windows.Forms.Button bKick;
        private System.Windows.Forms.Button bSnare;
        private AxWMPLib.AxWindowsMediaPlayer mpBasic;
    }
}

