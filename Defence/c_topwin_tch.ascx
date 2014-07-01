<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="c_topwin_tch.ascx.cs" Inherits="Defence.c_topwin_tch" %>

<link href="../css/BackgroundStyleSheet.css" rel="stylesheet" type="text/css">

<div style="position: absolute; top: 14px; left: 158px; height: 717px;">
        <asp:Image ID="m_topImage" runat="server" ImageUrl="~\images\top.png" BorderStyle="None" Height="175px" Width="1050px"/><br />
        <asp:Label ID="m_welcomeLabel" runat="server" Text="欢迎您    "></asp:Label>
        <asp:LinkButton ID="m_exitLinkButton" runat="server" OnClick="m_exitLinkButton_Click">退出</asp:LinkButton>
        <hr/>
        <br/>
        <asp:Panel ID="Panel1" runat="server" BackImageUrl="~/image/gate1.png" Height="503px">
        <asp:Panel ID="m_buttonPanel" runat="server" Height="500px" Width="150px" Font-Size="13pt" CssClass="menu" BackImageUrl="~/image/menu.jpg"> <br/>
            <div style="height: 202px; margin-left: 7px">
            <asp:ImageButton ID="m_tchReleaseTitleButton" runat="server" ImageUrl="~\images\ReleaseTitle.png" Height="33px" Width="138px" OnClick = "m_tchReleaseTitleButton_Click"/><br/>
            <asp:ImageButton ID="m_tchTitleSelectButton" runat="server" ImageUrl="~\images\StuTitleSelect.png" Height="33px" Width="138px" OnClick = "m_tchTitleSelectButton_Click"/><br/>
            <asp:ImageButton ID="m_onlineTeachButton" runat="server" ImageUrl="~\images\OnlineTeach.png" Height="33px" Width="138px" OnClick = "m_onlineTeachButton_Click"/><br/>
            <asp:ImageButton ID="m_tchStuDefenceButton" runat="server" ImageUrl="~\images\StuDefence.png" Height="33px" Width="138px" OnClick = "m_tchStuDefenceButton_Click"/><br/>
            <asp:ImageButton ID="m_tchGradeManageButton" runat="server" ImageUrl="~\images\GradeManage.png" Height="33px" Width="138px" OnClick = "m_tchGradeManageButton_Click"/>
            <asp:ImageButton ID="m_tchAccountManageButton" runat="server" ImageUrl="~\images\AccountManage.png" Height="33px" Width="138px" OnClick = "m_tchAccountManageButton_Click"/>
            </div>
        </asp:Panel>
        </asp:Panel>
    </div>