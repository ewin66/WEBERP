using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sys
{
    public partial class frmEditModule : BaseClass.frmBase
    {
        private bool blnEdit = false;
        public string strId = "";
        public string strName = "";
        public string strModule = "";
        public DevExpress.XtraGrid.Views.Grid.GridView gvGrid;

        public frmEditModule()
        {
            InitializeComponent();
        }

        /// <summary>
        /// �༭Ȩ��
        /// </summary>
        /// <param name="strZH"></param>
        /// <param name="strField"></param>
        public void Edit(string strZH, string strField)
        {
            textBox1.Text = strZH;
            textBox2.Text = strField;
            blnEdit = true;
        }

        /// <summary>
        /// ������ϸȨ��
        /// </summary>
        public void Save()
        {
            string strSQL = "";

            if (textBox1.Text == "")
            {
                MessageBox.Show(this, "ģ���Ų���Ϊ��!!", "��ʾ");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show(this, "ģ�����Ʋ���Ϊ��!!", "��ʾ");
                textBox2.Focus();
                return;
            }

            DataLib.DataHelper myHelper = new DataLib.DataHelper();
            if (strId == "")
            {
                strSQL = "insert into t_Right values('" + strModule + "','" + textBox1.Text + "','" + textBox2.Text + "')";
                myHelper.ExecuteSQL(strSQL);
            }
            else
            {
                strSQL = "update t_Right set F_id='" + textBox1.Text + "',f_name='" + textBox2.Text + "' where f_id='" + strId + "' and f_name='" + strName + "'";
                myHelper.ExecuteSQL(strSQL);
            }
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEditModule_Load(object sender, EventArgs e)
        {
            Edit(strId, strName);
        }
    }
}

