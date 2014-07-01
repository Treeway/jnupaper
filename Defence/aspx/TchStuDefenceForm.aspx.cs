using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Defence
{
    public partial class TchStuDefenceForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlHelper m_sqlHelper = new SqlHelper();
                string tid = Session["Id"].ToString();
                string commandText = "select P_id, Title from Paper where T_id='" + tid + "'";
                DataSet ds = m_sqlHelper.dsQuery(commandText);
                m_PaperTitleDropDownList.DataSource = ds.Tables["Table1"].DefaultView;
                m_PaperTitleDropDownList.DataTextField = "Title";
                m_PaperTitleDropDownList.DataValueField = "P_id";
                m_PaperTitleDropDownList.DataBind();
            }
            this.c_topwin17.m_tchTitleSelectButton.Click += new ImageClickEventHandler(m_tchTitleSelectButton_Click);
            this.c_topwin17.m_onlineTeachButton.Click += new ImageClickEventHandler(m_onlineTeachButton_Click);
            this.c_topwin17.m_tchGradeManageButton.Click += new ImageClickEventHandler(m_tchGradeManageButton_Click);
            this.c_topwin17.m_tchAccountManageButton.Click += new ImageClickEventHandler(m_tchAccountManageButton_Click);
        }


        protected void m_ReplyNotifyButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchStuDefenceForm.aspx");
        }

        protected void m_ScoreEnterButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchEnterScoreForm.aspx");
        }

        protected void m_ReplyNotifyConfirmButton_Click(object sender, EventArgs e)
        {
            SqlHelper m_sqlHelper = new SqlHelper();
            string tid = Session["Id"].ToString();
            string paperTitle = m_PaperTitleDropDownList.SelectedItem.Text;
            string commandText = "select S_id from Stu_Paper, Paper where Paper.Title='" + paperTitle + "' and Paper.P_id=Stu_Paper.P_id";
            DataTable dt = m_sqlHelper.Query(commandText);
            string sid = dt.Rows[0][0].ToString();
            string time = m_ReplyTimeTextBox.Text;
            string location = m_ReplyPlaceTextBox.Text;
            commandText = "insert into Defence (Title, S_id, T_id, Time, Location) values('" + paperTitle + "','" + sid + "','" + tid + "','" + time + "','" + location + "')";
            m_sqlHelper.Update(commandText);
            Response.Redirect("TchStuDefenceForm.aspx");
        }
        
        void m_tchTitleSelectButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchTitleSelectForm.aspx");
        }
        void m_onlineTeachButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchOnlineTeachForm.aspx");
        }
        void m_tchGradeManageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchGradeManageForm.aspx");
        }
        void m_tchAccountManageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchAccountManageForm.aspx");
        }
    }
}