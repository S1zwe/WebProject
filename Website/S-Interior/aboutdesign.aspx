<%@ Page Title="" Language="C#" MasterPageFile="~/Modern.Master" AutoEventWireup="true" CodeBehind="aboutdesign.aspx.cs" Inherits="S_Interior.aboutdesign" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <!-- PAGE BANNER SECTION -->
<div class="page-banner-section section">
    <div class="container">
        <div class="row">
            <div class="page-banner-content col-xs-12">
                <ul class="breadcrumb">
                    <li><a href="modernshop.aspx">Home</a></li>
                    <li class="active">About</li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- END PAGE BANNER SECTION -->

    <!-- SERVICE SECTION START -->
<div class="service-section section pt-70 pb-40">
    <div class="container">
        <div class="row">
            <!-- Single Service -->
            <div class="single-service col-md-3 col-sm-6 col-xs-6 mb-30">
                <div class="service-icon">
                    <i class="pe-7s-world"></i>
                </div>
                <div class="service-title">
                    <h3>FREE SHIPPING</h3>
                    <p>Free shipping on all RSA orders</p>
                </div>
            </div>
            <!-- Single Service -->
            <div class="single-service col-md-3 col-sm-6 col-xs-6 mb-30">
                <div class="service-icon">
                    <i class="pe-7s-refresh"></i>
                </div>
                <div class="service-title">
                    <h3>Payments</h3>
                    <p>Layb-Buy /Cash/ Credit </p>
                </div>
            </div>
            <!-- Single Service -->
            <div class="single-service col-md-3 col-sm-6 col-xs-6 mb-30">
                <div class="service-icon">
                    <i class="pe-7s-headphones"></i>
                </div>
                <div class="service-title">
                    <h3>PREMIUM SUPPORT</h3>
                    <p>We support online 24 hours a day</p>
                </div>
            </div>
            <!-- Single Service -->
            <div class="single-service col-md-3 col-sm-6 col-xs-6 mb-30">
                <div class="service-icon">
                    <i class="pe-7s-gift"></i>
                </div>
                <div class="service-title">
                    <h3>BLACK FRIDAY</h3>
                    <p>Shocking discount on every friday</p>
                </div>
            </div>
        </div>
    </div>
</div> 
    <!-- Service adds Here -->
 
    <!-- PAGE SECTION START -->
<div class="page-section section pt-100 pb-60">
    <div class="container">
        <div class="row">
            <div class="col-lg-9 col-md-8 col-xs-12">
                <!-- Single Blog Post -->
                <div class="single-blog-post" id="myabout" runat="server">
                    
                </div>
                <!-- Comments Wrapper -->
                <div class="comment-wrapper mt-40 mb-40">
                   </h3> <li><a href="#"><h3>Book a view</h3></a></li>
                </div>
            </div>
          
            <!-- Furniturer Listing -->
              <div class="col-lg-9 col-md-8 col-xs-12 float-right">
               
                <div class="tab-content section" >
                    <div class="tab-pane active row" id="product-grid">
                        <!-- product-item start -->
                        <div id="furtnitureList" runat="server">
                        </div>
                        <!-- product-item end --> 
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- PAGE SECTION END --> 
</asp:Content>
