<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMaster.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="S_Interior.admin.sadmin" %>
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
							
							<li class="submenu">
								<a href="#"><i class="fe fe-cart"></i> <span> Ecommerce</span> <span class="menu-arrow"></span></a>
								<ul style="display: none;">
									<li><a href="interios.aspx">Interios</a></li>
									<li><a href="orders.aspx">Orders</a></li>
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
					
					<!-- Page Header -->
					<div class="page-header">
						<div class="row">
							<div class="col-sm-12">
								<h3 class="page-title">Welcome Admin!</h3> 
								<ul class="breadcrumb">
									<li class="breadcrumb-item active">Dashboard</li>
								</ul>
							</div>
						</div>
					</div>
					<!-- /Page Header -->
        <!--------------------------------------------------------------  -->
                    <!--Reports  -->
					<div class="row">

                         <!-- Users Per Day --->
                        <div class="col-xl-3 col-sm-6 col-12" id="usrPer" runat="server">
							
						</div>
                        <div class="col-xl-3 col-sm-6 col-12" id="userReg" runat="server">
							
						</div>
						<div class="col-xl-3 col-sm-6 col-12" id="userhm" runat="server">
							
						</div>
                       
                        <!-- Products --->

						<div class="col-xl-3 col-sm-6 col-12" id="interiorHtm" runat="server">
							<div class="card">
								<div class="card-body">
									<div class="dash-widget-header">
										<span class="dash-widget-icon bg-success">
											<i class="fe fe-money"></i>
										</span>
										<div class="dash-count">
											<i class="fa fa-arrow-down text-danger"></i> 12%
										</div>
									</div>
									<div class="dash-widget-info">
										<h3>21587</h3>
										<h6 class="text-muted">Products</h6>
										<div class="progress progress-sm">
											<div class="progress-bar bg-success w-50"></div>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="col-xl-3 col-sm-6 col-12">
							<div class="card">
								<div class="card-body">
									<div class="dash-widget-header">
										<span class="dash-widget-icon bg-danger">
											<i class="fe fe-credit-card"></i>
										</span>
										<div class="dash-count">
											<i class="fa fa-arrow-down text-danger"></i>
										</div>
									</div>
									<div class="dash-widget-info">
                                        <div id="totaSale" runat="server">
                                           
										   
										
                                        </div>
										
									</div>
								</div>
							</div>
						</div>
						<div class="col-xl-3 col-sm-6 col-12">
                            <div id="Revenue" runat="server">

                            </div>
							<div class="card">
								<div class="card-body">
									<div class="dash-widget-header">
										<span class="dash-widget-icon bg-warning">
											<i class="fe fe-folder"></i>
										</span>
										<div class="dash-count">
											<i class="fa fa-arrow-up text-success"></i> 
										</div>
									</div>
									<div class="dash-widget-info">
                                         <div id="showTot" runat="server">
                                          
										
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
       <!--------------------------------------------------------------  -->
		
					<div class="row">

                        <!--------------------------------------------------------------  -->
						
                         <!--------------------------------------------------------------  -->

        <!--------------------------------------------------------------  -->
					
         <!--------------------------------------------------------------  -->
					</div>
				</div>			
			</div>
			<!-- /Page Wrapper -->
		
        </div>
</asp:Content>
