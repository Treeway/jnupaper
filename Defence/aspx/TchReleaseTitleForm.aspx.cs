﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Defence
{
    public partial class TchReleaseTitleForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.c_topwin12.m_tchTitleSelectButton.Click += new ImageClickEventHandler(m_tchTitleSelectButton_Click);
            this.c_topwin12.m_onlineTeachButton.Click += new ImageClickEventHandler(m_onlineTeachButton_Click);
            this.c_topwin12.m_tchStuDefenceButton.Click += new ImageClickEventHandler(m_tchStuDefenceButton_Click);
            this.c_topwin12.m_tchGradeManageButton.Click += new ImageClickEventHandler(m_tchGradeManageButton_Click);
            this.c_topwin12.m_tchAccountManageButton.Click += new ImageClickEventHandler(m_tchAccountManageButton_Click);
        }

        void m_tchTitleSelectButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchTitleSelectForm.aspx");
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

        protected void ReleaseButton_Click(object sender, EventArgs e)
        {
            SqlHelper m_sqlHelper = new SqlHelper();
            string tid = Session["Id"].ToString();
            string id = m_TitleIdTextBox.Text.ToString();
            string title = m_TitleNameTextBox.Text.ToString();
            string profile = m_TitleProfileTextBox.Text.ToString();
            string commandText = "insert into Paper values('" + id + "', '" + tid + "', '" + title + "', '" + profile + "')";
            m_sqlHelper.Update(commandText);
            Response.Write("<script>alert('添加成功！')</script>");
            m_TitleIdTextBox.Text = "";
            m_TitleNameTextBox.Text = "";
            m_TitleProfileTextBox.Text = "";
        }
    }
}