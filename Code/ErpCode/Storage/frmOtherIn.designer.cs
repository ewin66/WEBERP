namespace Storage
{
    partial class frmOtherIn
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
            DevExpress.XtraEditors.Controls.ComboBoxItem comboBoxItem1 = new DevExpress.XtraEditors.Controls.ComboBoxItem();
            DevExpress.XtraEditors.Controls.ComboBoxItem comboBoxItem2 = new DevExpress.XtraEditors.Controls.ComboBoxItem();
            DevExpress.XtraEditors.Controls.ComboBoxItem comboBoxItem3 = new DevExpress.XtraEditors.Controls.ComboBoxItem();
            DevExpress.XtraEditors.Controls.ComboBoxItem comboBoxItem4 = new DevExpress.XtraEditors.Controls.ComboBoxItem();
            DevExpress.XtraEditors.Controls.ComboBoxItem comboBoxItem5 = new DevExpress.XtraEditors.Controls.ComboBoxItem();
            DevExpress.XtraEditors.Controls.ComboBoxItem comboBoxItem6 = new DevExpress.XtraEditors.Controls.ComboBoxItem();
            DevExpress.XtraEditors.Controls.ComboBoxItem comboBoxItem7 = new DevExpress.XtraEditors.Controls.ComboBoxItem();
            this.editControl5 = new myControl.EditControl();
            this.lupControl2 = new myControl.lupControl();
            this.cbControl1 = new myControl.cbControl();
            this.lupControl1 = new myControl.lupControl();
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
            this.panelControl1.Controls.Add(this.lupControl1);
            this.panelControl1.Controls.Add(this.cbControl1);
            this.panelControl1.Controls.Add(this.lupControl2);
            this.panelControl1.Controls.Add(this.editControl5);
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelControl1.Size = new System.Drawing.Size(1075, 142);
            this.panelControl1.Controls.SetChildIndex(this.lbTitle, 0);
            this.panelControl1.Controls.SetChildIndex(this.editControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.dateControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.editControl5, 0);
            this.panelControl1.Controls.SetChildIndex(this.lupControl2, 0);
            this.panelControl1.Controls.SetChildIndex(this.cbControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.lupControl1, 0);
            // 
            // editControl4
            // 
            this.editControl4.Location = new System.Drawing.Point(833, 8);
            // 
            // editControl3
            // 
            this.editControl3.Location = new System.Drawing.Point(378, 8);
            // 
            // dateControl1
            // 
            this.dateControl1.Location = new System.Drawing.Point(299, 31);
            this.dateControl1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // editControl1
            // 
            this.editControl1.Location = new System.Drawing.Point(299, 0);
            this.editControl1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // editControl5
            // 
            this.editControl5.BackColor = System.Drawing.Color.Transparent;
            this.editControl5.DataField = "F_Remark";
            this.editControl5.DataSource = null;
            this.editControl5.EditLabel = "��ע:";
            this.editControl5.Location = new System.Drawing.Point(48, 101);
            this.editControl5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl5.Name = "editControl5";
            this.editControl5.Request = false;
            this.editControl5.Size = new System.Drawing.Size(888, 29);
            this.editControl5.TabIndex = 4;
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
            this.lupControl2.Location = new System.Drawing.Point(368, 65);
            this.lupControl2.LookUpDataSource = null;
            this.lupControl2.LookUpDisplayField = null;
            this.lupControl2.LookUpKeyField = null;
            this.lupControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lupControl2.Name = "lupControl2";
            this.lupControl2.PopWidth = 150;
            this.lupControl2.Request = true;
            this.lupControl2.Size = new System.Drawing.Size(212, 28);
            this.lupControl2.TabIndex = 6;
            // 
            // cbControl1
            // 
            this.cbControl1.BackColor = System.Drawing.Color.Transparent;
            comboBoxItem1.Value = "�ɹ��������";
            comboBoxItem2.Value = "�����˻����";
            comboBoxItem3.Value = "�����������";
            comboBoxItem4.Value = "�����깤���";
            comboBoxItem5.Value = "ί���������";
            comboBoxItem6.Value = "ί���깤���";
            comboBoxItem7.Value = "�������";
            this.cbControl1.cbItem = new DevExpress.XtraEditors.Controls.ComboBoxItem[] {
        comboBoxItem1,
        comboBoxItem2,
        comboBoxItem3,
        comboBoxItem4,
        comboBoxItem5,
        comboBoxItem6,
        comboBoxItem7};
            this.cbControl1.DataField = "F_Type";
            this.cbControl1.DataSource = null;
            this.cbControl1.EditLabel = "�������:";
            this.cbControl1.EditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbControl1.Location = new System.Drawing.Point(16, 66);
            this.cbControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbControl1.Name = "cbControl1";
            this.cbControl1.Request = true;
            this.cbControl1.SelectedIndex = -1;
            this.cbControl1.Size = new System.Drawing.Size(303, 26);
            this.cbControl1.TabIndex = 7;
            this.cbControl1.SelectIndexChange += new myControl.SelectIndexChangeEventHandler(this.cbControl1_SelectIndexChange);
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
            this.lupControl1.Location = new System.Drawing.Point(607, 65);
            this.lupControl1.LookUpDataSource = null;
            this.lupControl1.LookUpDisplayField = null;
            this.lupControl1.LookUpKeyField = null;
            this.lupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lupControl1.Name = "lupControl1";
            this.lupControl1.PopWidth = 270;
            this.lupControl1.Request = false;
            this.lupControl1.Size = new System.Drawing.Size(329, 28);
            this.lupControl1.TabIndex = 8;
            // 
            // frmOtherIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1075, 679);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmOtherIn";
            this.Text = "�������ֵ�";
            this.Load += new System.EventHandler(this.frmOtherIn_Load);
            this.Shown += new System.EventHandler(this.frmOtherIn_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.binMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binSlaver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public myControl.EditControl editControl5;
        public myControl.lupControl lupControl2;
        public myControl.cbControl cbControl1;
        public myControl.lupControl lupControl1;

    }
}
