﻿<%@ Page Title="Fund raiser" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="FundRaise.aspx.cs" Inherits="NgoProject.FundRaise" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <style>
        .err {
            color: var(--warn);
            font-size: 0.7rem;
        }
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
                <h1>Fund raiser</h1>
                <div class="c uname">
                    <Ngo:Text runat="server" ID="doName" LblText="Name" />
                    <label id="errName" runat="server" class="err" style="display: none;">Name is required</label>
                </div>
                <div class="c amount">
                    <Ngo:Text runat="server" ID="doAmount" LblText="Amount" />
                    <label id="errAmount" runat="server" class="err" style="display: none;">Amount is required</label>
                </div>
                <div class="c dob">
                    <Ngo:Date runat="server" ID="dod" Value="" LblText="Date of Fund Raise" />
                    <label id="errdod" runat="server" class="err" style="display: none;">Date of Fund raise is required</label>
                </div>
                <div class="c paymentmethod" style="pointer-events: none;">
                    <Ngo:Text runat="server" ID="paymentmethod" LblText="Payment method" Value="Cash" />
                </div>                
                <div id="errMsg" runat="server" class="c err">
                    <p>There is an error</p>
                </div>                
                <div id="succMsg" runat="server" class="c err" style="color: green;">
                    <p>Thanks!. Your entry saved.</p>
                </div>
                <div class="c"  style="text-align:center">
                    <asp:Button runat="server" class="ngo-btn" ID="submitBtn" Text="Submit" OnClick="submitBtn_Click" />
                    <asp:Button runat="server" class="ngo-btn" ID="resetBtn" Text="Reset" OnClick="resetBtn_Click" />
                </div>
            </form>
        </div>
    </div>
</asp:Content>
