<%@ Page Title="Members" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Member_Admin.aspx.cs" Inherits="NgoProject.Member_Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <style>
        
        .err{
            color: var(--warn);
            font-size:0.7rem;
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
                <h1>Members</h1>
                <div class="c uname">
                    <Ngo:Text runat="server" ID="doName" LblText="Name"  errormessage="Name is required" requiredfield="true" />
                <label id="errdoName" runat="server" class="err" style="display: none;">Name is required</label>
                </div>
                <div class="c dob">
                    <Ngo:Date runat="server" ID="doj" Value="" LblText="Join date"  errormessage="Join date is required" requiredfield="true"/>
                <label id="errdoj" runat="server" class="err" style="display: none;">Join date is required</label>
                </div>
                <div class="c dob">
                    <Ngo:Date runat="server" ID="dor" Value="" LblText="End date"  errormessage="End date is required" requiredfield="true"/>
                <label id="errdor" runat="server" class="err" style="display: none;">End date is required</label>
                </div>
                <div class="c usertype">
                    <ngo:select runat="server" id="ddlTypeofuser"  errormessage="Type of user is required" requiredfield="true"/>
                    <label id="errddlTypeofuser" runat="server" class="err" style="display: none;">Type of user is required</label>
                </div>
                <div id="errMsg" runat="server" class="c err">
                    <p>There is an error</p>
                </div>
                <div id="succMsg" runat="server" class="c err" style="color: green;">
                    <p>Thanks!. Your entry saved.</p>
                </div>
                <div class="c" style="text-align: center">
                    <asp:Button runat="server" class="ngo-btn" ID="submitBtn" Text="Submit" OnClick="submitBtn_Click" />
                    <asp:Button runat="server" class="ngo-btn" ID="resetBtn" Text="Reset" OnClick="resetBtn_Click" />
                </div>
                
<style>
    .mydatagrid
{
width: 80%;
border: solid 2px black;
min-width: 80%;
}
.header
{
background-color: #646464;
font-family: Arial;
color: White;
border: none 0px transparent;
height: 25px;
text-align: center;
font-size: 16px;
}

.rows
{
background-color: #fff;
font-family: Arial;
font-size: 14px;
color: #000;
min-height: 25px;
text-align: left;
border: none 0px transparent;
}
.rows:hover
{
background-color: #ff8000;
font-family: Arial;
color: #fff;
text-align: left;
}
.selectedrow
{
background-color: #ff8000;
font-family: Arial;
color: #fff;
font-weight: bold;
text-align: left;
}
.mydatagrid a /** FOR THE PAGING ICONS **/
{
background-color: Transparent;
padding: 5px 5px 5px 5px;
color: #fff;
text-decoration: none;
font-weight: bold;
}

.mydatagrid a:hover /** FOR THE PAGING ICONS HOVER STYLES**/
{
background-color: #000;
color: #fff;
}
.mydatagrid span /** FOR THE PAGING ICONS CURRENT PAGE INDICATOR **/
{
background-color: #c9c9c9;
color: #000;
padding: 5px 5px 5px 5px;
}
.pager
{
background-color: #646464;
font-family: Arial;
color: White;
height: 30px;
text-align: left;
}

.mydatagrid td
{
padding: 5px;
text-align: center;
}
.mydatagrid th
{
padding: 5px;
}
</style>
<br /> <br />            
    
                <h1>List of Members</h1>
<br /> <br />
                <asp:GridView ID="MemberGridData" CssClass="mydatagrid" PagerStyle-CssClass="pager"
 HeaderStyle-CssClass="header" AutoGenerateColumns="false" RowStyle-CssClass="rows" runat="server">
                    <Columns>
                    <asp:BoundField DataField="name" HeaderText="Name" /> 
                    <asp:BoundField DataField="JoinDate" HeaderText="Join Date" /> 
                    <asp:BoundField DataField="Enddate" HeaderText="End Date" /> 
                        </Columns>
                </asp:GridView>
            </form>
        </div>
    </div>
</asp:Content>
