<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="unPunchList.aspx.cs" Inherits="Admin_unPunchList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <strong>漏报统计</strong>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
        <div class="tab_container">			
			<div id="tab2" class="tab_content">
			<table class="tablesorter" cellspacing="0"> 
			<thead>                   
			</thead>  
                <tbody>
                    <tr>
                       <td>统计周次:<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td>
                        <td><asp:Button ID="bt1" runat="server" Text="查询" OnClick="bt1_Click" /></td>
                    </tr>
                   <tr>
                       <td colspan="2">
                           <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="tablesorter">
                               <AlternatingRowStyle BackColor="White" />
                               <Columns>
                                   <asp:BoundField DataField="TeaDepartment" HeaderText="系部" />
                                   <asp:BoundField DataField="TeaName" HeaderText="教师姓名" />
                                   <asp:BoundField DataField="TeaID" HeaderText="教师工号" />
                                   <asp:BoundField HeaderText="漏报次数" />
                                   <asp:ButtonField ButtonType="Button" HeaderText="详情" Text="详情" />
                               </Columns>
                               <EditRowStyle BackColor="#2461BF" />
                               <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                               <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                               <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                               <RowStyle BackColor="#EFF3FB" />
                               <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                               <SortedAscendingCellStyle BackColor="#F5F7FB" />
                               <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                               <SortedDescendingCellStyle BackColor="#E9EBEF" />
                               <SortedDescendingHeaderStyle BackColor="#4870BE" />
                           </asp:GridView>
                       </td>
                   </tr>
                </tbody>      
			</table>
			</div>			
		</div>
</asp:Content>

