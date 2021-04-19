<%@ Page Title="" Language="C#" MasterPageFile="~/Modern.Master" AutoEventWireup="true" CodeBehind="modernShop.aspx.cs" Inherits="S_Interior.modernShop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- PAGE BANNER SECTION -->
<div class="page-banner-section section">
    <div class="container">
        <div class="row">
            <div class="page-banner-content col-xs-12">
                 <h3><a href="changeShop.aspx?Shop=S">Interios</a>/<a href="changeShop.aspx?Shop=F">Furnitures</a></h3>
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
                <div class="row two-column" id="shopHtml" runat="server">
                    
                    <div class="page-pagination text-center col-xs-12 fix mb-40">
                       <!-- Main Displayment -->
                    </div>
                </div>

                <!-- To Be Finished --> 
                 <div class="row two-column" >
                    <div class="page-pagination text-center col-xs-12 fix mb-40">
                        <ul>
                            <li><a href="#"><i class="fa fa-angle-left"></i></a></li>
                            <li class="active"><a href="#">1</a></li>
                            <li><a href="#">2</a></li>
                            <li><a href="#">3</a></li>
                            <li><a href="#">4</a></li>
                            <li><a href="#"><i class="fa fa-angle-right"></i></a></li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="col-lg-3 col-md-4 col-xs-12">
                  
                <div class="single-sidebar mb-40">
                    <h3 class="sidebar-title">Category</h3>
                    <ul class="category-sidebar">
                        <li><a href="changeRoom.aspx?Room=Kitchen">Kitchens</a></li>
                        <li><a href="changeRoom.aspx?Room=Living">Living Rooms</a></li>
                        <li><a href="changeRoom.aspx?Room=Bed">Bed Rooms</a></li>
                    </ul>
                </div>
            </div>

        </div>
    </div>
</div>
<!-- PAGE SECTION END --> 
</asp:Content>
