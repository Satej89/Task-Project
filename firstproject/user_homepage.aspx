<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="user_homepage.aspx.cs" Inherits="firstproject.user_homepage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg-light mt-0 mb-4 p-4">
        <div class="d-flex justify-content-center align-items-center">
            <div class=" p-0 d-flex" style="width: 150px; height: 150px; overflow: hidden; border-radius: 50%;">
                <asp:LinkButton class="nav-link" ID="LinkButton4" runat="server" Visible="true">
                    <asp:Image ID="imgview" Style="width: 100%; height: 100%; object-fit: cover;" runat="server" />
                </asp:LinkButton>

            </div>

        </div>
        <div class="d-flex justify-content-center align-items-center">
            <p class="h2" id="hello_user" runat="server"></p>
        </div>
        <div class="card m-4 ">
            <div class="card-body">
                <div class="row">
                    <div class="col align-items-center d-flex justify-content-center h4">
                        Your Details
                <hr />
                    </div>

                </div>
                <div class="row ">

                    <asp:Table ID="myTable" class="table" runat="server">
                        <asp:TableRow>
                            <asp:TableCell>Username</asp:TableCell>
                            <asp:TableCell>Firstname</asp:TableCell>
                            <asp:TableCell>Lastname</asp:TableCell>
                            <asp:TableCell>Email</asp:TableCell>
                            <asp:TableCell>Phone</asp:TableCell>
                            <asp:TableCell>Account Status</asp:TableCell>

                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ID="cell1"> </asp:TableCell>
                            <asp:TableCell ID="cell2"> </asp:TableCell>
                            <asp:TableCell ID="cell3"> </asp:TableCell>
                            <asp:TableCell ID="cell4"> </asp:TableCell>
                            <asp:TableCell ID="cell5"> </asp:TableCell>
                            <asp:TableCell ID="cell6"> </asp:TableCell>


                        </asp:TableRow>

                    </asp:Table>

                </div>

            </div>
        </div>
    </div>
    <asp:Table ID="Table1" runat="server"></asp:Table>

</asp:Content>
