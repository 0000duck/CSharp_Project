<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="cleanData.aspx.cs" Inherits="Admin_cleanData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <strong>清空数据</strong>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="tab_container">			
			<div id="tab2" class="tab_content">
			<table class="tablesorter" cellspacing="0"> 
			<thead>                   
			</thead>    
            <tbody>
                <tr>
                    <td>清空教师信息</td>
                </tr>
                <tr>
                    <td>
                        本校教师数据量:<asp:TextBox ID="teachers" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="clearTeachers" runat="server" Text="清空本校教师数据" OnClick="clearTeachers_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        外聘教师数据量:<asp:TextBox ID="otherTeachers" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="clearOtherTeachers" runat="server" Text="清空外聘教师数据" OnClick="clearOtherTeachers_Click" />
                    </td>
                </tr>
                <tr>
                    <td>清空系部信息</td>
                </tr>
                 <tr>
                    <td>
                        "教务处"数据量:<asp:TextBox ID="tx1" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="bt1" runat="server" Text="清空教务处信息" OnClick="bt1_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        "会计系"数据量:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="清空会计系信息" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        "信息工程系"数据量:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="清空信息工程系信息" OnClick="Button2_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        "商务外语系"数据量:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button3" runat="server" Text="清空商务外语系信息" OnClick="Button3_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        "机械工程系"数据量:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button4" runat="server" Text="清空机械工程系信息" OnClick="Button4_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        "食品工程系"数据量:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button5" runat="server" Text="清空食品工程系信息" OnClick="Button5_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        "经济管理系"数据量:<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button6" runat="server" Text="清空经济管理系信息" OnClick="Button6_Click" />
                    </td>
                    </tr>
                <tr>
                    <td>
                        "建筑工程系"数据量:<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button7" runat="server" Text="清空商务外语系信息" OnClick="Button7_Click" />
                    </td>
                    </tr>
                <tr>
                    <td>
                        "基础教学部"数据量:<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button8" runat="server" Text="清空基础教学部信息" OnClick="Button8_Click" />
                    </td>
                </tr>
            </tbody>    
			</table>
			</div>			
		</div>
        
</asp:Content>

