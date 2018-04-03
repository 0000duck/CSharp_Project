<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="ContentPage.aspx.cs" Inherits="Admin_ContentPage" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <strong>数据导入</strong>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:TextBox runat="server" ID="ContentName" BorderColor="#F1F1F4" BorderStyle="None" ForeColor="#666666" ReadOnly="True"></asp:TextBox>
    
<table class="tablesorter" cellspacing="0"> 
			<thead> 
				<tr> 
   					<th class="header" style="width: 120px">教师导入</th> 
				</tr> 
			</thead> 
            <tbody>
                <tr>
                    <td style="width: 120px">
                        <asp:RadioButton ID="RadioButton1" runat="server" Text="本校教师" GroupName="teacher" OnCheckedChanged="RadioButton1_CheckedChanged" Checked="True" /><br />
                        <asp:RadioButton ID="RadioButton2" runat="server" Text="外聘教师" GroupName="teacher" /></td>
                    <td style="width: 386px">
                        <asp:FileUpload ID="FileUpload1" runat="server" Width="220px" />
                        &nbsp; &nbsp; &nbsp;
                        <asp:Button runat="server" Text="上传" OnClick="Unnamed1_Click" ID="TeacherUpload" /><br />
                        <asp:Label ID="Label1" runat="server" ForeColor="#009900"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                
            </tbody>
       </table>
    <hr />
    <table class="tablesorter" cellspacing="0"> 
			<thead> 
				<tr> 
   					<th class="header" style="width: 120px">系表导入</th> 
				</tr> 
			</thead> 
            <tbody>
                <tr>
                    <td style="width: 120px">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Value="信息工程系"></asp:ListItem>
                            <asp:ListItem>会计系</asp:ListItem>
                            <asp:ListItem>机械工程系</asp:ListItem>
                            <asp:ListItem>建筑工程系</asp:ListItem>
                            <asp:ListItem>教务处</asp:ListItem>
                            <asp:ListItem>经济管理系</asp:ListItem>
                            <asp:ListItem>商务外语系</asp:ListItem>
                            <asp:ListItem>食品工程系</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:FileUpload ID="FileUpload2" runat="server" Width="220px" />
                        &nbsp; &nbsp; &nbsp;
                        <asp:Button runat="server" Text="上传" OnClick="Unnamed2_Click" ID="DepartmentUpload"/>
                        <br />
                        <asp:Label ID="Label2" runat="server" ForeColor="#009900"></asp:Label>
                    </td>
                    
                    <td>&nbsp;</td>
                </tr>
                
            </tbody>
       </table>
    <hr />
        <table class="tablesorter" cellspacing="0"> 
			<thead> 
				<tr> 
   					<th class="header" style="width: 120px">校历生成</th> 	
				</tr> 
			</thead> 
            <tbody>
                <tr>
                    <td style="width: 120px"></td>
                    <td>
                        <!--<asp:FileUpload ID="FileUpload3" runat="server" Width="220px" />-->
                        <input type="date" id="DateName" runat="server" />
                        &nbsp; &nbsp; &nbsp;
                        <asp:Button runat="server" Text="生成" OnClick="Unnamed3_Click" ID="KalendarUpload"/>
                        <br />
                        <asp:Label ID="Label3" runat="server" ForeColor="#009900"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                
            </tbody>
       </table>
        <table class="tablesorter" cellspacing="0"> 
			<thead> 
				<tr> 
   					<th class="header" style="width: 120px">数据分析</th> 	
				</tr> 
			</thead> 
            <tbody>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="分析入库" Width="120px" OnClick="Button1_Click" />
                        <asp:Label ID="Label4" runat="server" ForeColor="#009900"></asp:Label>
                        <br />
                        <asp:Button ID="Button2" runat="server" Text="清空库数据" Width="120px" OnClick="Button2_Click" />
                        <asp:Label ID="Label5" runat="server" ForeColor="#009900"></asp:Label>
                    </td>
                </tr>
                
            </tbody>
       </table>
</asp:Content>

