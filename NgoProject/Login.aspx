<%@ Page Title="Login" Language="C#" MasterPageFile="~/Ngo.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NgoProject.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <style>
        .login-wrapper {
            height: 100%;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        div.login-frm {
            width: 450px;
            padding: 1em;
            display: flex;
            box-shadow: 0 0 8px 0 rgba(0,0,0,0.2);
        }

        h1 {
            margin-bottom: 0.5em;
            text-align: center;
        }

        div.c {
            margin: 1em 0;
        }

        div.login-action {
            display: flex;
            justify-content: space-between;
            align-items: center;
        }

        a.sign-up {
            color: var(--warn);
            text-decoration: underline;
            cursor: pointer;
            user-select: none;
        }
    </style>
    <div class="login-wrapper">
        <div class="login-frm">
            <form runat="server" style="width: 100%;">
                <h1>Login</h1>
                <div class="c uname">
                    <Ngo:Text runat="server" ID="uname" LblText="User Name" />
                </div>
                <div class="c pwd">
                    <Ngo:Text runat="server" ID="pwd" LblText="Password" Type="Password" />
                </div>
                <div class="c login-action">
                    <asp:button runat="server" class="ngo-btn" ID="loginBtn" Text="Login" />
                    <a runat="server" href="~/Signup.aspx" class="sign-up">Sign up</a>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
