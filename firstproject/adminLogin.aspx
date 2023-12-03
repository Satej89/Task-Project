<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminLogin.aspx.cs" Inherits="firstproject.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <div class="max-width1 mx-auto12 px12 min-h-[calc(100vh-65px-68px)] flex12 flex-col12 justify-center12">
            <div class="bg-body border rounded-2 m-2 p-4  ">
                <div class="m-1 mb-4 d-flex justify-content-center">
                    <img src="img/adminuser.png" width="150px" class="img-fluid" />
                </div>

                <div class="form-outline m-2">
                    <label for="ContentPlaceHolder1_TextBox1" class="text-start fw-normal h3">
                        Username
                    </label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="admin id"></asp:TextBox>
                    </div>
                </div>

                <div class="form-outline m-2">
                    <label for="ContentPlaceHolder1_TextBox2" class="text-start fw-normal h3">
                        Password
                    </label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                    </div>

                </div>
                <div class="form-group d-grid    ">
                    <asp:Button CssClass="btn btn-success m-2 fs-4 fw-normal " ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                </div>


            </div>
        </div>

    </section>
</asp:Content>
