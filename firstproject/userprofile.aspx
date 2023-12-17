<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userprofile.aspx.cs" Inherits="firstproject.userprofile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <div class="max-width12 mx-auto12 px12   flex12 flex-col12 justify-center12">
            <div class="bg-body border rounded-2 m-2 p-4  ">
                <div class="m-1 mb-0 d-flex justify-content-center">
                    <asp:Image ID="imgview" style="width: 150px; height: 150px; overflow: hidden; border-radius: 50%;" runat="server" />
                </div>
                <div class="h1 m-4 mt-0 mb-1 d-flex justify-content-center align-items-center fw-normal">
                    Your Profile
                </div>
                <div class="d-flex justify-content-center align-items-center mb-2 nav-item active">
                    <span class="h5">Profile Status :-</span>

                    <asp:LinkButton CssClass="badge rounded-pill bg-info text-dark" ID="Link_status" runat="server" Text=" ">

                    </asp:LinkButton>
                </div>


                <div class="row p-2">
                    <div class="col">
                        <label for="ContentPlaceHolder1_TextBox12" class="h4 mb-0 fw-normal">
                            First Name
                        </label>
                        <div class="form-group">
                            <asp:TextBox Class="form-control" ID="TextBox12" runat="server" placeholder="first name"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col">
                        <label for="ContentPlaceHolder1_TextBox13" class="h4 mb-0 fw-normal">Last name</label>
                        <div class="form-group">
                            <asp:TextBox Class="form-control" ID="TextBox13" runat="server" placeholder="last name"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="m-1 p-1">
                    <label for="ContentPlaceHolder1_TextBox14" class="h4 mb-0 fw-normal">Email Id</label>
                    <div class="form-group">
                        <asp:TextBox Class="form-control" ID="TextBox14" runat="server" placeholder="Email Id"></asp:TextBox>
                    </div>
                </div>
                <div class="m-1 p-1">
                    <label for="ContentPlaceHolder1_TextBox15" class="h4 mb-0 fw-normal">Phone number</label>
                    <div class="form-group">
                        <asp:TextBox Class="form-control" ID="TextBox15" runat="server" placeholder="Phone no." TextMode="Phone"></asp:TextBox>
                    </div>
                </div>
                <div class="m-1 p-1">
                    <label for="ContentPlaceHolder1_TextBox16" class="h4 mb-0 fw-normal">Username or User Id</label>
                    <div class="form-group">
                        <asp:TextBox Class="form-control" ID="TextBox16" runat="server" placeholder="username"></asp:TextBox>
                    </div>
                </div>
                <div class="m-1 p-1">
                    <label for="ContentPlaceHolder1_TextBox17" class="h4 mb-0 fw-normal">Old Password</label>
                    <div class="form-group">
                        <asp:TextBox Class="form-control" ID="TextBox17" runat="server" placeholder="old password"></asp:TextBox>
                    </div>
                </div>
                <div class="m-1 p-1">
                    <label for="ContentPlaceHolder1_TextBox18" class="h4 mb-0 fw-normal">
                        New Password</label>
                    <div class="form-group">
                        <asp:TextBox Class="form-control" ID="TextBox18" runat="server" placeholder="new password" TextMode="Password"></asp:TextBox>
                    </div>
                </div>
                <div class="m-1 p-1">
                    <label for="ContentPlaceHolder1_TextBox20" class="h4 mb-0 fw-normal">
                        Confirm New Password</label>
                    <div class="form-group">
                        <asp:TextBox Class="form-control" ID="TextBox20" runat="server" placeholder="confirm password" TextMode="Password"></asp:TextBox>
                    </div>
                </div>
                <div class="m-1 p-1">
                    <label for="ContentPlaceHolder1_FileUpload1" class="form-label h4 mb-1 fw-normal">Upload New or Update Profile Picture</label>


                    <asp:FileUpload class="form-control" ID="FileUpload1" runat="server" />
                </div>
                <div class="  mx-auto d-flex justify-content-center align-items-center">
                    <div class="form-group   ">

                        <asp:Button Class="btn btn-primary m-2 fs-4 fw-normal " ID="Button19" runat="server" Text="Update" OnClick="Button21_Click" />
                    </div>
                </div>

            </div>
        </div>

    </section>
</asp:Content>
