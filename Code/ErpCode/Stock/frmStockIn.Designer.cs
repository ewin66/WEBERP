namespace Stock
{
    partial class frmStockIn
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
            this.lupControl1 = new myControl.lupControl();
            this.editControl5 = new myControl.EditControl();
            this.dateControl2 = new myControl.DateControl();
            this.lupControl2 = new myControl.lupControl();
            this.lupControl3 = new myControl.lupControl();
            this.editControl6 = new myControl.EditControl();
            this.dateControl3 = new myControl.DateControl();
            this.lupControl4 = new myControl.lupControl();
            ((System.ComponentModel.ISupportInitialize)(this.binMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binSlaver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTitle.Size = new System.Drawing.Size(117, 27);
            this.lbTitle.Text = "frmBase";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.OldLace;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.lupControl4);
            this.panelControl1.Controls.Add(this.dateControl3);
            this.panelControl1.Controls.Add(this.editControl6);
            this.panelControl1.Controls.Add(this.lupControl3);
            this.panelControl1.Controls.Add(this.lupControl2);
            this.panelControl1.Controls.Add(this.dateControl2);
            this.panelControl1.Controls.Add(this.editControl5);
            this.panelControl1.Controls.Add(this.lupControl1);
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelControl1.Size = new System.Drawing.Size(1079, 176);
            this.panelControl1.Controls.SetChildIndex(this.lbTitle, 0);
            this.panelControl1.Controls.SetChildIndex(this.editControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.dateControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.lupControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.editControl5, 0);
            this.panelControl1.Controls.SetChildIndex(this.dateControl2, 0);
            this.panelControl1.Controls.SetChildIndex(this.lupControl2, 0);
            this.panelControl1.Controls.SetChildIndex(this.lupControl3, 0);
            this.panelControl1.Controls.SetChildIndex(this.editControl6, 0);
            this.panelControl1.Controls.SetChildIndex(this.dateControl3, 0);
            this.panelControl1.Controls.SetChildIndex(this.lupControl4, 0);
            // 
            // editControl4
            // 
            this.editControl4.Location = new System.Drawing.Point(818, 8);
            this.editControl4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // editControl3
            // 
            this.editControl3.Location = new System.Drawing.Point(371, 8);
            this.editControl3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // dateControl1
            // 
            this.dateControl1.Location = new System.Drawing.Point(405, 45);
            this.dateControl1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // editControl1
            // 
            this.editControl1.Location = new System.Drawing.Point(408, 10);
            this.editControl1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // lupControl1
            // 
            this.lupControl1.BackColor = System.Drawing.Color.Transparent;
            this.lupControl1.DataField = "F_SupplierID";
            this.lupControl1.DataSource = null;
            this.lupControl1.DisplayCaption = "";
            this.lupControl1.DropSQL = "";
            this.lupControl1.EditLabel = "��Ӧ��:";
            this.lupControl1.InvokeClass = "";
            this.lupControl1.LinkFields = null;
            this.lupControl1.Location = new System.Drawing.Point(33, 70);
            this.lupControl1.LookUpDataSource = null;
            this.lupControl1.LookUpDisplayField = null;
            this.lupControl1.LookUpKeyField = null;
            this.lupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lupControl1.Name = "lupControl1";
            this.lupControl1.PopWidth = 150;
            this.lupControl1.Request = true;
            this.lupControl1.Size = new System.Drawing.Size(360, 28);
            this.lupControl1.TabIndex = 3;
            // 
            // editControl5
            // 
            this.editControl5.BackColor = System.Drawing.Color.Transparent;
            this.editControl5.DataField = "F_Remark";
            this.editControl5.DataSource = null;
            this.editControl5.EditLabel = "��ע:";
            this.editControl5.Location = new System.Drawing.Point(49, 142);
            this.editControl5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl5.Name = "editControl5";
            this.editControl5.Request = false;
            this.editControl5.Size = new System.Drawing.Size(887, 26);
            this.editControl5.TabIndex = 8;
            // 
            // dateControl2
            // 
            this.dateControl2.BackColor = System.Drawing.Color.Transparent;
            this.dateControl2.DataField = "F_StockTime";
            this.dateControl2.DataSource = null;
            this.dateControl2.DisplayFormat = "d";
            this.dateControl2.EditLabel = "��������:";
            this.dateControl2.EditMask = "d";
            this.dateControl2.Location = new System.Drawing.Point(452, 70);
            this.dateControl2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dateControl2.Name = "dateControl2";
            this.dateControl2.Request = true;
            this.dateControl2.Size = new System.Drawing.Size(240, 28);
            this.dateControl2.TabIndex = 4;
            // 
            // lupControl2
            // 
            this.lupControl2.BackColor = System.Drawing.Color.Transparent;
            this.lupControl2.DataField = "F_DeptID";
            this.lupControl2.DataSource = null;
            this.lupControl2.DisplayCaption = "";
            this.lupControl2.DropSQL = "";
            this.lupControl2.EditLabel = "����:";
            this.lupControl2.InvokeClass = "";
            this.lupControl2.LinkFields = null;
            this.lupControl2.Location = new System.Drawing.Point(49, 108);
            this.lupControl2.LookUpDataSource = null;
            this.lupControl2.LookUpDisplayField = null;
            this.lupControl2.LookUpKeyField = null;
            this.lupControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lupControl2.Name = "lupControl2";
            this.lupControl2.PopWidth = 150;
            this.lupControl2.Request = false;
            this.lupControl2.Size = new System.Drawing.Size(205, 28);
            this.lupControl2.TabIndex = 5;
            // 
            // lupControl3
            // 
            this.lupControl3.BackColor = System.Drawing.Color.Transparent;
            this.lupControl3.DataField = "F_StockMan";
            this.lupControl3.DataSource = null;
            this.lupControl3.DisplayCaption = "";
            this.lupControl3.DropSQL = "";
            this.lupControl3.EditLabel = "�ɹ�Ա:";
            this.lupControl3.InvokeClass = "";
            this.lupControl3.LinkFields = null;
            this.lupControl3.Location = new System.Drawing.Point(267, 108);
            this.lupControl3.LookUpDataSource = null;
            this.lupControl3.LookUpDisplayField = null;
            this.lupControl3.LookUpKeyField = null;
            this.lupControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lupControl3.Name = "lupControl3";
            this.lupControl3.PopWidth = 150;
            this.lupControl3.Request = false;
            this.lupControl3.Size = new System.Drawing.Size(203, 28);
            this.lupControl3.TabIndex = 6;
            // 
            // editControl6
            // 
            this.editControl6.BackColor = System.Drawing.Color.Transparent;
            this.editControl6.DataField = "F_ContractID";
            this.editControl6.DataSource = null;
            this.editControl6.EditLabel = "��ͬ��:";
            this.editControl6.Location = new System.Drawing.Point(477, 108);
            this.editControl6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl6.Name = "editControl6";
            this.editControl6.Request = false;
            this.editControl6.Size = new System.Drawing.Size(215, 28);
            this.editControl6.TabIndex = 7;
            // 
            // dateControl3
            // 
            this.dateControl3.BackColor = System.Drawing.Color.Transparent;
            this.dateControl3.DataField = "F_PayDate";
            this.dateControl3.DataSource = null;
            this.dateControl3.DisplayFormat = "d";
            this.dateControl3.EditLabel = "��������:";
            this.dateControl3.EditMask = "d";
            this.dateControl3.Location = new System.Drawing.Point(700, 108);
            this.dateControl3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dateControl3.Name = "dateControl3";
            this.dateControl3.Request = true;
            this.dateControl3.Size = new System.Drawing.Size(240, 28);
            this.dateControl3.TabIndex = 9;
            // 
            // lupControl4
            // 
            this.lupControl4.BackColor = System.Drawing.Color.Transparent;
            this.lupControl4.DataField = "F_PayMode";
            this.lupControl4.DataSource = null;
            this.lupControl4.DisplayCaption = "";
            this.lupControl4.DropSQL = "";
            this.lupControl4.EditLabel = "���ʽ:";
            this.lupControl4.InvokeClass = "";
            this.lupControl4.LinkFields = null;
            this.lupControl4.Location = new System.Drawing.Point(700, 70);
            this.lupControl4.LookUpDataSource = null;
            this.lupControl4.LookUpDisplayField = null;
            this.lupControl4.LookUpKeyField = null;
            this.lupControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lupControl4.Name = "lupControl4";
            this.lupControl4.PopWidth = 150;
            this.lupControl4.Request = true;
            this.lupControl4.Size = new System.Drawing.Size(236, 28);
            this.lupControl4.TabIndex = 10;
            // 
            // frmStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1079, 699);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmStockIn";
            this.Text = "�ɹ�������";
            this.Load += new System.EventHandler(this.frmStockOrder_Load);
            this.Shown += new System.EventHandler(this.frmStockIn_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStockIn_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.binMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binSlaver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public myControl.lupControl lupControl1;
        public myControl.EditControl editControl5;
        public myControl.DateControl dateControl2;
        public myControl.EditControl editControl6;
        public myControl.lupControl lupControl3;
        public myControl.lupControl lupControl2;
        public myControl.DateControl dateControl3;
        public myControl.lupControl lupControl4;

    }
}
