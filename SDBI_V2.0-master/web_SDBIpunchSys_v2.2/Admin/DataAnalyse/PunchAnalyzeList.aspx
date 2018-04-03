<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="PunchAnalyzeList.aspx.cs" Inherits="PunchAnalyzeList" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <strong>各系详情</strong>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="tab_container">			
			<div id="tab2" class="tab_content">
			<table class="tablesorter" cellspacing="0"> 
			<thead>                   
			</thead>              
			<tbody> 
                <tr>
                    <td><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="tablesorter" OnRowCommand="GridView1_RowCommand">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="周次" HeaderText="周次" />
                            <asp:BoundField DataField="系别" HeaderText="系别" />
                            <asp:BoundField DataField="旷课" HeaderText="旷课人数" />
                            <asp:BoundField DataField="请假" HeaderText="请假人数" />
                            <asp:BoundField DataField="迟到" HeaderText="迟到人数" />
                            <asp:BoundField DataField="早退" HeaderText="早退人数" />
                            <asp:BoundField DataField="总数" HeaderText="缺勤总人数" />
                            <asp:ButtonField ButtonType="Button" Text="详情" />
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView></td>
                    <td><asp:Button ID="Button1" runat="server" Text="信息系图表分析" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2"><asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder></td>
                </tr>
                <tr>
                    <td><asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="tablesorter" OnRowCommand="GridView2_RowCommand">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="周次" HeaderText="周次" />
                            <asp:BoundField DataField="系别" HeaderText="系别" />
                            <asp:BoundField DataField="旷课" HeaderText="旷课人数" />
                            <asp:BoundField DataField="请假" HeaderText="请假人数" />
                            <asp:BoundField DataField="迟到" HeaderText="迟到人数" />
                            <asp:BoundField DataField="早退" HeaderText="早退人数" />
                            <asp:BoundField DataField="总数" HeaderText="缺勤总人数" />
                            <asp:ButtonField ButtonType="Button" Text="详情" />
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView></td>
                    <td><asp:Button ID="Button2" runat="server" Text="会计系图表分析" OnClick="Button2_Click" /></td>
                </tr>
                <tr>
                    <td colspan="2"><asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder></td>
                </tr>  
                <tr>
                    <td><asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="tablesorter" OnRowCommand="GridView3_RowCommand">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="周次" HeaderText="周次" />
                            <asp:BoundField DataField="系别" HeaderText="系别" />
                            <asp:BoundField DataField="旷课" HeaderText="旷课人数" />
                            <asp:BoundField DataField="请假" HeaderText="请假人数" />
                            <asp:BoundField DataField="迟到" HeaderText="迟到人数" />
                            <asp:BoundField DataField="早退" HeaderText="早退人数" />
                            <asp:BoundField DataField="总数" HeaderText="缺勤总人数" />
                            <asp:ButtonField ButtonType="Button" Text="详情" />
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView></td>
                    <td><asp:Button ID="Button3" runat="server" Text="机械工程系图表分析" OnClick="Button3_Click" /></td>
                </tr>
                <tr>
                    <td colspan="2"><asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder></td>
                </tr>  
                <tr>
                    <td><asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="tablesorter" OnRowCommand="GridView4_RowCommand">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="周次" HeaderText="周次" />
                            <asp:BoundField DataField="系别" HeaderText="系别" />
                            <asp:BoundField DataField="旷课" HeaderText="旷课人数" />
                            <asp:BoundField DataField="请假" HeaderText="请假人数" />
                            <asp:BoundField DataField="迟到" HeaderText="迟到人数" />
                            <asp:BoundField DataField="早退" HeaderText="早退人数" />
                            <asp:BoundField DataField="总数" HeaderText="缺勤总人数" />
                            <asp:ButtonField ButtonType="Button" Text="详情" />
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView></td>
                    <td><asp:Button ID="Button4" runat="server" Text="经济管理系图表分析" OnClick="Button4_Click" /></td>
                </tr>
                <tr>
                    <td colspan="2"><asp:PlaceHolder ID="PlaceHolder4" runat="server"></asp:PlaceHolder></td>
                </tr>  
                <tr>
                    <td><asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="tablesorter" OnRowCommand="GridView5_RowCommand">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="周次" HeaderText="周次" />
                            <asp:BoundField DataField="系别" HeaderText="系别" />
                            <asp:BoundField DataField="旷课" HeaderText="旷课人数" />
                            <asp:BoundField DataField="请假" HeaderText="请假人数" />
                            <asp:BoundField DataField="迟到" HeaderText="迟到人数" />
                            <asp:BoundField DataField="早退" HeaderText="早退人数" />
                            <asp:BoundField DataField="总数" HeaderText="缺勤总人数" />
                            <asp:ButtonField ButtonType="Button" Text="详情" />
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView></td>
                    <td><asp:Button ID="Button5" runat="server" Text="商务外语系图表分析" OnClick="Button5_Click" /></td>
                </tr>
                <tr>
                    <td colspan="2"><asp:PlaceHolder ID="PlaceHolder5" runat="server"></asp:PlaceHolder></td>
                </tr>  
                <tr>
                    <td><asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="tablesorter" OnRowCommand="GridView6_RowCommand">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="周次" HeaderText="周次" />
                            <asp:BoundField DataField="系别" HeaderText="系别" />
                            <asp:BoundField DataField="旷课" HeaderText="旷课人数" />
                            <asp:BoundField DataField="请假" HeaderText="请假人数" />
                            <asp:BoundField DataField="迟到" HeaderText="迟到人数" />
                            <asp:BoundField DataField="早退" HeaderText="早退人数" />
                            <asp:BoundField DataField="总数" HeaderText="缺勤总人数" />
                            <asp:ButtonField ButtonType="Button" Text="详情" />
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView></td>
                    <td><asp:Button ID="Button6" runat="server" Text="食品工程系图表分析" OnClick="Button6_Click" /></td>
                </tr>
                <tr>
                    <td colspan="2"><asp:PlaceHolder ID="PlaceHolder6" runat="server"></asp:PlaceHolder></td>
                </tr>                
			</tbody> 
			</table>
			</div>			
		</div>
</asp:Content>

