namespace Base
{
    partial class frmEditSupplier
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
            this.editControl1 = new myControl.EditControl();
            this.editControl2 = new myControl.EditControl();
            this.lupControl1 = new myControl.lupControl();
            this.editControl3 = new myControl.EditControl();
            this.editControl4 = new myControl.EditControl();
            this.editControl5 = new myControl.EditControl();
            this.editControl6 = new myControl.EditControl();
            this.editControl7 = new myControl.EditControl();
            this.editControl8 = new myControl.EditControl();
            this.editControl9 = new myControl.EditControl();
            this.ckOption = new DevExpress.XtraEditors.CheckEdit();
            this.editControl10 = new myControl.EditControl();
            this.editControl11 = new myControl.EditControl();
            this.editControl12 = new myControl.EditControl();
            this.editControl13 = new myControl.EditControl();
            this.editControl14 = new myControl.EditControl();
            this.editControl15 = new myControl.EditControl();
            this.editControl16 = new myControl.EditControl();
            this.gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckCopy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckOption.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Appearance.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.Appearance.Options.UseFont = true;
            this.BtnOK.Location = new System.Drawing.Point(497, 470);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(5);
            this.BtnOK.Text = "����(&S)";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(605, 470);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.editControl16);
            this.gbox.Controls.Add(this.editControl15);
            this.gbox.Controls.Add(this.editControl14);
            this.gbox.Controls.Add(this.editControl13);
            this.gbox.Controls.Add(this.editControl12);
            this.gbox.Controls.Add(this.editControl11);
            this.gbox.Controls.Add(this.editControl10);
            this.gbox.Controls.Add(this.editControl9);
            this.gbox.Controls.Add(this.editControl8);
            this.gbox.Controls.Add(this.editControl7);
            this.gbox.Controls.Add(this.editControl6);
            this.gbox.Controls.Add(this.editControl5);
            this.gbox.Controls.Add(this.editControl4);
            this.gbox.Controls.Add(this.editControl3);
            this.gbox.Controls.Add(this.lupControl1);
            this.gbox.Controls.Add(this.editControl2);
            this.gbox.Controls.Add(this.editControl1);
            this.gbox.Margin = new System.Windows.Forms.Padding(5);
            this.gbox.Padding = new System.Windows.Forms.Padding(5);
            this.gbox.Size = new System.Drawing.Size(688, 429);
            // 
            // ckCopy
            // 
            // 
            // editControl1
            // 
            this.editControl1.BackColor = System.Drawing.Color.Transparent;
            this.editControl1.DataField = "F_ID";
            this.editControl1.DataSource = null;
            this.editControl1.EditLabel = "��Ӧ�̴���:";
            this.editControl1.Location = new System.Drawing.Point(9, 26);
            this.editControl1.Margin = new System.Windows.Forms.Padding(5);
            this.editControl1.Name = "editControl1";
            this.editControl1.Request = true;
            this.editControl1.Size = new System.Drawing.Size(285, 34);
            this.editControl1.TabIndex = 0;
            // 
            // editControl2
            // 
            this.editControl2.BackColor = System.Drawing.Color.Transparent;
            this.editControl2.DataField = "F_Name";
            this.editControl2.DataSource = null;
            this.editControl2.EditLabel = "��Ӧ������:";
            this.editControl2.Location = new System.Drawing.Point(340, 26);
            this.editControl2.Margin = new System.Windows.Forms.Padding(5);
            this.editControl2.Name = "editControl2";
            this.editControl2.Request = true;
            this.editControl2.Size = new System.Drawing.Size(340, 34);
            this.editControl2.TabIndex = 1;
            // 
            // lupControl1
            // 
            this.lupControl1.BackColor = System.Drawing.Color.Transparent;
            this.lupControl1.DataField = "F_Type";
            this.lupControl1.DataSource = null;
            this.lupControl1.DisplayCaption = "";
            this.lupControl1.DropSQL = "";
            this.lupControl1.EditLabel = "��    ��:";
            this.lupControl1.InvokeClass = "";
            this.lupControl1.LinkFields = null;
            this.lupControl1.Location = new System.Drawing.Point(24, 68);
            this.lupControl1.LookUpDataSource = null;
            this.lupControl1.LookUpDisplayField = null;
            this.lupControl1.LookUpKeyField = null;
            this.lupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.lupControl1.Name = "lupControl1";
            this.lupControl1.PopWidth = 150;
            this.lupControl1.Request = true;
            this.lupControl1.Size = new System.Drawing.Size(271, 28);
            this.lupControl1.TabIndex = 2;
            // 
            // editControl3
            // 
            this.editControl3.BackColor = System.Drawing.Color.Transparent;
            this.editControl3.DataField = "F_LinkMan";
            this.editControl3.DataSource = null;
            this.editControl3.EditLabel = "��ϵ��:";
            this.editControl3.Location = new System.Drawing.Point(372, 68);
            this.editControl3.Margin = new System.Windows.Forms.Padding(5);
            this.editControl3.Name = "editControl3";
            this.editControl3.Request = false;
            this.editControl3.Size = new System.Drawing.Size(308, 34);
            this.editControl3.TabIndex = 3;
            // 
            // editControl4
            // 
            this.editControl4.BackColor = System.Drawing.Color.Transparent;
            this.editControl4.DataField = "F_Tel";
            this.editControl4.DataSource = null;
            this.editControl4.EditLabel = "��ϵ�绰1:";
            this.editControl4.Location = new System.Drawing.Point(17, 102);
            this.editControl4.Margin = new System.Windows.Forms.Padding(5);
            this.editControl4.Name = "editControl4";
            this.editControl4.Request = false;
            this.editControl4.Size = new System.Drawing.Size(303, 34);
            this.editControl4.TabIndex = 4;
            // 
            // editControl5
            // 
            this.editControl5.BackColor = System.Drawing.Color.Transparent;
            this.editControl5.DataField = "F_Bank";
            this.editControl5.DataSource = null;
            this.editControl5.EditLabel = "��������:";
            this.editControl5.Location = new System.Drawing.Point(24, 182);
            this.editControl5.Margin = new System.Windows.Forms.Padding(5);
            this.editControl5.Name = "editControl5";
            this.editControl5.Request = false;
            this.editControl5.Size = new System.Drawing.Size(284, 26);
            this.editControl5.TabIndex = 7;
            // 
            // editControl6
            // 
            this.editControl6.BackColor = System.Drawing.Color.Transparent;
            this.editControl6.DataField = "F_BankNo";
            this.editControl6.DataSource = null;
            this.editControl6.EditLabel = "�����ʺ�:";
            this.editControl6.Location = new System.Drawing.Point(325, 182);
            this.editControl6.Margin = new System.Windows.Forms.Padding(5);
            this.editControl6.Name = "editControl6";
            this.editControl6.Request = false;
            this.editControl6.Size = new System.Drawing.Size(355, 26);
            this.editControl6.TabIndex = 8;
            // 
            // editControl7
            // 
            this.editControl7.BackColor = System.Drawing.Color.Transparent;
            this.editControl7.DataField = "F_PostCode";
            this.editControl7.DataSource = null;
            this.editControl7.EditLabel = "�ʱ�:";
            this.editControl7.Location = new System.Drawing.Point(356, 224);
            this.editControl7.Margin = new System.Windows.Forms.Padding(5);
            this.editControl7.Name = "editControl7";
            this.editControl7.Request = false;
            this.editControl7.Size = new System.Drawing.Size(324, 34);
            this.editControl7.TabIndex = 10;
            // 
            // editControl8
            // 
            this.editControl8.BackColor = System.Drawing.Color.Transparent;
            this.editControl8.DataField = "F_Adr";
            this.editControl8.DataSource = null;
            this.editControl8.EditLabel = "��ַ:";
            this.editControl8.Location = new System.Drawing.Point(53, 265);
            this.editControl8.Margin = new System.Windows.Forms.Padding(5);
            this.editControl8.Name = "editControl8";
            this.editControl8.Request = false;
            this.editControl8.Size = new System.Drawing.Size(627, 34);
            this.editControl8.TabIndex = 11;
            // 
            // editControl9
            // 
            this.editControl9.BackColor = System.Drawing.Color.Transparent;
            this.editControl9.DataField = "F_Remark";
            this.editControl9.DataSource = null;
            this.editControl9.EditLabel = "��ע:";
            this.editControl9.Location = new System.Drawing.Point(53, 306);
            this.editControl9.Margin = new System.Windows.Forms.Padding(5);
            this.editControl9.Name = "editControl9";
            this.editControl9.Request = false;
            this.editControl9.Size = new System.Drawing.Size(627, 34);
            this.editControl9.TabIndex = 12;
            // 
            // ckOption
            // 
            this.ckOption.EditValue = true;
            this.ckOption.Location = new System.Drawing.Point(24, 468);
            this.ckOption.Margin = new System.Windows.Forms.Padding(4);
            this.ckOption.Name = "ckOption";
            this.ckOption.Properties.Caption = "���������";
            this.ckOption.Size = new System.Drawing.Size(135, 23);
            this.ckOption.TabIndex = 3;
            this.ckOption.CheckedChanged += new System.EventHandler(this.ckOption_CheckedChanged);
            // 
            // editControl10
            // 
            this.editControl10.BackColor = System.Drawing.Color.Transparent;
            this.editControl10.DataField = "F_Fax";
            this.editControl10.DataSource = null;
            this.editControl10.EditLabel = "����:";
            this.editControl10.Location = new System.Drawing.Point(56, 224);
            this.editControl10.Margin = new System.Windows.Forms.Padding(5);
            this.editControl10.Name = "editControl10";
            this.editControl10.Request = false;
            this.editControl10.Size = new System.Drawing.Size(252, 34);
            this.editControl10.TabIndex = 9;
            // 
            // editControl11
            // 
            this.editControl11.BackColor = System.Drawing.Color.Transparent;
            this.editControl11.DataField = "F_Tel1";
            this.editControl11.DataSource = null;
            this.editControl11.EditLabel = "��ϵ�绰2:";
            this.editControl11.Location = new System.Drawing.Point(348, 102);
            this.editControl11.Margin = new System.Windows.Forms.Padding(5);
            this.editControl11.Name = "editControl11";
            this.editControl11.Request = false;
            this.editControl11.Size = new System.Drawing.Size(331, 34);
            this.editControl11.TabIndex = 5;
            // 
            // editControl12
            // 
            this.editControl12.BackColor = System.Drawing.Color.Transparent;
            this.editControl12.DataField = "F_Tel2";
            this.editControl12.DataSource = null;
            this.editControl12.EditLabel = "��ϵ�绰3:";
            this.editControl12.Location = new System.Drawing.Point(17, 144);
            this.editControl12.Margin = new System.Windows.Forms.Padding(5);
            this.editControl12.Name = "editControl12";
            this.editControl12.Request = false;
            this.editControl12.Size = new System.Drawing.Size(303, 31);
            this.editControl12.TabIndex = 6;
            // 
            // editControl13
            // 
            this.editControl13.BackColor = System.Drawing.Color.Transparent;
            this.editControl13.DataField = "F_Grade2";
            this.editControl13.DataSource = null;
            this.editControl13.EditLabel = "���������ȼ�:";
            this.editControl13.Location = new System.Drawing.Point(221, 348);
            this.editControl13.Margin = new System.Windows.Forms.Padding(5);
            this.editControl13.Name = "editControl13";
            this.editControl13.Request = false;
            this.editControl13.Size = new System.Drawing.Size(241, 34);
            this.editControl13.TabIndex = 13;
            // 
            // editControl14
            // 
            this.editControl14.BackColor = System.Drawing.Color.Transparent;
            this.editControl14.DataField = "F_Grade1";
            this.editControl14.DataSource = null;
            this.editControl14.EditLabel = "���ö�:";
            this.editControl14.Location = new System.Drawing.Point(37, 348);
            this.editControl14.Margin = new System.Windows.Forms.Padding(5);
            this.editControl14.Name = "editControl14";
            this.editControl14.Request = false;
            this.editControl14.Size = new System.Drawing.Size(153, 34);
            this.editControl14.TabIndex = 14;
            // 
            // editControl15
            // 
            this.editControl15.BackColor = System.Drawing.Color.Transparent;
            this.editControl15.DataField = "F_Grade3";
            this.editControl15.DataSource = null;
            this.editControl15.EditLabel = "��������:";
            this.editControl15.Location = new System.Drawing.Point(507, 348);
            this.editControl15.Margin = new System.Windows.Forms.Padding(5);
            this.editControl15.Name = "editControl15";
            this.editControl15.Request = false;
            this.editControl15.Size = new System.Drawing.Size(172, 34);
            this.editControl15.TabIndex = 15;
            // 
            // editControl16
            // 
            this.editControl16.BackColor = System.Drawing.Color.Transparent;
            this.editControl16.DataField = "F_QCMoney";
            this.editControl16.DataSource = null;
            this.editControl16.EditLabel = "�ڳ�:";
            this.editControl16.Location = new System.Drawing.Point(53, 389);
            this.editControl16.Margin = new System.Windows.Forms.Padding(5);
            this.editControl16.Name = "editControl16";
            this.editControl16.Request = false;
            this.editControl16.Size = new System.Drawing.Size(197, 34);
            this.editControl16.TabIndex = 16;
            // 
            // frmEditSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(719, 514);
            this.Controls.Add(this.ckOption);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmEditSupplier";
            this.Text = "��Ӧ������--�༭";
            this.Shown += new System.EventHandler(this.frmEditSupplier_Shown);
            this.Controls.SetChildIndex(this.ckCopy, 0);
            this.Controls.SetChildIndex(this.BtnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.ckOption, 0);
            this.Controls.SetChildIndex(this.gbox, 0);
            this.gbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.binData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckCopy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckOption.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public myControl.EditControl editControl1;
        public myControl.EditControl editControl2;
        public myControl.lupControl lupControl1;
        public myControl.EditControl editControl4;
        public myControl.EditControl editControl3;
        public myControl.EditControl editControl9;
        public myControl.EditControl editControl8;
        public myControl.EditControl editControl7;
        public myControl.EditControl editControl6;
        public myControl.EditControl editControl5;
        public DevExpress.XtraEditors.CheckEdit ckOption;
        public myControl.EditControl editControl10;
        public myControl.EditControl editControl12;
        public myControl.EditControl editControl11;
        public myControl.EditControl editControl13;
        public myControl.EditControl editControl15;
        public myControl.EditControl editControl14;
        public myControl.EditControl editControl16;


    }
}
