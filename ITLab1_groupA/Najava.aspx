<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="ITLab1.Najava" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row" style="margin-bottom: 10px;">
        <div>                           
            <span style="display: inline-block; width: 100px;">Име</span>
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidator1"
                runat="server"
                ErrorMessage="Внесете име"
                class="text-danger"
                ControlToValidate="name"></asp:RequiredFieldValidator>
        </div>
    </div>

    <div class="row" style="margin-bottom: 10px;">
        <div>
            <span style="display: inline-block; width: 100px;">Лозинка</span>
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidator2"
                runat="server"
                ErrorMessage="Внесете лозинка"
                class="text-danger"
                ControlToValidate="password"></asp:RequiredFieldValidator>
        </div>
    </div>

    <div class="row">
        <div>
            <span style="display: inline-block; width: 100px;">е-адреса</span>
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidator3"
                runat="server"
                ErrorMessage="Ова поле е задолжително!"
                class="text-danger"
                ControlToValidate="email"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator
                ID="RegularExpressionValidator1"
                runat="server"
                ErrorMessage="Невалиден формат"
                class="text-danger"
                ControlToValidate="email"
                ValidationExpression="[\w.-]+\@\w+\.[\w.-]+"></asp:RegularExpressionValidator>
        </div>
    </div>

    <div style="margin-top: 10px; margin-left: 105px;">
        <asp:Button ID="login" runat="server" Text="Најавете се" OnClick="login_Click" />
    </div>
</asp:Content>
