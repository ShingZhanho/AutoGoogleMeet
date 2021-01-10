using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGoogleMeet.UI.SetupUI {
    public partial class frmSetupCopyFiles : TemplateSetupForm {
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.pgBar = new System.Windows.Forms.ProgressBar();
            this.lblCurrentOperation = new System.Windows.Forms.Label();
            this.panDesc.SuspendLayout();
            this.panButtons.SuspendLayout();
            this.panImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panDesc
            // 
            this.panDesc.Controls.Add(this.lblCurrentOperation);
            this.panDesc.Controls.Add(this.pgBar);
            this.panDesc.Controls.Add(this.label1);
            // 
            // lblDesc
            // 
            this.lblDesc.Size = new System.Drawing.Size(247, 15);
            this.lblDesc.Text = "設定程式正在將必要的檔案複製到你的系統中";
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(99, 19);
            this.lblTitle.Text = "準備必要檔案";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "請稍候...";
            // 
            // pgBar
            // 
            this.pgBar.Location = new System.Drawing.Point(16, 43);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(601, 23);
            this.pgBar.TabIndex = 1;
            // 
            // lblCurrentOperation
            // 
            this.lblCurrentOperation.AutoSize = true;
            this.lblCurrentOperation.Location = new System.Drawing.Point(11, 83);
            this.lblCurrentOperation.Name = "lblCurrentOperation";
            this.lblCurrentOperation.Size = new System.Drawing.Size(85, 20);
            this.lblCurrentOperation.TabIndex = 2;
            this.lblCurrentOperation.Text = "正在開始...";
            // 
            // frmSetupCopyFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(626, 425);
            this.Name = "frmSetupCopyFiles";
            this.Load += new System.EventHandler(this.frmSetupCopyFiles_Load);
            this.panDesc.ResumeLayout(false);
            this.panDesc.PerformLayout();
            this.panButtons.ResumeLayout(false);
            this.panButtons.PerformLayout();
            this.panImage.ResumeLayout(false);
            this.panImage.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblCurrentOperation;
        private System.Windows.Forms.ProgressBar pgBar;
        private System.Windows.Forms.Label label1;
    }
}
