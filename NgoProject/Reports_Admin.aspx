<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Reports_Admin.aspx.cs" Inherits="NgoProject.Reports_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">

    <div class="login-wrapper">
        <div class="login-frm">
            <form runat="server" style="width: 100%;">
                <a runat="server" style="color: blue; text-decoration: underline;" href="~/Member_Report.aspx">Members</a>
                <br /><a runat="server" style="color: blue; text-decoration: underline;" href="~/Donar_Report.aspx">Donars</a>
                <br /><a runat="server" style="color: blue; text-decoration: underline;" href="~/Fundraise_Report.aspx">Fund raiser</a>
                <br /><a runat="server" style="color: blue; text-decoration: underline;" href="~/Events_Report.aspx">Events</a>
                <br /><a runat="server" style="color: blue; text-decoration: underline;" href="~/User_Report.aspx">Users</a>
            </form>
        </div>
    </div>
</asp:Content>
