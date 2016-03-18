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
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnBb = new System.Windows.Forms.Button();
            this.btnDb = new System.Windows.Forms.Button();
            this.btnEb = new System.Windows.Forms.Button();
            this.btnGb = new System.Windows.Forms.Button();
            this.btnAb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mpBasic)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(16, 69);
            this.tbIP.Margin = new System.Windows.Forms.Padding(4);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(216, 22);
            this.tbIP.TabIndex = 0;
            this.tbIP.Text = "192.168.220.89";
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(17, 102);
            this.bConnect.Margin = new System.Windows.Forms.Padding(4);
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
            this.tbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(463, 22);
            this.tbMessage.TabIndex = 3;
            // 
            // bSendMessage
            // 
            this.bSendMessage.Location = new System.Drawing.Point(17, 468);
            this.bSendMessage.Margin = new System.Windows.Forms.Padding(4);
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
            this.lbChat.Margin = new System.Windows.Forms.Padding(4);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(461, 276);
            this.lbChat.TabIndex = 6;
            // 
            // mpBasic
            // 
            this.mpBasic.Enabled = true;
            this.mpBasic.Location = new System.Drawing.Point(719, 379);
            this.mpBasic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mpBasic.Name = "mpBasic";
            this.mpBasic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mpBasic.OcxState")));
            this.mpBasic.Size = new System.Drawing.Size(239, 79);
            this.mpBasic.TabIndex = 9;
            this.mpBasic.Visible = false;
            // 
            // cbPlayDrums
            // 
            this.cbPlayDrums.AutoSize = true;
            this.cbPlayDrums.Location = new System.Drawing.Point(265, 102);
            this.cbPlayDrums.Margin = new System.Windows.Forms.Padding(4);
            this.cbPlayDrums.Name = "cbPlayDrums";
            this.cbPlayDrums.Size = new System.Drawing.Size(102, 21);
            this.cbPlayDrums.TabIndex = 10;
            this.cbPlayDrums.Text = "Play Drums";
            this.cbPlayDrums.UseVisualStyleBackColor = true;
            this.cbPlayDrums.CheckedChanged += new System.EventHandler(this.cbPlayDrums_CheckedChanged);
            // 
            // rbMiddleOctave
            // 
            this.rbMiddleOctave.AutoSize = true;
            this.rbMiddleOctave.Location = new System.Drawing.Point(564, 309);
            this.rbMiddleOctave.Margin = new System.Windows.Forms.Padding(4);
            this.rbMiddleOctave.Name = "rbMiddleOctave";
            this.rbMiddleOctave.Size = new System.Drawing.Size(119, 21);
            this.rbMiddleOctave.TabIndex = 12;
            this.rbMiddleOctave.TabStop = true;
            this.rbMiddleOctave.Text = "Middle Octave";
            this.rbMiddleOctave.UseVisualStyleBackColor = true;
            // 
            // rbHighOctave
            // 
            this.rbHighOctave.AutoSize = true;
            this.rbHighOctave.Location = new System.Drawing.Point(564, 346);
            this.rbHighOctave.Margin = new System.Windows.Forms.Padding(4);
            this.rbHighOctave.Name = "rbHighOctave";
            this.rbHighOctave.Size = new System.Drawing.Size(107, 21);
            this.rbHighOctave.TabIndex = 13;
            this.rbHighOctave.TabStop = true;
            this.rbHighOctave.Text = "High Octave";
            this.rbHighOctave.UseVisualStyleBackColor = true;
            // 
            // rbLowOctave
            // 
            this.rbLowOctave.AutoSize = true;
            this.rbLowOctave.Location = new System.Drawing.Point(564, 268);
            this.rbLowOctave.Margin = new System.Windows.Forms.Padding(4);
            this.rbLowOctave.Name = "rbLowOctave";
            this.rbLowOctave.Size = new System.Drawing.Size(103, 21);
            this.rbLowOctave.TabIndex = 11;
            this.rbLowOctave.TabStop = true;
            this.rbLowOctave.Text = "Low Octave";
            this.rbLowOctave.UseVisualStyleBackColor = true;
            // 
            // cbPlayPiano
            // 
            this.cbPlayPiano.AutoSize = true;
            this.cbPlayPiano.Location = new System.Drawing.Point(379, 102);
            this.cbPlayPiano.Margin = new System.Windows.Forms.Padding(4);
            this.cbPlayPiano.Name = "cbPlayPiano";
            this.cbPlayPiano.Size = new System.Drawing.Size(97, 21);
            this.cbPlayPiano.TabIndex = 14;
            this.cbPlayPiano.Text = "Play Piano";
            this.cbPlayPiano.UseVisualStyleBackColor = true;
            this.cbPlayPiano.CheckedChanged += new System.EventHandler(this.cbPlayPiano_CheckedChanged);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.SystemColors.Info;
            this.btnA.Location = new System.Drawing.Point(809, 138);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(43, 78);
            this.btnA.TabIndex = 15;
            this.btnA.Text = "A (A)";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.SystemColors.Info;
            this.btnB.Location = new System.Drawing.Point(858, 138);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(43, 78);
            this.btnB.TabIndex = 16;
            this.btnB.Text = "B (S)";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.Info;
            this.btnC.Location = new System.Drawing.Point(564, 138);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(43, 78);
            this.btnC.TabIndex = 17;
            this.btnC.Text = "C (D)";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.SystemColors.Info;
            this.btnD.Location = new System.Drawing.Point(613, 138);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(43, 78);
            this.btnD.TabIndex = 18;
            this.btnD.Text = "D (F)";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.SystemColors.Info;
            this.btnE.Location = new System.Drawing.Point(662, 138);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(43, 78);
            this.btnE.TabIndex = 19;
            this.btnE.Text = "E (G)";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.SystemColors.Info;
            this.btnF.Location = new System.Drawing.Point(711, 138);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(43, 78);
            this.btnF.TabIndex = 20;
            this.btnF.Text = "F (H)";
            this.btnF.UseVisualStyleBackColor = false;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.SystemColors.Info;
            this.btnG.Location = new System.Drawing.Point(760, 138);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(43, 78);
            this.btnG.TabIndex = 21;
            this.btnG.Text = "G (J)";
            this.btnG.UseVisualStyleBackColor = false;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnBb
            // 
            this.btnBb.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBb.Location = new System.Drawing.Point(833, 54);
            this.btnBb.Name = "btnBb";
            this.btnBb.Size = new System.Drawing.Size(44, 78);
            this.btnBb.TabIndex = 22;
            this.btnBb.Text = "Bb (W)";
            this.btnBb.UseVisualStyleBackColor = false;
            this.btnBb.Click += new System.EventHandler(this.btnBb_Click);
            // 
            // btnDb
            // 
            this.btnDb.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDb.Location = new System.Drawing.Point(588, 54);
            this.btnDb.Name = "btnDb";
            this.btnDb.Size = new System.Drawing.Size(44, 78);
            this.btnDb.TabIndex = 23;
            this.btnDb.Text = "Db (R)";
            this.btnDb.UseVisualStyleBackColor = false;
            this.btnDb.Click += new System.EventHandler(this.btnDb_Click);
            // 
            // btnEb
            // 
            this.btnEb.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnEb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEb.Location = new System.Drawing.Point(638, 54);
            this.btnEb.Name = "btnEb";
            this.btnEb.Size = new System.Drawing.Size(44, 78);
            this.btnEb.TabIndex = 24;
            this.btnEb.Text = "Eb (T)";
            this.btnEb.UseVisualStyleBackColor = false;
            this.btnEb.Click += new System.EventHandler(this.btnEb_Click);
            // 
            // btnGb
            // 
            this.btnGb.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGb.Location = new System.Drawing.Point(733, 54);
            this.btnGb.Name = "btnGb";
            this.btnGb.Size = new System.Drawing.Size(44, 78);
            this.btnGb.TabIndex = 25;
            this.btnGb.Text = "Gb (U)";
            this.btnGb.UseVisualStyleBackColor = false;
            this.btnGb.Click += new System.EventHandler(this.btnGb_Click);
            // 
            // btnAb
            // 
            this.btnAb.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAb.Location = new System.Drawing.Point(783, 54);
            this.btnAb.Name = "btnAb";
            this.btnAb.Size = new System.Drawing.Size(44, 78);
            this.btnAb.TabIndex = 26;
            this.btnAb.Text = "Ab (I)";
            this.btnAb.UseVisualStyleBackColor = false;
            this.btnAb.Click += new System.EventHandler(this.btnAb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 560);
            this.Controls.Add(this.btnAb);
            this.Controls.Add(this.btnGb);
            this.Controls.Add(this.btnEb);
            this.Controls.Add(this.btnDb);
            this.Controls.Add(this.btnBb);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnBb;
        private System.Windows.Forms.Button btnDb;
        private System.Windows.Forms.Button btnEb;
        private System.Windows.Forms.Button btnGb;
        private System.Windows.Forms.Button btnAb;
    }
}

