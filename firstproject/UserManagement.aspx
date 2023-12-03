<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UserManagement.aspx.cs" Inherits="firstproject.UserManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
         
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).DataTable();
        });

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <div class="row m-1">
            <div class="col-xl-5 ">
                <div class="bg-body border rounded-2 m-2 p-4  ">

                    <div class="h2 m-4 mt-0 mb-2 d-flex justify-content-center align-items-center fw-normal">
                        User Details
                    </div>
                    <div class="m-1   p-1">
                        <label for="ContentPlaceHolder1_TextBox16" class="h4 mb-0 fw-normal"> Email Id</label>
                        <div class="row  ">
                            <div class="col pe-0">

                                <div class="form-group">
                                    <asp:TextBox Class=" form-control" ID="TextBox1" runat="server" placeholder="username"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col ps-0">

                                <div class="form-group">
                                    <asp:LinkButton class="btn btn-primary" ID="LinkButton123" runat="server" Text="Search" OnClick="LinkButton123_Click"></asp:LinkButton>
                                </div>
                            </div>
                        </div>
                    </div>


                    <div class="m-1   p-1">
                        <label for="ContentPlaceHolder1_TextBox16" class="h4 mb-0 fw-normal">Account Status</label>
                        <div class="row  ">
                            <div class="col pe-0">

                                <div class="form-group">
                                    <asp:TextBox Class=" form-control" ID="TextBox2" runat="server" placeholder="status"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col ps-1 pe-0">

                                <div class="form-group">
                                    <asp:LinkButton class="btn btn-success  " ID="LinkButton41" runat="server" OnClick="LinkButton41_Click"><i class="fa-solid fa-check"></i></asp:LinkButton>
                                    <asp:LinkButton class="btn btn-warning" ID="LinkButton42" runat="server" OnClick="LinkButton42_Click"><i class="fa-solid fa-pause"></i></asp:LinkButton>
                                    <asp:LinkButton class="btn btn-danger" ID="LinkButton43" runat="server" OnClick="LinkButton43_Click"><i class="fa-solid fa-x"></i></asp:LinkButton>
                                </div>
                            </div>
                        </div>
                    </div>




                    <div class="m-1 p-1">
                        <label for="ContentPlaceHolder1_TextBox14" class="h4 mb-0 fw-normal">Email Id</label>
                        <div class="form-group">
                            <asp:TextBox Class="form-control" ID="TextBox14" runat="server" placeholder="Email Id" ReadOnly="True"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row p-2">
                        <div class="col">
                            <label for="ContentPlaceHolder1_TextBox12" class="h4 mb-0 fw-normal">
                                First Name
                            </label>
                            <div class="form-group">
                                <asp:TextBox Class="form-control" ID="TextBox12" runat="server" placeholder="first name" ReadOnly="True"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col">
                            <label for="ContentPlaceHolder1_TextBox13" class="h4 mb-0 fw-normal">Last name</label>
                            <div class="form-group">
                                <asp:TextBox Class="form-control" ID="TextBox13" runat="server" placeholder="last name" ReadOnly="True"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="m-1 p-1">
                        <label for="ContentPlaceHolder1_TextBox15" class="h4 mb-0 fw-normal">Phone number</label>
                        <div class="form-group">
                            <asp:TextBox Class="form-control" ID="TextBox15" runat="server" placeholder="Phone no." TextMode="Phone" ReadOnly="True"></asp:TextBox>
                        </div>
                    </div>
                    
                    <div class="row">


                        <div class="col-2 mx-auto d-flex justify-content-end ">
                            <div class="form-group   ">
                                <asp:Button Class="btn btn-danger m-2 fs-4 fw-normal " ID="Button2" runat="server" Text="Delete User " OnClick="Button2_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-xl-7">
                <div class="card m-2 p-2">
                    <div class="card-body">
                        <div class="row">
                            <div class="col text-center h2 fw-normal">
                                Users
                <hr />
                            </div>
                        </div>
                        <div class="row">
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:task_project1ConnectionString %>" SelectCommand="SELECT [username], [first_name], [email], [phone], [account_status] FROM [user_table2]"></asp:SqlDataSource>

                            <div class="col container align-items-center w-50">
                                <asp:GridView class="table table-bordered " ID="GridView1" runat="server" DataSourceID="SqlDataSource1" DataMember="DefaultView"></asp:GridView>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
