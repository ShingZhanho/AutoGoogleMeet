using System;
using System.ComponentModel;
using System.Drawing;
using AutoGoogleMeet.Settings;

namespace AutoGoogleMeet.UI.SetupUI {
    public partial class TemplateSetupForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public IContainer components = null;

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
        public void InitializeComponent() {
            this.panImage = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panButtons = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panDesc = new System.Windows.Forms.Panel();
            this.panImage.SuspendLayout();
            this.panButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panImage
            // 
            this.panImage.BackColor = System.Drawing.Color.White;
            this.panImage.BackgroundImage = global::AutoGoogleMeet.UI.Properties.Resources.SetupBanner;
            this.panImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panImage.Controls.Add(this.lblDesc);
            this.panImage.Controls.Add(this.lblTitle);
            this.panImage.Location = new System.Drawing.Point(0, 0);
            this.panImage.Margin = new System.Windows.Forms.Padding(0);
            this.panImage.Name = "panImage";
            this.panImage.Size = new System.Drawing.Size(625, 55);
            this.panImage.TabIndex = 0;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(12, 28);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 15);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "{%desc%}";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(76, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "{%title%}";
            // 
            // panButtons
            // 
            this.panButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panButtons.Controls.Add(this.lblVersion);
            this.panButtons.Controls.Add(this.btnNext);
            this.panButtons.Controls.Add(this.btnCancel);
            this.panButtons.ForeColor = System.Drawing.Color.Black;
            this.panButtons.Location = new System.Drawing.Point(0, 375);
            this.panButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(630, 59);
            this.panButtons.TabIndex = 1;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.DimGray;
            this.lblVersion.Location = new System.Drawing.Point(3, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(77, 15);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "{%version%}";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(429, 12);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(86, 25);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "下一步 >";
            this.btnNext.UseVisualStyleBackColor = true;
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
            this.panDesc.BackColor = System.Drawing.SystemColors.Control;
            this.panDesc.Location = new System.Drawing.Point(0, 55);
            this.panDesc.Margin = new System.Windows.Forms.Padding(0);
            this.panDesc.Name = "panDesc";
            this.panDesc.Size = new System.Drawing.Size(625, 321);
            this.panDesc.TabIndex = 2;
            // 
            // TemplateSetupForm
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
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "TemplateSetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Google Meet 設定精靈";
            this.panImage.ResumeLayout(false);
            this.panImage.PerformLayout();
            this.panButtons.ResumeLayout(false);
            this.panButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        public System.Windows.Forms.Button btnNext;

        public System.Windows.Forms.Button btnCancel;

        public System.Windows.Forms.Panel panDesc;

        public System.Windows.Forms.Panel panButtons;

        public System.Windows.Forms.Panel panImage;

        public System.Windows.Forms.Label lblVersion;

        #endregion

        public System.Windows.Forms.Label lblDesc;
        public System.Windows.Forms.Label lblTitle;
    }
}