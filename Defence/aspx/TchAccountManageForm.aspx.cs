using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Defence
{
    public partial class TchAccountManageForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tid = Session["Id"].ToString();
            m_Account_TchIdLabel.Text = tid;

            this.c_topwin19.m_tchReleaseTitleButton.Click += new ImageClickEventHandler(m_tchReleaseTitleButton_Click);
            this.c_topwin19.m_onlineTeachButton.Click += new ImageClickEventHandler(m_onlineTeachButton_Click);
            this.c_topwin19.m_tchStuDefenceButton.Click += new ImageClickEventHandler(m_tchStuDefenceButton_Click);
            this.c_topwin19.m_tchGradeManageButton.Click += new ImageClickEventHandler(m_tchGradeManageButton_Click);
            this.c_topwin19.m_tchTitleSelectButton.Click += new ImageClickEventHandler(m_tchTitleSelectButton_Click);
        }
        void m_tchReleaseTitleButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchReleaseTitleForm.aspx");
        }
        void m_onlineTeachButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchOnlineTeachForm.aspx");
        }
        void m_tchStuDefenceButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchStuDefenceForm.aspx");
        }
        void m_tchGradeManageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchGradeManageForm.aspx");
        }
        void m_tchTitleSelectButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchTitleSelectForm.aspx");
        }

        protected void TchAccount_ConfirmButton_Click(object sender, EventArgs e)
        {
            SqlHelper m_sqlHelper = new SqlHelper();
            string tid = Session["Id"].ToString();
            string commandText = "select T_id, Pwd from Teacher where T_id='" + tid + "'";
            DataTable dt = m_sqlHelper.Query(commandText);
            string oldpwd = m_Account_OriginalPasswordTextBox.Text;
            string newpwd = m_Account_NewPasswordTextBox.Text;
            string newconfirmpwd = m_Account_ConfirmNewPasswordTextBox.Text;
            //数据库中的密码
            string pwd = dt.Rows[0][1].ToString();
            if (pwd == oldpwd)
            {
                if (newpwd == newconfirmpwd)
                {
                    commandText = "update Teacher set Pwd='" + newpwd + "' where T_id='" + tid + "'";
                    m_sqlHelper.Update(commandText);
                    Session["Password"] = newpwd;
                    Response.Write("<script>alert('修改成功。')</script>");
                }
                else
                {
                    Response.Write("<script>alert('新密码与确认密码不一致。')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('原密码输入错误。')</script>");
            }
        }
    }
}