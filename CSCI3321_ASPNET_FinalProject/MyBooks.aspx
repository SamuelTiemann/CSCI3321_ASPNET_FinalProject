<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyBooks.aspx.cs" Inherits="CSCI3321_ASPNET_FinalProject.MyBooks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>My Books</h3>
    <div>
        <asp:Table ID="tblMyBooks" runat="server" Width="100%" CssClass="table table-striped">
            <asp:TableRow>
                <asp:TableCell>Title</asp:TableCell>
                <asp:TableCell>Author First Name</asp:TableCell>
                <asp:TableCell>Author Last Name</asp:TableCell>
                <asp:TableCell>Price</asp:TableCell>
                <asp:TableCell>Publish Date</asp:TableCell>
                <asp:TableCell>Publisher</asp:TableCell>
                <asp:TableCell>Genre</asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
</asp:Content>
