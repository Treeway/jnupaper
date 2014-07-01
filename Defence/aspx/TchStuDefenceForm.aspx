<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TchStuDefenceForm.aspx.cs" Inherits="Defence.TchStuDefenceForm" %>
<%@ Register TagPrefix="topwin" TagName="c_topwin" Src="/c_topwin_tch.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .GridViewStyleSheet {
            margin-left: 17px;
        }
    </style>
    <style type="text/css">
        .GridViewStyleSheet {
            margin-left: 17px;
        }
    </style>
</head>

<link href="../css/GridViewStyleSheet.css" rel="stylesheet" type="text/css" />
<link href="../css/GridViewStyleSheet2.css" rel="stylesheet" type="text/css" />

<link rel="stylesheet" href="../css/TableStyleSheet1.css">

<body>
        <form id="form1" runat="server">
        <div style="position: absolute; top: -4px; left: -33px; height: 717px;">
            <topwin:c_topwin runat="server" ID="c_topwin17" />
            <asp:Panel ID="m_tchPaperReviewPanel" runat="server" Style="position: absolute; top: 216px; left: 327px; height: 514px; width: 887px; margin-left: 0px;">
                &nbsp;<br />
                &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<div style="height: 28px; margin-left: 20px">
                    &nbsp;
                <asp:Button ID="m_ReplyNotifyButton" runat="server" OnClick="m_ReplyNotifyButton_Click" Text="发布答辩通知" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="m_ScoreEnterButton" runat="server" OnClick="m_ScoreEnterButton_Click" Text="录入答辩成绩" />
                </div>
                <br />
                <asp:Panel ID="m_ReplyNotifyPanel" runat="server" Style="position: absolute; top: 70px; left: 10px; height: 255px; width: 750px; margin-left: 0px; margin-bottom: 17px;" Font-Size="11pt">
                <table style="width: 100%; margin-top: 0px; height: 254px;" class="login-help">
                    <tr class="tr">
                        <td class="td"> 论文题目:</td>
                        <td class="td">
                            <asp:DropDownList ID="m_PaperTitleDropDownList" runat="server" Autopostback="true"/>
                        </td>
                    </tr>
                    <tr class="tr">
                        <td class="td">答辩时间：</td>
                        <td class="td">
                            <asp:TextBox ID="m_ReplyTimeTextBox" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr class="tr">
                        <td class="td">答辩地点：</td>
                        <td class="td">
                            <asp:TextBox ID="m_ReplyPlaceTextBox" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr class="tr">
                        <td class="td"></td>
                        <td class="td">
                            <asp:Button ID="m_ReplyNotifyConfirmButton" runat="server" Height="25px" Text="发布" Width="65px" OnClick="m_ReplyNotifyConfirmButton_Click" />
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                &nbsp;&nbsp;</asp:Panel>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
