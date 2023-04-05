<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UspeshnoGlasanje.aspx.cs" Inherits="ITLab1_groupV.UspeshnoGlasanje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>
            Ви благодариме за учеството во акцијата за избор на најинтересен предмет на ФИНКИ.<br /><br />
            Резултатите од гласањето ќе ги добиете по електронска пошта, на Е-MAIL:
            <em><asp:Label ID="savedEmail" runat="server" Text="ime.prezime@students.finki.ukim.mk"></asp:Label></em>
        </h1>
    </div>
</asp:Content>
