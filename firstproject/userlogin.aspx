<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="firstproject.userlogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Login Page</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <div class="max-width1 mx-auto12 px12 min-h-[calc(100vh-65px-68px)] flex12 flex-col12 justify-center12">
            <div class="bg-body border rounded-2 m-2 p-4  ">
                <div class="m-1 mb-4 d-flex justify-content-center">
                    <img src="img/generaluser.png" width="150px" class="img-fluid" />
                </div>

                <div class="form-outline">
                    <label for="ContentPlaceHolder1_TextBox1" class="text-start fw-normal h3">
                        Username
                    </label>
                    <div class="form-group">
                        <asp:TextBox Class="form-control" ID="TextBox1" runat="server" placeholder=" email id or phone number"></asp:TextBox>
                    </div>
                </div>

                <div class="form-outline mt-2">
                    <label for="ContentPlaceHolder1_TextBox2" class="text-start fw-normal h3">
                        Password
                    </label>
                    <div class="form-group">
                        <asp:TextBox Class="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="mb-4 mt-1 h5 justify-content-end">
                        <a href="#">Forgot password?</a>
                    </div>
                </div>

                <div class="form-group d-grid    ">
                    <asp:Button Class="btn btn-success m-2 fs-4 fw-normal " ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                </div>

                <div class="text-center h5">
                    <p>
                        Not a member?  
                    <a href="registrationPage.aspx">Register here</a>
                </div>
            </div>
        </div>

    </section>
</asp:Content>
