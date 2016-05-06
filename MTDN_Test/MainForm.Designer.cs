namespace MidiTouch
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxMidiOut = new System.Windows.Forms.ComboBox();
            this.lblMidiOut = new System.Windows.Forms.Label();
            this.buttonSendTestMidiMsg = new System.Windows.Forms.Button();
            this.UpDownChannel = new System.Windows.Forms.NumericUpDown();
            this.UpDownValue = new System.Windows.Forms.NumericUpDown();
            this.UpDownCtrlr = new System.Windows.Forms.NumericUpDown();
            this.lblbMsgToSend = new System.Windows.Forms.Label();
            this.mNotifyicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabGraph = new System.Windows.Forms.TabPage();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabInfos = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.labelDeviceInfo = new System.Windows.Forms.Label();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tabletPointer1 = new MidiTouch.TabletPointer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCtrlr)).BeginInit();
            this.tabs.SuspendLayout();
            this.tabGraph.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabInfos.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBoxMidiOut);
            this.groupBox1.Controls.Add(this.lblMidiOut);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 153);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Midi Interfacing";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Open Pairing Dialog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxMidiOut
            // 
            this.comboBoxMidiOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMidiOut.FormattingEnabled = true;
            this.comboBoxMidiOut.Location = new System.Drawing.Point(96, 49);
            this.comboBoxMidiOut.Name = "comboBoxMidiOut";
            this.comboBoxMidiOut.Size = new System.Drawing.Size(219, 21);
            this.comboBoxMidiOut.TabIndex = 1;
            this.comboBoxMidiOut.SelectedIndexChanged += new System.EventHandler(this.comboBoxMidiOut_SelectedIndexChanged);
            // 
            // lblMidiOut
            // 
            this.lblMidiOut.AutoSize = true;
            this.lblMidiOut.Location = new System.Drawing.Point(37, 58);
            this.lblMidiOut.Name = "lblMidiOut";
            this.lblMidiOut.Size = new System.Drawing.Size(52, 13);
            this.lblMidiOut.TabIndex = 0;
            this.lblMidiOut.Text = "Midi Out :";
            // 
            // buttonSendTestMidiMsg
            // 
            this.buttonSendTestMidiMsg.Location = new System.Drawing.Point(225, 71);
            this.buttonSendTestMidiMsg.Name = "buttonSendTestMidiMsg";
            this.buttonSendTestMidiMsg.Size = new System.Drawing.Size(147, 23);
            this.buttonSendTestMidiMsg.TabIndex = 6;
            this.buttonSendTestMidiMsg.Text = "Send a test Midi message";
            this.buttonSendTestMidiMsg.UseVisualStyleBackColor = true;
            this.buttonSendTestMidiMsg.Click += new System.EventHandler(this.buttonSendTestMidiMsg_Click);
            // 
            // UpDownChannel
            // 
            this.UpDownChannel.Location = new System.Drawing.Point(119, 101);
            this.UpDownChannel.Name = "UpDownChannel";
            this.UpDownChannel.Size = new System.Drawing.Size(39, 20);
            this.UpDownChannel.TabIndex = 5;
            // 
            // UpDownValue
            // 
            this.UpDownValue.Location = new System.Drawing.Point(119, 74);
            this.UpDownValue.Name = "UpDownValue";
            this.UpDownValue.Size = new System.Drawing.Size(39, 20);
            this.UpDownValue.TabIndex = 4;
            // 
            // UpDownCtrlr
            // 
            this.UpDownCtrlr.Location = new System.Drawing.Point(119, 48);
            this.UpDownCtrlr.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.UpDownCtrlr.Name = "UpDownCtrlr";
            this.UpDownCtrlr.Size = new System.Drawing.Size(38, 20);
            this.UpDownCtrlr.TabIndex = 3;
            // 
            // lblbMsgToSend
            // 
            this.lblbMsgToSend.AutoSize = true;
            this.lblbMsgToSend.Location = new System.Drawing.Point(6, 27);
            this.lblbMsgToSend.Name = "lblbMsgToSend";
            this.lblbMsgToSend.Size = new System.Drawing.Size(96, 13);
            this.lblbMsgToSend.TabIndex = 2;
            this.lblbMsgToSend.Text = "Message to Send :";
            // 
            // mNotifyicon
            // 
            this.mNotifyicon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.mNotifyicon.BalloonTipText = "App reduced to system tray...";
            this.mNotifyicon.BalloonTipTitle = "Midi Touch";
            this.mNotifyicon.Icon = ((System.Drawing.Icon)(resources.GetObject("mNotifyicon.Icon")));
            this.mNotifyicon.Text = "Notify Icon";
            this.mNotifyicon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mNotifyicon_MouseDoubleClick);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabGraph);
            this.tabs.Controls.Add(this.tabOptions);
            this.tabs.Controls.Add(this.tabInfos);
            this.tabs.Controls.Add(this.tabAbout);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(401, 363);
            this.tabs.TabIndex = 6;
            // 
            // tabGraph
            // 
            this.tabGraph.Controls.Add(this.tabletPointer1);
            this.tabGraph.Location = new System.Drawing.Point(4, 22);
            this.tabGraph.Name = "tabGraph";
            this.tabGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraph.Size = new System.Drawing.Size(393, 337);
            this.tabGraph.TabIndex = 0;
            this.tabGraph.Text = "Graphic";
            this.tabGraph.UseVisualStyleBackColor = true;
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.groupBox3);
            this.tabOptions.Controls.Add(this.groupBox1);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(393, 337);
            this.tabOptions.TabIndex = 1;
            this.tabOptions.Text = "Options";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.buttonSendTestMidiMsg);
            this.groupBox3.Controls.Add(this.UpDownChannel);
            this.groupBox3.Controls.Add(this.lblbMsgToSend);
            this.groupBox3.Controls.Add(this.UpDownValue);
            this.groupBox3.Controls.Add(this.UpDownCtrlr);
            this.groupBox3.Location = new System.Drawing.Point(8, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 132);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test Your Midi Interface";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Channel :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Control :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Value :";
            // 
            // tabInfos
            // 
            this.tabInfos.Controls.Add(this.button2);
            this.tabInfos.Controls.Add(this.labelDeviceInfo);
            this.tabInfos.Location = new System.Drawing.Point(4, 22);
            this.tabInfos.Name = "tabInfos";
            this.tabInfos.Size = new System.Drawing.Size(393, 337);
            this.tabInfos.TabIndex = 2;
            this.tabInfos.Text = "Tabet Infos";
            this.tabInfos.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Refresh Informations";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelDeviceInfo
            // 
            this.labelDeviceInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelDeviceInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDeviceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDeviceInfo.Location = new System.Drawing.Point(0, 0);
            this.labelDeviceInfo.Name = "labelDeviceInfo";
            this.labelDeviceInfo.Size = new System.Drawing.Size(393, 337);
            this.labelDeviceInfo.TabIndex = 1;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.panel1);
            this.tabAbout.Controls.Add(this.label4);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(393, 337);
            this.tabAbout.TabIndex = 3;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MidiTouch.Properties.Resources.GitHub_Logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(157, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 64);
            this.panel1.TabIndex = 3;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(387, 89);
            this.label4.TabIndex = 1;
            this.label4.Text = "This software is under MIT licence. \r\n\r\nDevelopped by Stanyslas Bres, visit my Gi" +
    "tHub below :)\r\n\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabletPointer1
            // 
            this.tabletPointer1.BackColor = System.Drawing.SystemColors.Window;
            this.tabletPointer1.BrushColor = System.Drawing.Color.Red;
            this.tabletPointer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabletPointer1.DrawingSurfaceColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabletPointer1.Location = new System.Drawing.Point(3, 3);
            this.tabletPointer1.Name = "tabletPointer1";
            this.tabletPointer1.Size = new System.Drawing.Size(387, 331);
            this.tabletPointer1.TabIndex = 4;
            this.tabletPointer1.TraceSize = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 363);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MidiTouch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCtrlr)).EndInit();
            this.tabs.ResumeLayout(false);
            this.tabGraph.ResumeLayout(false);
            this.tabOptions.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabInfos.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxMidiOut;
        private System.Windows.Forms.Label lblMidiOut;
        private System.Windows.Forms.NumericUpDown UpDownChannel;
        private System.Windows.Forms.NumericUpDown UpDownValue;
        private System.Windows.Forms.NumericUpDown UpDownCtrlr;
        private System.Windows.Forms.Label lblbMsgToSend;
        private System.Windows.Forms.Button buttonSendTestMidiMsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon mNotifyicon;
        private TabletPointer tabletPointer1;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabGraph;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabInfos;
        private System.Windows.Forms.Label labelDeviceInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}

