<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="UniversityDBProject.AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
        <div id="div">
            <asp:Label ID="Label1" runat="server"></asp:Label>
             <a href="ProfRegisteration.aspx" style="float:right">Add New Professor</a>
            <br/>
             <asp:Button ID="Button1" runat="server" Text="Student" CssClass="Button" OnClick="Button1_Click" />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Professor" CssClass="Button" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True">
            </asp:GridView>
        <br />
            </div>
    </form>
</asp:Content>
