<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TchReportReviewForm.aspx.cs" Inherits="Defence.TchReportReviewForm" %>
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
            <topwin:c_topwin runat="server" ID="c_topwin14" />
            <asp:Panel ID="m_tchPaperReviewPanel" runat="server" Style="position: absolute; top: 216px; left: 327px; height: 514px; width: 887px; margin-left: 0px;">
                &nbsp;<br />
                &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<div style="height: 28px; margin-left: 20px">
                    &nbsp;
                <asp:Button ID="m_FormalSelectButton" runat="server" OnClick="m_FormalSelectButton_Click" Text="正选" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="m_PrepSelectButton" runat="server" OnClick="m_PrepSelectButton_Click" Text="预选" />
                </div>
                &nbsp;&nbsp;<br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />
                <div style="padding: 15px; margin-left: 0px; height: 369px; margin-top: 0px;">

                    <div style="height: 340px; width: 835px; margin-left: 26px;" id="dvBody">

                        <asp:GridView ID="m_reviewTablePaperGridView" CssClass="t2" runat="server" Font-Size="10pt" Width="800px" BorderStyle="Groove" AutoGenerateColumns="False" Height="16px">

                            <FooterStyle CssClass="GridViewFooterStyle" />
                            <RowStyle CssClass="a1" Height="15px" HorizontalAlign="Center" />
                            <SelectedRowStyle CssClass="GridViewSelectedRowStyle" />
                            <PagerStyle CssClass="GridViewPagerStyle" />
                            <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
                            <HeaderStyle CssClass="th" Height="5px" />

                            <Columns>

                                <asp:BoundField DataField="选题编号" HeaderText="选题编号" />
                                <asp:BoundField DataField="选题题目" HeaderText="选题题目" />
                                <asp:BoundField DataField="学生姓名" HeaderText="学生姓名" />
                                <asp:TemplateField HeaderText="详细">
                                    <ItemTemplate>
                                        <a href="TchReportDetailForm.aspx?P_id=<%#Eval("选题编号")%>&Sname=<%#Eval("学生姓名")%>">查看</a>
                                    </ItemTemplate>
                                </asp:TemplateField>

                            </Columns>

                        </asp:GridView>
                    </div>
                </div>
            </asp:Panel>
        </div>
    </form>
</body>
</html>