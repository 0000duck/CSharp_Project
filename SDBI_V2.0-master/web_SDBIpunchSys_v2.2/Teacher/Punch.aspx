<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/MasterPage.master" AutoEventWireup="true" CodeFile="Punch.aspx.cs" Inherits="Teacher_Punch" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"><strong>考勤</strong></asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="tablesorter">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="StuDepartment" HeaderText="系别" />
            <asp:BoundField DataField="Class" HeaderText="班级" />
            <asp:BoundField DataField="StuID" HeaderText="学号" />
            <asp:BoundField DataField="StuName" HeaderText="姓名" />
            <asp:TemplateField HeaderText="考勤状态">
                <ItemTemplate>
                    <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="请假" GroupName="rb"  onclick="changeColor(this)"/>
                    <asp:RadioButton ID="RadioButton2" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" Text="迟到" GroupName="rb"  onclick="changeColor(this)"/>
                    <asp:RadioButton ID="RadioButton3" runat="server" OnCheckedChanged="RadioButton3_CheckedChanged" Text="早退" GroupName="rb"  onclick="changeColor(this)"/>
                    <asp:RadioButton ID="RadioButton4" runat="server" OnCheckedChanged="RadioButton4_CheckedChanged" Text="旷课" GroupName="rb"  onclick="changeColor(this)"/>
                    <asp:RadioButton ID="RadioButton5" runat="server" Checked="True" Text="正常" GroupName="rb" onclick="changeColor(this)"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <br />
    &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" Text="提交考勤" OnClick="Button1_Click" />
    
</asp:Content>

