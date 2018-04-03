<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="PunchAnalyze.aspx.cs" Inherits="Admin_PunchAnalyze" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <strong>考勤分析</strong>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
        <div class="tab_container">			
			<div id="tab2" class="tab_content">
			<table class="tablesorter" cellspacing="0"> 
			<thead>                   
			</thead> 
              
			<tbody>
                <tr class="">
                    <td  style="height: 34px">
                        <asp:RadioButton ID="RadioButton5" runat="server" GroupName="rbList" Text="按周次检索" />
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="57px"></asp:DropDownList></td>
                    <td style="height: 34px">
                        <asp:RadioButton ID="RadioButton1" runat="server" Text="本周情况" GroupName="rbList" /><asp:RadioButton ID="RadioButton2" runat="server" Text="上周情况" GroupName="rbList" />
                        <asp:RadioButton ID="RadioButton3" runat="server" Text="近一月情况" GroupName="rbList" /><asp:RadioButton ID="RadioButton4" runat="server" Text="开学至今" GroupName="rbList" Checked="True" />
                    </td>
                    <td  style="height: 34px"><asp:Button ID="Button1" runat="server" Text="生成图表" OnClick="Button1_Click" />&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="查看各系详情" OnClick="Button2_Click" /></td>
                    
                </tr>  
                <tr>
                    <td colspan="3">

                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="tablesorter">
                        <AlternatingRowStyle BackColor="White" />
                        
                        <Columns>
                            <asp:BoundField HeaderText="系部" DataField="系部" />
                            <asp:BoundField HeaderText="在校生人数" DataField="在校生人数" />
                            <asp:BoundField HeaderText="旷课人次" DataField="旷课人次" />
                            <asp:BoundField HeaderText="旷课率" DataField="旷课率" />
                            <asp:BoundField HeaderText="迟到人次" DataField="迟到人次" />
                            <asp:BoundField HeaderText="迟到率" DataField="迟到率" />
                            <asp:BoundField HeaderText="早退人次" DataField="早退人次" />
                            <asp:BoundField HeaderText="早退率" DataField="早退率" />
                            <asp:BoundField HeaderText="请假人次" DataField="请假人次" />
                            <asp:BoundField HeaderText="请假率" DataField="请假率" />
                            <asp:BoundField HeaderText="总缺勤人次" DataField="总缺勤人次" />
                            <asp:BoundField HeaderText="总缺勤率" DataField="总缺勤率" />
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
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Chart ID="Chart1" runat="server" BackColor="Gainsboro" Height="600px" Width="600px">
                            <Titles>
                                <asp:Title Font="微软雅黑, 16pt" Name="Title1" Text="各系缺勤人数柱状图">
                                </asp:Title>
                             </Titles>
                            <Series>
                                <asp:Series Name="Series1">
                                </asp:Series>
                            </Series>
                            <ChartAreas>
                                <asp:ChartArea Name="ChartArea1">
                                </asp:ChartArea>
                            </ChartAreas>
                        </asp:Chart>
                    </td>
                </tr>
                
			</tbody> 
			</table>
			</div>			
		</div>
</asp:Content>

