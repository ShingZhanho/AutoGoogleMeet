using System;

public partial class frmUserAgreement {
    private void InitializeComponent() {
            this.rtfUA = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panDesc.SuspendLayout();
            this.panButtons.SuspendLayout();
            this.panImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panDesc
            // 
            this.panDesc.Controls.Add(this.label1);
            this.panDesc.Controls.Add(this.rtfUA);
            // 
            // lblDesc
            // 
            this.lblDesc.Size = new System.Drawing.Size(293, 15);
            this.lblDesc.Text = "要使用Auto Google Meet，你必須同意使用者條款。";
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(84, 19);
            this.lblTitle.Text = "使用者條款";
            // 
            // rtfUA
            // 
            this.rtfUA.Location = new System.Drawing.Point(16, 15);
            this.rtfUA.Name = "rtfUA";
            this.rtfUA.ReadOnly = true;
            this.rtfUA.Size = new System.Drawing.Size(601, 276);
            this.rtfUA.TabIndex = 0;
            this.rtfUA.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "如你同意上述條款，按「下一步」，否則，按「取消」。";
            // 
            // frmUserAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(626, 425);
            this.Name = "frmUserAgreement";
            this.panDesc.ResumeLayout(false);
            this.panDesc.PerformLayout();
            this.panButtons.ResumeLayout(false);
            this.panButtons.PerformLayout();
            this.panImage.ResumeLayout(false);
            this.panImage.PerformLayout();
            this.ResumeLayout(false);

    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RichTextBox rtfUA;
}
