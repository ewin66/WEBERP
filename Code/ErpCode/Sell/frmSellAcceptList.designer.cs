namespace Sell
{
    partial class frmSellAcceptList
    {
        /// <summary>
        /// ����������������
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// ������������ʹ�õ���Դ��
        /// </summary>
        /// <param name="disposing">���Ӧ�ͷ��й���Դ��Ϊ true������Ϊ false��</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows ������������ɵĴ���

        /// <summary>
        /// �����֧������ķ��� - ��Ҫ
        /// ʹ�ô���༭���޸Ĵ˷��������ݡ�
        /// </summary>
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.cbType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFinish.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCutOff.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbType
            // 
            this.cbType.Size = new System.Drawing.Size(60, 23);
            // 
            // cbCheck
            // 
            this.cbCheck.Size = new System.Drawing.Size(61, 23);
            // 
            // cbFinish
            // 
            this.cbFinish.Size = new System.Drawing.Size(61, 23);
            this.cbFinish.Visible = false;
            // 
            // cbCutOff
            // 
            this.cbCutOff.Size = new System.Drawing.Size(61, 23);
            this.cbCutOff.Visible = false;
            // 
            // label2
            // 
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Visible = false;
            // 
            // frmSellAcceptList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(809, 526);
            this.Name = "frmSellAcceptList";
            this.Text = "�����տ�б�";
            ((System.ComponentModel.ISupportInitialize)(this.cbType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFinish.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCutOff.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}