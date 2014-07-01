using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Defence
{
    public partial class TchPaperReviewForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlHelper m_sqlHelper = new SqlHelper();
            string tid = Session["Id"].ToString();
            string commandText = " select distinct Paper.P_id as 选题编号,Paper.Title as 选题题目,Stu.S_id as 学生学号,Stu.Name as 学生姓名" +
                                 " from Stu,Paper,Stu_Paper " +
                                 " where Paper.T_id = '" + tid + "' and Paper.P_id = Stu_Paper.P_id and Stu_Paper.S_id = Stu.S_id";
            DataTable dt = m_sqlHelper.Query(commandText);
            m_reviewTablePaperGridView.DataSource = dt;
            m_reviewTablePaperGridView.DataBind();

            this.c_topwin15.m_tchTitleSelectButton.Click += new ImageClickEventHandler(m_tchTitleSelectButton_Click);
            this.c_topwin15.m_tchReleaseTitleButton.Click += new ImageClickEventHandler(m_tchReleaseTitleButton_Click);
            this.c_topwin15.m_onlineTeachButton.Click += new ImageClickEventHandler(m_onlineTeachButton_Click);
            this.c_topwin15.m_tchStuDefenceButton.Click += new ImageClickEventHandler(m_tchStuDefenceButton_Click);
            this.c_topwin15.m_tchGradeManageButton.Click += new ImageClickEventHandler(m_tchGradeManageButton_Click);
            this.c_topwin15.m_tchAccountManageButton.Click += new ImageClickEventHandler(m_tchAccountManageButton_Click);
        }

        protected void m_FormalSelectButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchPaperReviewForm.aspx");
        }

        protected void m_PrepSelectButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchReportReviewForm.aspx");
        }

        void m_tchTitleSelectButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchTitleSelectForm.aspx");
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
        void m_tchAccountManageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchAccountManageForm.aspx");
        }
    }
}