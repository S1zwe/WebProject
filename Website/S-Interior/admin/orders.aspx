<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMaster.Master" AutoEventWireup="true" CodeBehind="orders.aspx.cs" Inherits="S_Interior.admin.soders" %>
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
									<li><a href="interios.aspx">Interios</a></li>
									<li><a href="customers.aspx">Customers</a></li>
                                    <li><a href="AddProduct.aspx">Add new Product</a></li>
								</ul>
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
								<h3 class="page-title">Orders/<a href="admin.aspx">Dashboard</a></h3>
                                <h6 class="page-title">By Registered Customers</h6>
								<ul class="breadcrumb">
									<li class="breadcrumb-item"><a href="admin.aspx">Dashboard</a></li>
									<li class="breadcrumb-item active"><a href="changeOderList.aspx?Status=S">To be Shipped</a></li>
                                    <li class="breadcrumb-item active"><a href="changeOderList.aspx?Status=A">All</a></li>
                                     <li class="breadcrumb-item active"><a href="changeOderList.aspx?Status=P">Pending</a></li>
								</ul>
							</div>
						</div>
					</div>
					<!--<div class="page-header">
						<div class="row">
							<div class="col-sm-12">
                                <h6 class="page-title">By Temp Customers</h6>
								<ul class="breadcrumb">
									<li class="breadcrumb-item"><a href="admin.aspx">Dashboard</a></li>
									<li class="breadcrumb-item active"><a href="orders.aspx">To be Shipped</a></li>
                                    <li class="breadcrumb-item active"><a href="orders.aspx">All</a></li>
                                     <li class="breadcrumb-item active"><a href="orders.aspx">Pending</a></li>
								</ul>
							</div>
						</div>
					</div>-->

					<div class="row">
						<div class="col-sm-12">
							<div class="card card-table">
								<div class="card-header">
									<h4 class="card-title">Orders</h4>
								</div>
                                <div class="card-body">
                                    <div class="table-responsive">
                                        <table class="table mb-0 table-hover">
                                            <thead>
                                                <tr>
                                                    <th>ID</th>
                                                    <th>Purchased</th>
                                                    <th>Surname</th>
                                                    <th>Name</th>
                                                    <th>Email</th>
                                                    <th>Rerence #</th>
                                                    <th>Quantity</th> 
                                                    <th>Status</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <div id="OrList" runat="server">


                                                </div>
                                            </tbody>
                                        </table>

                                    </div>
                                </div>
                            </div>
						</div>
					</div>
					
					
				
				</div>			
			</div>
			<!-- /Page Wrapper -->
		
        </div>
		<!-- /Main Wrapper -->
</asp:Content>
