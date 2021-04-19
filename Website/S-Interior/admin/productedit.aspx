<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMaster.Master" AutoEventWireup="true" CodeBehind="productedit.aspx.cs" Inherits="S_Interior.admin.productedit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Main Wrapper -->
        <div class="main-wrapper">		
			<!-- Sidebar -->
            <div class="sidebar" id="sidebar">
                <div class="sidebar-inner slimscroll">
					<div id="sidebar-menu" class="sidebar-menu">
						<ul>
							<li class="menu-title"> 
								<span>Main</span>
							</li>
							<li class="active"> 
								<a href="admin.aspx"><i class="fe fe-home"></i> <span>Dashboard</span></a>
							</li>
							<li class="submenu">
								<a href="#"><i class="fe fe-cart"></i> <span> Ecommerce</span> <span class="menu-arrow"></span></a>
								<ul style="display: none;">
									<li><a href="orders.aspx">Orders</a></li>
									<li><a href="customers.aspx">Customers</a></li>
                                    <li><a href="customers.aspx">Interios</a></li>
                                    <li><a href="AddProduct.aspx">Add new Product</a></li>
								</ul>
							</li>
							<li> 
								<a href="users.aspx"><i class="fe fe-users"></i> <span>Users</span></a>
							</li>
				
						</ul>
					</div>
                </div>
            </div>
			<!-- /Sidebar -->
			
			<!-- Page Wrapper -->
            <div class="page-wrapper">
                <div class="content container-fluid">
				
					<div class="page-header">
						<div class="row">
							<div class="col-sm-12">
								<h3 class="page-title">Product Details</h3>
								<ul class="breadcrumb">
									<li class="breadcrumb-item"><a href="admin.aspx">Dashboard</a></li>
									<li class="breadcrumb-item active">Product Edit</li>
								</ul>
							</div>
						</div>
					</div>
					
					<div class="card">
						<div class="card-body">
							<div class="row">
								<div class="col-md-6 col-sm-12">
									<div class="product-view">
										<div class="proimage-wrap">
                                            <div id="ImageDisplay" runat="server">
                                                
                                            </div>
											
											<ul class="proimage-thumb">
                                                <div id="smalImages" runat="server">

                                                </div>
											</ul>
										</div>
									</div>
								</div>
								<div class="col-md-6 col-sm-12">
									<div class="product-info">
                                        <div id="informationDisp" runat="server">
                                           
                                        </div>
										
                                        <div>
										    <asp:Label ID="Label1" runat="server" BackColor="White" ForeColor="#000099" Text="Enter 1 for Availabity / 0 for Not availabe"></asp:Label>
                                            <asp:TextBox ID="TextBox1" runat="server" Height="30px" Width="50px"></asp:TextBox>
										</div>
                                        <div>
										    <asp:Button ID="btnDelete" runat="server" BackColor="Red" BorderColor="Red" ForeColor="White" Text="Delete" OnClick="btnDelete_Click" />
										</div>
                                         
									</div>
								</div>
								<div class="col-sm-12">
									<ul class="nav nav-tabs nav-tabs-bottom">
										<li class="nav-item"><a class="nav-link active" href="#product_desc" data-toggle="tab">Discription</a></li>
									</ul>
									<div class="tab-content">
										<div class="tab-pane show active" id="product_desc">
											<div class="product-content" id="Discrib" runat="server">
												
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
				
				</div>			
			</div>
			<!-- /Page Wrapper -->




				</div>			
			</div>
			<!-- /Page Wrapper -->
		
        </div>
		<!-- /Main Wrapper -->
</asp:Content>
