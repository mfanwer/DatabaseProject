<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="MarksEntry.aspx.cs" Inherits="UniversityDBProject.MarksEntry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
        <asp:TextBox ID="TextBox1" CssClass="TextBox" runat="server" Width="168px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" CssClass="Button" runat="server" OnClick="Button1_Click" Text="Update" />
    </form>
</asp:Content>
