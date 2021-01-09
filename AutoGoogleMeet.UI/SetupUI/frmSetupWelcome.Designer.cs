using System;
using System.ComponentModel;
using System.Drawing;
using AutoGoogleMeet.Settings;

namespace AutoGoogleMeet.UI.SetupUI {
    partial class frmSetupWelcome {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetupWelcome));
            this.panImage = new System.Windows.Forms.Panel();
            this.panButtons = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panDesc = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panButtons.SuspendLayout();
            this.panDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panImage
            // 
            this.panImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panImage.BackgroundImage")));
            this.panImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panImage.Location = new System.Drawing.Point(0, 0);
            this.panImage.Margin = new System.Windows.Forms.Padding(0);
            this.panImage.Name = "panImage";
            this.panImage.Size = new System.Drawing.Size(171, 376);
            this.panImage.TabIndex = 0;
            // 
            // panButtons
            // 
            this.panButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panButtons.Controls.Add(this.btnNext);
            this.panButtons.Controls.Add(this.btnCancel);
            this.panButtons.Location = new System.Drawing.Point(0, 375);
            this.panButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(633, 59);
            this.panButtons.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(407, 12);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(108, 25);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "下一步 >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(528, 12);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 25);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panDesc
            // 
            this.panDesc.BackColor = System.Drawing.Color.White;
            this.panDesc.Controls.Add(this.label2);
            this.panDesc.Controls.Add(this.label1);
            this.panDesc.Controls.Add(this.lblVersion);
            this.panDesc.Location = new System.Drawing.Point(170, 0);
            this.panDesc.Margin = new System.Windows.Forms.Padding(0);
            this.panDesc.Name = "panDesc";
            this.panDesc.Size = new System.Drawing.Size(463, 376);
            this.panDesc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 100);
            this.label2.TabIndex = 1;
            this.label2.Text = "此精靈將會引導你設定Auto Google Meet。要繼續，請按下一步；否則，按取消。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "歡迎使用Auto Google Meet";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(355, 356);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(106, 20);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "v0.0.1.1_beta";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmSetupWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 425);
            this.ControlBox = false;
            this.Controls.Add(this.panDesc);
            this.Controls.Add(this.panButtons);
            this.Controls.Add(this.panImage);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmSetupWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Google Meet 設定精靈";
            this.panButtons.ResumeLayout(false);
            this.panDesc.ResumeLayout(false);
            this.panDesc.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnNext;

        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.Label lblVersion;

        private System.Windows.Forms.Panel panDesc;

        private System.Windows.Forms.Panel panButtons;

        private System.Windows.Forms.Panel panImage;

        #endregion
    }
}