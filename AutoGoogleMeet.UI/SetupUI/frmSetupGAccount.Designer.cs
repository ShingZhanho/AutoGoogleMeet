﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGoogleMeet.UI.SetupUI {
    public partial class frmSetupGAccount {
        private void InitializeComponent() {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panDesc.SuspendLayout();
            this.panButtons.SuspendLayout();
            this.panImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            // 
            // panDesc
            // 
            this.panDesc.Controls.Add(this.textBox2);
            this.panDesc.Controls.Add(this.label4);
            this.panDesc.Controls.Add(this.label3);
            this.panDesc.Controls.Add(this.label2);
            this.panDesc.Controls.Add(this.label1);
            this.panDesc.Controls.Add(this.textBox1);
            // 
            // lblDesc
            // 
            this.lblDesc.Size = new System.Drawing.Size(234, 15);
            this.lblDesc.Text = "設定用於登入Google Meet的Google帳戶";
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(159, 19);
            this.lblTitle.Text = "使用者資料 - 登入資訊";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 28);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "請輸入你的Google帳戶及密碼。你的密碼將會被加密儲存在電腦中。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "電郵：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "@cpc.edu.hk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "密碼：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '※';
            this.textBox2.Size = new System.Drawing.Size(322, 28);
            this.textBox2.TabIndex = 5;
            // 
            // frmSetupGAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(626, 425);
            this.Name = "frmSetupGAccount";
            this.panDesc.ResumeLayout(false);
            this.panDesc.PerformLayout();
            this.panButtons.ResumeLayout(false);
            this.panButtons.PerformLayout();
            this.panImage.ResumeLayout(false);
            this.panImage.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
