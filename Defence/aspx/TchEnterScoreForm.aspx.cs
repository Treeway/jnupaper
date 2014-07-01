using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Defence.aspx
{
    public partial class TchEnterScoreForm : System.Web.UI.Page
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
            loadProfile();
        }
        protected void m_PaperTitleChange_IndexChanged(object sender, EventArgs e)
        {
            //loadProfile();
        }

        protected void m_ScoreEnterButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchEnterScoreForm.aspx");
        }

        protected void m_ReplyNotifyButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchStuDefenceForm.aspx");
        }

        protected void m_ReplyNotifyConfirmButton_Click(object sender, EventArgs e)
        {
            string pid = m_PaperTitleDropDownList.SelectedItem.Value;
            string sid = m_StudentIdLabel.Text;
            string pscore, rpscore, tscore;
            SqlHelper m_sqlHelper = new SqlHelper();
            string commandText = "select distinct P_score from Stu_Paper where P_id='" + pid + "' and S_id='" + sid + "'";
            DataTable dt = m_sqlHelper.Query(commandText);
            pscore = dt.Rows[0][0].ToString();
            rpscore = m_PaperScoreTextBox.Text;
            int p = System.Int32.Parse(pscore);
            int rp = System.Int32.Parse(rpscore);
            int totle = (p + rp) / 2;
            tscore = totle.ToString();

            commandText = "update Stu_Paper set RP_score='" + rpscore + "', Total_score='" + tscore + "'" +
                " where  P_id='" + pid + "' and S_id='" + sid + "'";
            m_sqlHelper.Update(commandText);
            Response.Redirect("TchEnterScoreForm.aspx");
        }

        private void loadProfile()
        {
            SqlHelper m_sqlHelper = new SqlHelper();
            string tid = Session["Id"].ToString();
            string pid = m_PaperTitleDropDownList.SelectedItem.Value;
            string commandText = "select distinct Stu.S_id, Stu.Name from Paper, Stu, Stu_Paper "
                + "where Stu_Paper.P_id='" + pid + "' and Stu_Paper.S_id=Stu.S_id";
            DataTable dt = m_sqlHelper.Query(commandText);
            if (dt.Rows.Count != 0)
            {
                System.Diagnostics.Debug.Write("111aaa");
                m_PaperIdLabel.Text = pid;
                m_StudentNameLabel.Text = dt.Rows[0][1].ToString();
                m_StudentIdLabel.Text = dt.Rows[0][0].ToString();
            }
            
        }
    }
}