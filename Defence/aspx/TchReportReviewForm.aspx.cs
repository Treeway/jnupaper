using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Defence
{
    public partial class TchReportReviewForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            m_reviewTablePaperGridView.Attributes.Add("style", "word-break:break-all;word-wrap:break-word");

            SqlHelper m_sqlHelper = new SqlHelper();

            string id = Session["Id"].ToString();
            string pwd = Session["Password"].ToString();

            string commandText = " select distinct Paper.P_id as 选题编号,Paper.Title as 选题题目,Stu.Name as 学生姓名" +
                                 " from Stu,Paper,Stu_Topic " +
                                 " where Paper.T_id = '" + id + "' and Paper.P_id = Stu_Topic.P_id and Stu_Topic.S_id = Stu.S_id and Stu_Topic.Result='审核中'";

            DataTable dt = m_sqlHelper.Query(commandText);
            m_reviewTablePaperGridView.DataSource = dt;
            m_reviewTablePaperGridView.DataBind();

            this.c_topwin14.m_tchTitleSelectButton.Click += new ImageClickEventHandler(m_tchTitleSelectButton_Click);
            this.c_topwin14.m_tchReleaseTitleButton.Click += new ImageClickEventHandler(m_tchReleaseTitleButton_Click);
            this.c_topwin14.m_onlineTeachButton.Click += new ImageClickEventHandler(m_onlineTeachButton_Click);
            this.c_topwin14.m_tchStuDefenceButton.Click += new ImageClickEventHandler(m_tchStuDefenceButton_Click);
            this.c_topwin14.m_tchGradeManageButton.Click += new ImageClickEventHandler(m_tchGradeManageButton_Click);
            this.c_topwin14.m_tchAccountManageButton.Click += new ImageClickEventHandler(m_tchAccountManageButton_Click);
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