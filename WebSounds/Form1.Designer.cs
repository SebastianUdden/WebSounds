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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
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
            this.tbIP.Text = "192.168.220.89";
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
            // mpBasic
            // 
            this.mpBasic.Enabled = true;
            this.mpBasic.Location = new System.Drawing.Point(719, 267);
            this.mpBasic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mpBasic.Name = "mpBasic";
            this.mpBasic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mpBasic.OcxState")));
            this.mpBasic.Size = new System.Drawing.Size(239, 191);
            this.mpBasic.TabIndex = 9;
            // 
            // cbPlayDrums
            // 
            this.cbPlayDrums.AutoSize = true;
            this.cbPlayDrums.Location = new System.Drawing.Point(265, 102);
            this.cbPlayDrums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.rbMiddleOctave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.rbHighOctave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.rbLowOctave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.cbPlayPiano.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPlayPiano.Name = "cbPlayPiano";
            this.cbPlayPiano.Size = new System.Drawing.Size(97, 21);
            this.cbPlayPiano.TabIndex = 14;
            this.cbPlayPiano.Text = "Play Piano";
            this.cbPlayPiano.UseVisualStyleBackColor = true;
            this.cbPlayPiano.CheckedChanged += new System.EventHandler(this.cbPlayPiano_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(809, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 78);
            this.button1.TabIndex = 15;
            this.button1.Text = "A (A)";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(858, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 78);
            this.button2.TabIndex = 16;
            this.button2.Text = "B (S)";
            this.button2.UseVisualStyleBackColor = false;
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
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.Location = new System.Drawing.Point(613, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 78);
            this.button4.TabIndex = 18;
            this.button4.Text = "D (F)";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Info;
            this.button5.Location = new System.Drawing.Point(662, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 78);
            this.button5.TabIndex = 19;
            this.button5.Text = "E (G)";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Info;
            this.button6.Location = new System.Drawing.Point(711, 138);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(43, 78);
            this.button6.TabIndex = 20;
            this.button6.Text = "F (H)";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Info;
            this.button7.Location = new System.Drawing.Point(760, 138);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(43, 78);
            this.button7.TabIndex = 21;
            this.button7.Text = "G (J)";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Desktop;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(833, 54);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(44, 78);
            this.button8.TabIndex = 22;
            this.button8.Text = "Bb (W)";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlText;
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Location = new System.Drawing.Point(588, 54);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(44, 78);
            this.button9.TabIndex = 23;
            this.button9.Text = "Db (R)";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Desktop;
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(638, 54);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(44, 78);
            this.button10.TabIndex = 24;
            this.button10.Text = "Eb (T)";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.Desktop;
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(733, 54);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(44, 78);
            this.button11.TabIndex = 25;
            this.button11.Text = "Gb (U)";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.Desktop;
            this.button12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button12.Location = new System.Drawing.Point(783, 54);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(44, 78);
            this.button12.TabIndex = 26;
            this.button12.Text = "Ab (I)";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 656);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private AxWMPLib.AxWindowsMediaPlayer mpBasic;
        private System.Windows.Forms.CheckBox cbPlayDrums;
        private System.Windows.Forms.RadioButton rbMiddleOctave;
        private System.Windows.Forms.RadioButton rbHighOctave;
        private System.Windows.Forms.RadioButton rbLowOctave;
        private System.Windows.Forms.CheckBox cbPlayPiano;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

