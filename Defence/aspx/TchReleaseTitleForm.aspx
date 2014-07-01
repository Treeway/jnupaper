<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TchReleaseTitleForm.aspx.cs" Inherits="Defence.TchReleaseTitleForm" %>
<%@ Register TagPrefix="topwin" TagName="c_topwin" Src="/c_topwin_tch.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="position: absolute; top: -4px; left: -33px; height: 717px;">
        <topwin:c_topwin runat="server" id="c_topwin12"/>
        <asp:Panel ID="m_tchReleaseTitlePanel" runat="server" style="position: absolute; top: 241px; left: 302px; height: 396px; width: 885px;">
            <br />
            &nbsp;&nbsp;选题编号：<asp:TextBox ID="m_TitleIdTextBox" runat="server" Width="292px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;题目：<asp:TextBox ID="m_TitleNameTextBox" runat="server" Width="324px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;简介：
            <br />
            <br />
            &nbsp;&nbsp;<asp:TextBox ID="m_TitleProfileTextBox" runat="server" TextMode="MultiLine" Height="124px" Width="372px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;<asp:Button ID="m_TitleReleaseButton" runat="server" Text="发布" Height="31px" Width="68px" OnClick="ReleaseButton_Click"> </asp:Button>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
