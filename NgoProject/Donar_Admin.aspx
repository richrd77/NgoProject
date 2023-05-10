<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Donar_Admin.aspx.cs" Inherits="NgoProject.Donar_Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    
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
            <form runat="server" style="width: 100%;">
                <h1>List of Donars</h1>
<br /> <br />
                <asp:GridView ID="DonarGridData" CssClass="mydatagrid" PagerStyle-CssClass="pager"
 HeaderStyle-CssClass="header" AutoGenerateColumns="false" RowStyle-CssClass="rows" runat="server">
                    <Columns>
                    <asp:BoundField DataField="name" HeaderText="Name" /> 
                    <asp:BoundField DataField="amount" HeaderText="Amount" /> 
                    <asp:BoundField DataField="date" HeaderText="Date" /> 
                        </Columns>
                </asp:GridView>
            </form>
</asp:Content>
