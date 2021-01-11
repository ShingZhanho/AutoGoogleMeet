using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGoogleMeet.UI.SetupUI {
    public partial class frmSetupGAccount {
        private void InitializeComponent() {
            this.panButtons.SuspendLayout();
            this.panImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
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
            // frmSetupGAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(626, 425);
            this.Name = "frmSetupGAccount";
            this.panButtons.ResumeLayout(false);
            this.panButtons.PerformLayout();
            this.panImage.ResumeLayout(false);
            this.panImage.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
