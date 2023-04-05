<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="ITLab1_groupV.Glasaj" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Image ID="logo" runat="server" AlternateText="Лого на ФИНКИ" ImageUrl="https://finki.ukim.mk/sites/default/files/logo_10.png" />
    </div>

    <div>
        <asp:Label ID="lblProfessor" runat="server" Text="Проф. д-р Гоце Арменски"></asp:Label>
    </div>

    <div style="margin-bottom: 10px;">
        <asp:ListBox ID="listSubjects" runat="server" OnSelectedIndexChanged="listSubjects_SelectedIndexChanged"></asp:ListBox>
        <asp:ListBox ID="listCredits" runat="server"></asp:ListBox>
    </div>

    <div style="margin-bottom: 10px;">
        <asp:Button ID="btnVote" runat="server" Text="Гласајте" OnClick="btnVote_Click" />
    </div>

    <div style="width: 260px; margin-bottom: 20px;">
        <hr />
    </div>

    <div style="width: 260px; margin-left: 70px;">
        <asp:Label ID="lblAddSubject" runat="server" Text="Предмет:"></asp:Label>
    </div>

    <div class="text-center" style="width: 260px;  margin-bottom: 20px;">
        <asp:TextBox ID="addSubject" runat="server"></asp:TextBox>
    </div>

    <div style="width: 260px; margin-left: 70px;">
        <asp:Label ID="lblAddCredit" runat="server" Text="Кредити:"></asp:Label>
    </div>

    <div class="text-center" style="width: 260px; margin-bottom: 20px;">
        <asp:TextBox ID="addCredit" runat="server"></asp:TextBox>
    </div>

    <div style="margin-left: 40px; margin-bottom: 10px;">
        <asp:Button ID="btnAddSubject" runat="server" Text="Додади" OnClick="btnAddSubject_Click" />
    </div>

    <div style="margin-left: 40px;">
        <asp:Button ID="btnRemoveSubject" runat="server" Text="Избриши" OnClick="btnRemoveSubject_Click" />
    </div>

</asp:Content>
