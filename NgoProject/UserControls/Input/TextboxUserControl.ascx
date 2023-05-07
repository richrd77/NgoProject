<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TextboxUserControl.ascx.cs" Inherits="NgoProject.UserControls.Input.TextboxUserControl" %>
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

    .c-err {
        color: var(--warn);
        display: none;
        font-size:0.7rem;
    }
</style>

<div class="s-control">
    <label runat="server" id="lbl" class="s-fld-name"></label>
    <asp:TextBox ID="txt1" onChange="Validate(event);" runat="server"></asp:TextBox>
</div>
<div class="c-err" runat="server" id="er"></div>
<script>
    function Validate(e) {
        const t = e.target;
        const err = t.parentElement.nextElementSibling;
        const required = t.getAttribute('data-required');
        console.log(t.parentElement.nextElementSibling);
        if (required) {
            t.setAttribute('required', '');
            if (!t.value) {
                err.style.display = 'block';
            } else {
                err.style.display = 'none';
            }
        }
    }

</script>
