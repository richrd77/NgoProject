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
    </style>
    <div class="login-wrapper">
        <div class="login-frm">
            <form runat="server" style="width: 100%;">
                <h1>Sign up</h1>

                <div id="errMsg" runat="server" class="c err">
                    <p>There is an error</p>
                </div>
                <div id="successMsg" runat="server" class="c err" style="color: green !important;">
                    <p>Registration successful! Now you can <a style="text-decoration: underline !important;" href="Login.aspx">Login</a> here</p>
                </div>
                <div class="c rol">
                    <ngo:select runat="server" id="ddlrole" errormessage="Role is required" requiredfield="true" />
                </div>
                <div class="c uname">
                    <ngo:text runat="server" lbltext="Name" id="name" errormessage="Name is required" requiredfield="true" />
                </div>
                <div class="c tel">
                    <ngo:text runat="server" lbltext="Mobile" id="mobile" errormessage="Mobile is required" requiredfield="true" />
                </div>
                <div class="c add">
                    <ngo:text runat="server" lbltext="address" id="address" errormessage="address is required" requiredfield="true" />
                </div>
                <div class="c email">
                    <ngo:text runat="server" lbltext="Email" id="email" errormessage="Email is required" requiredfield="true" />
                </div>
                <div class="c dob">
                    <ngo:date runat="server" id="dob" lbltext="Date of Birth" errormessage="Date of Birth is required" requiredfield="true" />
                </div>
                <div class="c gen">
                    <ngo:select runat="server" id="ddlgender" errormessage="Gender is required" requiredfield="true" />
                </div>
                <div class="c pwd">
                    <ngo:text runat="server" lbltext="Password" id="pwd" type="Password" errormessage="Password is required" requiredfield="true" />
                </div>
                <div class="c login-action">
                    <asp:Button runat="server" class="ngo-btn" ID="signBtn" Text="Sign up" OnClick="SignBtn_Click" />
                    <a runat="server" href="~/Login.aspx" class="sign-up">Login</a>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
