namespace PizzaTowerBankEditor.Forms
{
    partial class AboutForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deltomCarrdLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.radixCometLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PizzaTowerBankEditor.Properties.Resources.spaghettiTunes1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(236, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pizza Tower Bank Editor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Version: X.X.X.X";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // deltomCarrdLinkLabel
            // 
            this.deltomCarrdLinkLabel.AutoSize = true;
            this.deltomCarrdLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(14, 20);
            this.deltomCarrdLinkLabel.Location = new System.Drawing.Point(236, 95);
            this.deltomCarrdLinkLabel.Name = "deltomCarrdLinkLabel";
            this.deltomCarrdLinkLabel.Size = new System.Drawing.Size(115, 21);
            this.deltomCarrdLinkLabel.TabIndex = 5;
            this.deltomCarrdLinkLabel.TabStop = true;
            this.deltomCarrdLinkLabel.Text = "Icon Credits: Deltom";
            this.deltomCarrdLinkLabel.UseCompatibleTextRendering = true;
            this.deltomCarrdLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deltomCarrdLinkLabel_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Discord: RadixComet#1125";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // radixCometLinkLabel
            // 
            this.radixCometLinkLabel.AutoSize = true;
            this.radixCometLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(12, 18);
            this.radixCometLinkLabel.Location = new System.Drawing.Point(236, 53);
            this.radixCometLinkLabel.Name = "radixCometLinkLabel";
            this.radixCometLinkLabel.Size = new System.Drawing.Size(136, 21);
            this.radixCometLinkLabel.TabIndex = 8;
            this.radixCometLinkLabel.TabStop = true;
            this.radixCometLinkLabel.Text = "Created by: RadixComet";
            this.radixCometLinkLabel.UseCompatibleTextRendering = true;
            this.radixCometLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.radixCometLinkLabel_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 242);
            this.Controls.Add(this.radixCometLinkLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deltomCarrdLinkLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private LinkLabel deltomCarrdLinkLabel;
        private Label label5;
        private LinkLabel radixCometLinkLabel;
    }
}