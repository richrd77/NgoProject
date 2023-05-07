<%@ Page Title="SignUp" Language="C#" MasterPageFile="~/Ngo.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="NgoProject.Signup" %>

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

        .err {
            color: var(--warn);
            display: none;
        }
    </style>
    <div class="login-wrapper">
        <div class="login-frm">
            <form runat="server" style="width: 100%;">
                <h1>Sign up</h1>
                <div class="c uname">
                    <Ngo:Text runat="server" LblText="Name" />
                </div>
                <div class="c tel">
                    <Ngo:Text runat="server" LblText="Mobile" />
                </div>
                <div class="c add">
                    <Ngo:Text runat="server" LblText="address" />
                </div>
                <div class="c email">
                    <Ngo:Text runat="server" LblText="Email" />
                </div>
                <div class="c dob">
                    <Ngo:Text runat="server" LblText="Date of Birth" />
                </div>
                <div class="c gen">
                    <Ngo:Text runat="server" LblText="Gender" />
                </div>
                <div class="c pwd">
                    <Ngo:Text runat="server" LblText="Password" Type="Password" />
                </div>
                <div class="c login-action">
                    <button class="ngo-btn">Signup</button>
                    <a runat="server" href="~/Login.aspx" class="sign-up">Login</a>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
