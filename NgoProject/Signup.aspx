<%@ Page Title="SignUp" Language="C#" MasterPageFile="~/Ngo.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="NgoProject.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <div class="login-wrapper">
        <div class="login-frm">
            <form runat="server" style="width: 100%;">
                <h1>Login</h1>
                <div class="c uname">
                    <Ngo:Text runat="server" LblText="User Name" />
                </div>
                <div class="c pwd">
                    <Ngo:Text runat="server" LblText="Password" Type="Password" />
                </div>
                <div class="c login-action">
                    <button class="ngo-btn">Login</button>
                    <a runat="server" href="~/Login.aspx" class="sign-up">Sign up</a>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
