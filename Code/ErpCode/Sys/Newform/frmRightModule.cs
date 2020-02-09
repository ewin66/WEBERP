using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sys
{
    public partial class frmRightModule : BaseClass.frmBase
    {
        public frmRightModule()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                BindBigModule();
            }
            btnEdit.Visible = true;
        }

        /// <summary>
        /// ��ģ�����ݰ�
        /// </summary>
        private void BindBigModule()
        {
            string strSQL = "select F_ID,F_Name from t_Right where F_PID = ''";
            DataLib.DataHelper myHelp = new DataLib.DataHelper();
            DataSet ds = myHelp.GetDs(strSQL);
            lookUpEdit1.Properties.DataSource = ds.Tables[0].DefaultView;
            lookUpEdit1.Properties.ValueMember = "F_ID";
            lookUpEdit1.Properties.DisplayMember = "F_Name";

        }

        /// <summary>
        /// ���ݴ�ģ��ȡ��ӦСģ��
        /// </summary>
        /// <param name="strBigID"></param>
        private void BindModule(string strBigID)
        {
            string strSQL = "select * from t_Right where F_PID = '" + strBigID + "'";
            DataLib.DataHelper myHelp = new DataLib.DataHelper();
            DataSet ds = myHelp.GetDs(strSQL);
            GridModule.DataSource = ds.Tables[0].DefaultView;
        }


        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            BindModule(lookUpEdit1.Properties.GetKeyValueByDisplayText(lookUpEdit1.Text).ToString());
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// ������ӦȨ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (gvModule.FocusedRowHandle < 0) return;
            //DataRow drModule = gvModule.GetDataRow(gvModule.FocusedRowHandle);
            //if (gvUser.FocusedRowHandle < 0) return;
            //DataRow dr = gvUser.GetDataRow(gvUser.FocusedRowHandle);
            //frmEditDetailRight myDetailRight = new frmEditDetailRight();
            //myDetailRight.gvGrid = gvUser;
            //myDetailRight.strUser = dr["F_ID"].ToString();
            //myDetailRight.strModule = drModule["F_ID"].ToString();
            //myDetailRight.ShowDialog();
            //myDetailRight.Dispose();
            //BindDetailRight();
            if (lookUpEdit1.Text=="")
            {
                MessageBox.Show("��ѡ��ģ��");
            }
            else
            {
                frmEditModule myDetailRight = new frmEditModule();
                myDetailRight.strId = "";
                myDetailRight.strName = "";
                myDetailRight.strModule = lookUpEdit1.ItemIndex.ToString();
                myDetailRight.ShowDialog();
                myDetailRight.Dispose();
                BindModule(lookUpEdit1.Properties.GetKeyValueByDisplayText(lookUpEdit1.Text).ToString());
            }
        }

        /// <summary>
        /// �༭��ӦȨ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvModule.FocusedRowHandle < 0) return;
            DataRow dr = gvModule.GetDataRow(gvModule.FocusedRowHandle);
            frmEditModule myDetailRight = new frmEditModule();
            myDetailRight.strId = dr["F_ID"].ToString();
            myDetailRight.strName = dr["F_Name"].ToString();
            myDetailRight.strModule = dr["F_PID"].ToString();
            myDetailRight.ShowDialog();
            myDetailRight.Dispose();
            BindModule(lookUpEdit1.Properties.GetKeyValueByDisplayText(lookUpEdit1.Text).ToString());
        }

        /// <summary>
        /// ɾ�������ϸȨ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (gvModule.FocusedRowHandle < 0) return;
            DataRow dr = gvModule.GetDataRow(gvModule.FocusedRowHandle);
            if (MessageBox.Show(this, "���ɾ��ѡ���û�Ȩ����?", "ѯ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            DataLib.DataHelper myHelper = new DataLib.DataHelper();
            if (myHelper.ExecuteSQL("delete from t_Right where F_ID = '" + dr["F_ID"].ToString() + "' and F_Name = '" + dr["F_Name"].ToString() + "'") == 0)
                gvModule.DeleteRow(gvModule.FocusedRowHandle);
        }
    }
}

