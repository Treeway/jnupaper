<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TchGradeManageForm.aspx.cs" Inherits="Defence.TchGradeManageForm" %>
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
            <topwin:c_topwin runat="server" ID="c_topwin18" />
            <asp:Panel ID="m_tchGradeManagementPanel" runat="server" Style="position: absolute; top: 216px; left: 327px; height: 514px; width: 887px; margin-left: 0px;">
                
                &nbsp;&nbsp;<br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />
                <div style="padding: 15px; margin-left: 0px; height: 369px; margin-top: 0px;">

                    <div style="height: 340px; width: 835px; margin-left: 26px;" id="dvBody">

                        <asp:GridView ID="m_GradeManagementGridView" CssClass="t2" runat="server" Font-Size="10pt" Width="800px" BorderStyle="Groove" AutoGenerateColumns="False" Height="16px">

                            <FooterStyle CssClass="GridViewFooterStyle" />
                            <RowStyle CssClass="a1" Height="15px" HorizontalAlign="Center" />
                            <SelectedRowStyle CssClass="GridViewSelectedRowStyle" />
                            <PagerStyle CssClass="GridViewPagerStyle" />
                            <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
                            <HeaderStyle CssClass="th" Height="5px" />

                            <Columns>

                                <asp:BoundField DataField="选题编号" HeaderText="选题编号" />
                                <asp:BoundField DataField="选题题目" HeaderText="选题题目" />
                                <asp:BoundField DataField="学生学号" HeaderText="学生学号" />
                                <asp:BoundField DataField="学生姓名" HeaderText="学生姓名" />
                                <asp:BoundField DataField="专业" HeaderText="专业" />
                                <asp:BoundField DataField="年级" HeaderText="年级" />
                                <asp:BoundField DataField="论文成绩" HeaderText="论文成绩" />
                                <asp:BoundField DataField="答辩成绩" HeaderText="答辩成绩" />
                                <asp:BoundField DataField="总成绩" HeaderText="总成绩" />
                            </Columns>

                        </asp:GridView>
                    </div>
                </div>
            </asp:Panel>
        </div>
    </form>
</body>
</html>