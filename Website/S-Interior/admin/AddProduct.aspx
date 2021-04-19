<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMaster.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="S_Interior.admin.AddProduct" %>
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
								</ul>
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
							<div class="col">
								<h3 class="page-title">Add new Items</h3>
								<ul class="breadcrumb">
									<li class="breadcrumb-item"><a href="admin.aspx">Dashboard</a></li>
									<li class="breadcrumb-item active">Add new Items</li>
								</ul>
							</div>
						</div>
					</div>
					<!-- /Page Header -->
					
					<div class="row">
						<div class="col-xl-3 col-sm-6 col-12">
							<div class="product">
								<div class="product-inner">
                                     <!-- /Code to upload Image -->
                                    <input id="fileupload" type="file" multiple="multiple" />
                                    <div id="dvPreview">
                                    </div>
								</div>
								<div class="pro-desc">
                                     <!-- /Code to Allow User to change Product Information -->
                 <input type="text" id="ImageTX" class="form-control" runat="server" placeholder ="Enter Image name as the same as above image...">
                <input type="text" id="Name" class="form-control" runat="server" placeholder ="Name here...">
                <input type="text" id="Description" class="form-control" runat="server" placeholder ="Description here...">
                 <input type="text" id="TotalPrice" class="form-control" runat="server" placeholder ="Total Price here...">
                  <input type="text" id="Roomtype" class="form-control" runat="server" placeholder ="Room type here...">
                <input type="text" id="Designtype" class="form-control" runat="server" placeholder ="Design type here...">
                                    <asp:Button ID="btnUpload" runat="server" Text="Save Product Info" OnClick="btnUpload_Click" />
								</div>
							</div>
						</div>		
			</div>
		
		
        </div>
	
<script language="javascript" type="text/javascript">
window.onload = function () {
    var fileUpload = document.getElementById("fileupload");
    fileUpload.onchange = function () {
        if (typeof (FileReader) != "undefined") {
            var dvPreview = document.getElementById("dvPreview");
            dvPreview.innerHTML = "";
            var regex = /^([a-zA-Z0-9\s_\\.\-:])+(.jpg|.jpeg|.gif|.png|.bmp)$/;
            for (var i = 0; i < fileUpload.files.length; i++) {
                var file = fileUpload.files[i];
                if (regex.test(file.name.toLowerCase())) {
                    var reader = new FileReader();
                    reader.onload = function (e) {
                        var img = document.createElement("IMG");
                        img.height = "800";
                        img.width = "600";
                        img.src = e.target.result;
                        dvPreview.appendChild(img);
                    }
                    reader.readAsDataURL(file);
                } else {
                    alert(file.name + " is not a valid image file.");
                    dvPreview.innerHTML = "";
                    return false;
                }
            }
        } else {
            alert("This browser does not support HTML5 FileReader.");
        }
    }
};
</script>

</asp:Content>
