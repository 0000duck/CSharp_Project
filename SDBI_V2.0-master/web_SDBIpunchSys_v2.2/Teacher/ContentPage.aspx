<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/MasterPage.master" AutoEventWireup="true" CodeFile="ContentPage.aspx.cs" Inherits="Teacher_ContentPage" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"><strong>本周授课信息</strong></asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

		<div class="tab_container">
			<div id="tab2" class="tab_content">
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong><asp:Label ID="Message" runat="server" ForeColor="#00CC00"></asp:Label></strong>
                <asp:Repeater ID="repeater1" runat="server" OnItemCommand="repeater1_ItemCommand">
                    <HeaderTemplate>
                        <table class="tablesorter">
                            <tr>
                                <td><label>本周授课信息</label></td>
                                <td><asp:Label ID="headLbl" runat="server" Text=""></asp:Label></td>
                            </tr>
                        
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td>
                                <asp:Label ID="ClassID" runat="server" Text=<%#DataBinder.Eval(Container.DataItem,"ClassID") %> Visible="false"></asp:Label>
                                <asp:Label ID="TimePunch" runat="server" Text=<%#DataBinder.Eval(Container.DataItem,"TimePunch") %> Visible="false"></asp:Label>
                            </td>
                            
                             <td>
                                 <asp:Label ID="lblWeek" runat="server" Text=<%#DataBinder.Eval(Container.DataItem,"Week")+"(星期)" %> ></asp:Label>&nbsp;&nbsp;&nbsp;
                                 <asp:Label ID="lblTime" runat="server" Text=<%#DataBinder.Eval(Container.DataItem,"CourseTime")+"(时间)" %> ></asp:Label>&nbsp;&nbsp;&nbsp;
                                 <asp:Label ID="lblCourseWhere" runat="server" Text=<%#DataBinder.Eval(Container.DataItem,"CourseWhere")+"(地点)" %> ></asp:Label>&nbsp;&nbsp;&nbsp;
                                 <asp:Label ID="lblCourseName" runat="server" Text=<%#DataBinder.Eval(Container.DataItem,"CourseName")+"(课程)" %> ></asp:Label>&nbsp;&nbsp;&nbsp;      
                                 <asp:Label ID="lblClass" runat="server" Text=<%#DataBinder.Eval(Container.DataItem,"Class")+"(地点)" %> ></asp:Label>                              
                            </td>
                             <td>
                                 <asp:CheckBox ID="ck1" runat="server" Text="布置作业" />
                            </td>
                             <td>
                                 <asp:Button ID="bt1" runat="server" CommandName="button" Text="考勤" />
                            </td>          
                        </tr>                    
                    </ItemTemplate>
                    <FooterTemplate>
                         </table>
                    </FooterTemplate>
                </asp:Repeater>
			</div>		
		</div>
		
</asp:Content>

