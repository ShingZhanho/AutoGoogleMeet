﻿using System;
using System.ComponentModel;
using System.Drawing;
using AutoGoogleMeet.Settings;

namespace AutoGoogleMeet.UI.SetupUI {
    partial class frmSetupUserAgreement {
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
            this.panImage = new System.Windows.Forms.Panel();
            this.panButtons = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panDesc = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panImage
            // 
            this.panImage.BackColor = System.Drawing.Color.White;
            this.panImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panImage.Location = new System.Drawing.Point(0, 0);
            this.panImage.Margin = new System.Windows.Forms.Padding(0);
            this.panImage.Name = "panImage";
            this.panImage.Size = new System.Drawing.Size(625, 55);
            this.panImage.TabIndex = 0;
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
            this.panDesc.BackColor = System.Drawing.SystemColors.Control;
            this.panDesc.Location = new System.Drawing.Point(0, 55);
            this.panDesc.Margin = new System.Windows.Forms.Padding(0);
            this.panDesc.Name = "panDesc";
            this.panDesc.Size = new System.Drawing.Size(625, 321);
            this.panDesc.TabIndex = 2;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.Color.DimGray;
            this.lblVersion.Location = new System.Drawing.Point(3, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(101, 20);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "{%version%}";
            // 
            // frmSetupUserAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 425);
            this.ControlBox = false;
            this.Controls.Add(this.panDesc);
            this.Controls.Add(this.panButtons);
            this.Controls.Add(this.panImage);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmSetupUserAgreement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Google Meet 設定精靈";
            this.panButtons.ResumeLayout(false);
            this.panButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnNext;

        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.Panel panDesc;

        private System.Windows.Forms.Panel panButtons;

        private System.Windows.Forms.Panel panImage;

        #endregion

        private System.Windows.Forms.Label lblVersion;
    }
}