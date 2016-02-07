namespace MidiTouch
{
    partial class FormPairing
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
            this.groupBoxFingers1 = new System.Windows.Forms.GroupBox();
            this.btnTestX = new System.Windows.Forms.Button();
            this.numMaxValueX = new System.Windows.Forms.NumericUpDown();
            this.numMinValueX = new System.Windows.Forms.NumericUpDown();
            this.numChannelX = new System.Windows.Forms.NumericUpDown();
            this.numCtrlMsgX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numFingers = new System.Windows.Forms.NumericUpDown();
            this.groupBoxFingers2 = new System.Windows.Forms.GroupBox();
            this.btnTestY = new System.Windows.Forms.Button();
            this.numMaxValueY = new System.Windows.Forms.NumericUpDown();
            this.numMinValueY = new System.Windows.Forms.NumericUpDown();
            this.numChannelY = new System.Windows.Forms.NumericUpDown();
            this.numCtrlMsgY = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxFingers1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxValueX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinValueX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChannelX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCtrlMsgX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFingers)).BeginInit();
            this.groupBoxFingers2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxValueY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinValueY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChannelY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCtrlMsgY)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFingers1
            // 
            this.groupBoxFingers1.Controls.Add(this.btnTestX);
            this.groupBoxFingers1.Controls.Add(this.numMaxValueX);
            this.groupBoxFingers1.Controls.Add(this.numMinValueX);
            this.groupBoxFingers1.Controls.Add(this.numChannelX);
            this.groupBoxFingers1.Controls.Add(this.numCtrlMsgX);
            this.groupBoxFingers1.Controls.Add(this.label5);
            this.groupBoxFingers1.Controls.Add(this.label4);
            this.groupBoxFingers1.Controls.Add(this.label3);
            this.groupBoxFingers1.Controls.Add(this.label2);
            this.groupBoxFingers1.Location = new System.Drawing.Point(13, 30);
            this.groupBoxFingers1.Name = "groupBoxFingers1";
            this.groupBoxFingers1.Size = new System.Drawing.Size(234, 174);
            this.groupBoxFingers1.TabIndex = 0;
            this.groupBoxFingers1.TabStop = false;
            this.groupBoxFingers1.Text = "Setup 1 Finger(s) Controls on X Axis";
            // 
            // btnTestX
            // 
            this.btnTestX.Location = new System.Drawing.Point(53, 143);
            this.btnTestX.Name = "btnTestX";
            this.btnTestX.Size = new System.Drawing.Size(112, 23);
            this.btnTestX.TabIndex = 8;
            this.btnTestX.Text = "Send Test Message";
            this.btnTestX.UseVisualStyleBackColor = true;
            this.btnTestX.Click += new System.EventHandler(this.btnTestX_Click);
            // 
            // numMaxValueX
            // 
            this.numMaxValueX.Location = new System.Drawing.Point(106, 117);
            this.numMaxValueX.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numMaxValueX.Name = "numMaxValueX";
            this.numMaxValueX.Size = new System.Drawing.Size(59, 20);
            this.numMaxValueX.TabIndex = 7;
            // 
            // numMinValueX
            // 
            this.numMinValueX.Location = new System.Drawing.Point(106, 89);
            this.numMinValueX.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numMinValueX.Name = "numMinValueX";
            this.numMinValueX.Size = new System.Drawing.Size(59, 20);
            this.numMinValueX.TabIndex = 6;
            // 
            // numChannelX
            // 
            this.numChannelX.Location = new System.Drawing.Point(106, 61);
            this.numChannelX.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numChannelX.Name = "numChannelX";
            this.numChannelX.Size = new System.Drawing.Size(59, 20);
            this.numChannelX.TabIndex = 5;
            this.numChannelX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCtrlMsgX
            // 
            this.numCtrlMsgX.Location = new System.Drawing.Point(106, 33);
            this.numCtrlMsgX.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numCtrlMsgX.Name = "numCtrlMsgX";
            this.numCtrlMsgX.Size = new System.Drawing.Size(59, 20);
            this.numCtrlMsgX.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Maximum Value :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Minimum Value :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Channel :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Control Message :";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(211, 210);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Finger(s) :";
            // 
            // numFingers
            // 
            this.numFingers.Location = new System.Drawing.Point(66, 9);
            this.numFingers.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numFingers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFingers.Name = "numFingers";
            this.numFingers.Size = new System.Drawing.Size(34, 20);
            this.numFingers.TabIndex = 2;
            this.numFingers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFingers.ValueChanged += new System.EventHandler(this.numFingers_ValueChanged);
            // 
            // groupBoxFingers2
            // 
            this.groupBoxFingers2.Controls.Add(this.btnTestY);
            this.groupBoxFingers2.Controls.Add(this.numMaxValueY);
            this.groupBoxFingers2.Controls.Add(this.numMinValueY);
            this.groupBoxFingers2.Controls.Add(this.numChannelY);
            this.groupBoxFingers2.Controls.Add(this.numCtrlMsgY);
            this.groupBoxFingers2.Controls.Add(this.label6);
            this.groupBoxFingers2.Controls.Add(this.label7);
            this.groupBoxFingers2.Controls.Add(this.label8);
            this.groupBoxFingers2.Controls.Add(this.label9);
            this.groupBoxFingers2.Location = new System.Drawing.Point(253, 30);
            this.groupBoxFingers2.Name = "groupBoxFingers2";
            this.groupBoxFingers2.Size = new System.Drawing.Size(234, 174);
            this.groupBoxFingers2.TabIndex = 3;
            this.groupBoxFingers2.TabStop = false;
            this.groupBoxFingers2.Text = "Setup 1 Finger(s) Controls on Y Axis";
            // 
            // btnTestY
            // 
            this.btnTestY.Location = new System.Drawing.Point(53, 143);
            this.btnTestY.Name = "btnTestY";
            this.btnTestY.Size = new System.Drawing.Size(112, 23);
            this.btnTestY.TabIndex = 9;
            this.btnTestY.Text = "Send Test Message";
            this.btnTestY.UseVisualStyleBackColor = true;
            this.btnTestY.Click += new System.EventHandler(this.btnTestY_Click);
            // 
            // numMaxValueY
            // 
            this.numMaxValueY.Location = new System.Drawing.Point(106, 117);
            this.numMaxValueY.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numMaxValueY.Name = "numMaxValueY";
            this.numMaxValueY.Size = new System.Drawing.Size(59, 20);
            this.numMaxValueY.TabIndex = 7;
            // 
            // numMinValueY
            // 
            this.numMinValueY.Location = new System.Drawing.Point(106, 89);
            this.numMinValueY.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numMinValueY.Name = "numMinValueY";
            this.numMinValueY.Size = new System.Drawing.Size(59, 20);
            this.numMinValueY.TabIndex = 6;
            // 
            // numChannelY
            // 
            this.numChannelY.Location = new System.Drawing.Point(106, 61);
            this.numChannelY.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numChannelY.Name = "numChannelY";
            this.numChannelY.Size = new System.Drawing.Size(59, 20);
            this.numChannelY.TabIndex = 5;
            this.numChannelY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCtrlMsgY
            // 
            this.numCtrlMsgY.Location = new System.Drawing.Point(106, 33);
            this.numCtrlMsgY.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numCtrlMsgY.Name = "numCtrlMsgY";
            this.numCtrlMsgY.Size = new System.Drawing.Size(59, 20);
            this.numCtrlMsgY.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Maximum Value :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Minimum Value :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Channel :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Control Message :";
            // 
            // FormPairing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 242);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupBoxFingers2);
            this.Controls.Add(this.numFingers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxFingers1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPairing";
            this.ShowInTaskbar = false;
            this.Text = "Pairing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPairing_FormClosed);
            this.Load += new System.EventHandler(this.FormPairing_Load);
            this.Shown += new System.EventHandler(this.FormPairing_Shown);
            this.groupBoxFingers1.ResumeLayout(false);
            this.groupBoxFingers1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxValueX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinValueX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChannelX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCtrlMsgX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFingers)).EndInit();
            this.groupBoxFingers2.ResumeLayout(false);
            this.groupBoxFingers2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxValueY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinValueY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChannelY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCtrlMsgY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFingers1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numFingers;
        private System.Windows.Forms.NumericUpDown numCtrlMsgX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMaxValueX;
        private System.Windows.Forms.NumericUpDown numMinValueX;
        private System.Windows.Forms.NumericUpDown numChannelX;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.GroupBox groupBoxFingers2;
        private System.Windows.Forms.NumericUpDown numMaxValueY;
        private System.Windows.Forms.NumericUpDown numMinValueY;
        private System.Windows.Forms.NumericUpDown numChannelY;
        private System.Windows.Forms.NumericUpDown numCtrlMsgY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTestX;
        private System.Windows.Forms.Button btnTestY;
    }
}