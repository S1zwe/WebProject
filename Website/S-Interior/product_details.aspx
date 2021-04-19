<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="product_details.aspx.cs" Inherits="S_Interior.product_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

    
<!-- PRODUCT SECTION START -->
<div class="product-section section pb-100">
    <div class="container">
        <div class="row">
            <div class="section-title text-center col-xs-12 mb-70">
                <h2>related products</h2>
            </div>
        </div>
        <div class="row">
            <div class="product-slider product-slider-4">
                <!-- product-item start -->
                <div class="col-xs-12">
                    <div class="product-item text-center">
                        <div class="product-img">
                            <a class="image" href="product-details.html"><img src="img/product/1.jpg" alt=""/></a>
                            <a href="#" class="add-to-cart">add to cart</a>
                            <div class="action-btn fix">
                                <a href="#" title="Wishlist"><i class="pe-7s-like"></i></a>
                                <a href="#" data-toggle="modal"  data-target="#productModal" title="Quickview"><i class="pe-7s-look"></i></a>
                                <a href="#" title="Compare"><i class="pe-7s-repeat"></i></a>
                            </div>
                        </div>
                        <div class="product-info">
                            <h5 class="title"><a href="product-details.html">Le Parc Minotti Chair</a></h5>
                            <span class="price"><span class="new">$169.00</span></span>
                        </div>
                    </div>
                </div>
                <!-- product-item end -->
                <!-- product-item start -->
                <div class="col-xs-12">
                    <div class="product-item text-center">
                        <div class="product-img">
                            <a class="image" href="product-details.html"><img src="img/product/2.jpg" alt=""/></a>
                            <a href="#" class="add-to-cart">add to cart</a>
                            <div class="action-btn fix">
                                <a href="#" title="Wishlist"><i class="pe-7s-like"></i></a>
                                <a href="#" data-toggle="modal"  data-target="#productModal" title="Quickview"><i class="pe-7s-look"></i></a>
                                <a href="#" title="Compare"><i class="pe-7s-repeat"></i></a>
                            </div>
                        </div>
                        <div class="product-info">
                            <h5 class="title"><a href="product-details.html">DSR Eiffel chair</a></h5>
                            <span class="price"><span class="new">$137.00</span><span class="old">$115.00</span></span>
                        </div>
                    </div>
                </div>
                <!-- product-item end -->
                <!-- product-item start -->
                <div class="col-xs-12">
                    <div class="product-item text-center">
                        <div class="product-img">
                            <a class="image" href="product-details.html"><img src="img/product/3.jpg" alt=""/></a>
                            <a href="#" class="add-to-cart">add to cart</a>
                            <div class="action-btn fix">
                                <a href="#" title="Wishlist"><i class="pe-7s-like"></i></a>
                                <a href="#" data-toggle="modal"  data-target="#productModal" title="Quickview"><i class="pe-7s-look"></i></a>
                                <a href="#" title="Compare"><i class="pe-7s-repeat"></i></a>
                            </div>
                        </div>
                        <div class="product-info">
                            <h5 class="title"><a href="product-details.html">3d laser cut models</a></h5>
                            <span class="price"><span class="new">$185.00</span><span class="old">$125..00</span></span>
                        </div>
                    </div>
                </div>
                <!-- product-item end -->
                <!-- product-item start -->
                <div class="col-xs-12">
                    <div class="product-item text-center">
                        <div class="product-img">
                            <a class="image" href="product-details.html"><img src="img/product/4.jpg" alt=""/></a>
                            <a href="#" class="add-to-cart">add to cart</a>
                            <div class="action-btn fix">
                                <a href="#" title="Wishlist"><i class="pe-7s-like"></i></a>
                                <a href="#" data-toggle="modal"  data-target="#productModal" title="Quickview"><i class="pe-7s-look"></i></a>
                                <a href="#" title="Compare"><i class="pe-7s-repeat"></i></a>
                            </div>
                        </div>
                        <div class="product-info">
                            <h5 class="title"><a href="product-details.html">carl hansen ch25</a></h5>
                            <span class="price"><span class="new">$245.00</span></span>
                        </div>
                    </div>
                </div>
                <!-- product-item end -->
                <!-- product-item start -->
                <div class="col-xs-12">
                    <div class="product-item text-center">
                        <div class="product-img">
                            <a class="image" href="product-details.html"><img src="img/product/5.jpg" alt=""/></a>
                            <a href="#" class="add-to-cart">add to cart</a>
                            <div class="action-btn fix">
                                <a href="#" title="Wishlist"><i class="pe-7s-like"></i></a>
                                <a href="#" data-toggle="modal"  data-target="#productModal" title="Quickview"><i class="pe-7s-look"></i></a>
                                <a href="#" title="Compare"><i class="pe-7s-repeat"></i></a>
                            </div>
                        </div>
                        <div class="product-info">
                            <h5 class="title"><a href="product-details.html">DSR Eiffel chair</a></h5>
                            <span class="price"><span class="new">$137.00</span><span class="old">$115.00</span></span>
                        </div>
                    </div>
                </div>
                <!-- product-item end -->
            </div>
        </div>
    </div>
</div>
<!-- PRODUCT SECTION END --> 
    
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
                    <p>Free shipping on all UK orders</p>
                </div>
            </div>
            <!-- Single Service -->
            <div class="single-service col-md-3 col-sm-6 col-xs-6 mb-30">
                <div class="service-icon">
                    <i class="pe-7s-refresh"></i>
                </div>
                <div class="service-title">
                    <h3>FREE EXCHANGE</h3>
                    <p>30 days return on all items</p>
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
<!-- SERVICE SECTION END -->  
</asp:Content>
