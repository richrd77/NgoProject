<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SelectUserControl.ascx.cs" Inherits="NgoProject.UserControls.Input.SelectUserControl" %>
<style>
    div.s-control {
        position: relative;
        border: 1px solid rgba(0, 0, 0, 0.1215686275);
        width: 100%;
        display: inline-block;
    }

        div.s-control:focus-within {
            box-shadow: 0 0 4px 0 var(--acent);
        }

        div.s-control > label.s-fld-name {
            font-size: 0.7rem;
            position: absolute;
            top: -8px;
            left: 10px;
            background-color: var(--bgColor);
            padding: 0 5px;
            z-index: 2;
            user-select: none;
            text-transform: capitalize;
            font-family: inherit;
        }

        div.s-control > *:nth-child(2) {
            padding: 10px;
            border: transparent;
            outline: none;
            background-color: rgba(240, 240, 240, 0.2509803922);
            display: block;
            width: 100%;
            font-family: inherit;
        }
</style>

<div class="s-control">
    <label runat="server" id="lbl" class="s-fld-name"></label>
    <asp:DropDownList runat="server" ID="ddl">
    </asp:DropDownList>
</div>