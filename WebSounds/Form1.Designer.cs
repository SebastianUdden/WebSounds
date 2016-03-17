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
            this.mpBasic = new AxWMPLib.AxWindowsMediaPlayer();
            this.cbPlayDrums = new System.Windows.Forms.CheckBox();
            this.rbMiddleOctave = new System.Windows.Forms.RadioButton();
            this.rbHighOctave = new System.Windows.Forms.RadioButton();
            this.rbLowOctave = new System.Windows.Forms.RadioButton();
            this.cbPlayPiano = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.mpBasic)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(12, 56);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(163, 20);
            this.tbIP.TabIndex = 0;
            this.tbIP.Text = "192.168.220.89";
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
            // lbChat
            // 
            this.lbChat.FormattingEnabled = true;
            this.lbChat.Location = new System.Drawing.Point(13, 112);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(347, 225);
            this.lbChat.TabIndex = 6;
            // 
            // mpBasic
            // 
            this.mpBasic.Enabled = true;
            this.mpBasic.Location = new System.Drawing.Point(566, 267);
            this.mpBasic.Margin = new System.Windows.Forms.Padding(2);
            this.mpBasic.Name = "mpBasic";
            this.mpBasic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mpBasic.OcxState")));
            this.mpBasic.Size = new System.Drawing.Size(239, 191);
            this.mpBasic.TabIndex = 9;
            // 
            // cbPlayDrums
            // 
            this.cbPlayDrums.AutoSize = true;
            this.cbPlayDrums.Location = new System.Drawing.Point(199, 83);
            this.cbPlayDrums.Name = "cbPlayDrums";
            this.cbPlayDrums.Size = new System.Drawing.Size(79, 17);
            this.cbPlayDrums.TabIndex = 10;
            this.cbPlayDrums.Text = "Play Drums";
            this.cbPlayDrums.UseVisualStyleBackColor = true;
            this.cbPlayDrums.CheckedChanged += new System.EventHandler(this.cbPlayDrums_CheckedChanged);
            // 
            // rbMiddleOctave
            // 
            this.rbMiddleOctave.AutoSize = true;
            this.rbMiddleOctave.Location = new System.Drawing.Point(423, 204);
            this.rbMiddleOctave.Name = "rbMiddleOctave";
            this.rbMiddleOctave.Size = new System.Drawing.Size(94, 17);
            this.rbMiddleOctave.TabIndex = 12;
            this.rbMiddleOctave.TabStop = true;
            this.rbMiddleOctave.Text = "Middle Octave";
            this.rbMiddleOctave.UseVisualStyleBackColor = true;
            // 
            // rbHighOctave
            // 
            this.rbHighOctave.AutoSize = true;
            this.rbHighOctave.Location = new System.Drawing.Point(423, 234);
            this.rbHighOctave.Name = "rbHighOctave";
            this.rbHighOctave.Size = new System.Drawing.Size(85, 17);
            this.rbHighOctave.TabIndex = 13;
            this.rbHighOctave.TabStop = true;
            this.rbHighOctave.Text = "High Octave";
            this.rbHighOctave.UseVisualStyleBackColor = true;
            // 
            // rbLowOctave
            // 
            this.rbLowOctave.AutoSize = true;
            this.rbLowOctave.Location = new System.Drawing.Point(423, 171);
            this.rbLowOctave.Name = "rbLowOctave";
            this.rbLowOctave.Size = new System.Drawing.Size(83, 17);
            this.rbLowOctave.TabIndex = 11;
            this.rbLowOctave.TabStop = true;
            this.rbLowOctave.Text = "Low Octave";
            this.rbLowOctave.UseVisualStyleBackColor = true;
            // 
            // cbPlayPiano
            // 
            this.cbPlayPiano.AutoSize = true;
            this.cbPlayPiano.Location = new System.Drawing.Point(284, 83);
            this.cbPlayPiano.Name = "cbPlayPiano";
            this.cbPlayPiano.Size = new System.Drawing.Size(76, 17);
            this.cbPlayPiano.TabIndex = 14;
            this.cbPlayPiano.Text = "Play Piano";
            this.cbPlayPiano.UseVisualStyleBackColor = true;
            this.cbPlayPiano.CheckedChanged += new System.EventHandler(this.cbPlayPiano_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 465);
            this.Controls.Add(this.cbPlayPiano);
            this.Controls.Add(this.rbLowOctave);
            this.Controls.Add(this.rbHighOctave);
            this.Controls.Add(this.cbPlayDrums);
            this.Controls.Add(this.rbMiddleOctave);
            this.Controls.Add(this.mpBasic);
            this.Controls.Add(this.lbChat);
            this.Controls.Add(this.lIPaddress);
            this.Controls.Add(this.bSendMessage);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.tbIP);
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
        private AxWMPLib.AxWindowsMediaPlayer mpBasic;
        private System.Windows.Forms.CheckBox cbPlayDrums;
        private System.Windows.Forms.RadioButton rbMiddleOctave;
        private System.Windows.Forms.RadioButton rbHighOctave;
        private System.Windows.Forms.RadioButton rbLowOctave;
        private System.Windows.Forms.CheckBox cbPlayPiano;
    }
}

