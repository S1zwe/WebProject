<%@ Page Title="" Language="C#" MasterPageFile="~/Modern.Master" AutoEventWireup="true" CodeBehind="moderncart.aspx.cs" Inherits="S_Interior.moderncart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
                    <p>Lay-buy, Credit, Cash </p>
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

    <div class="page-section section pt-100 pb-60">
    <div class="container">
        <div class="row">
            <form action="#">				
                <div class="col-xs-12">
                    <div class="cart-table table-responsive mb-40">
                        <table>
                            <div id="myHtml" runat="server">
                                
                            </div>
                            
                            <tbody>
                                <div id="cartHtml" runat="server">


                                </div>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class="col-md-8 col-sm-7 col-xs-12">
                    <div class="cart-buttons mb-30">
                        <a href="modernshop.aspx">Continue Shopping</a>
                    </div>
                     <div class="cart-coupon mb-40">
                       <div class="cart-buttons mb-30">
                        <a href="applyPoints.aspx">Apply Points</a>
                    </div>   
                            </div>
                </div>
                <div class="col-md-4 col-sm-5 col-xs-12">
                    <div class="cart-total mb-40">
                        <h3>Cart Totals</h3>
                        <table>
                            <div id="cartTotalHtml" runat="server">
                                
                            </div>
                        </table>
                        <div class="proceed-to-checkout section mt-30">
                            <a href="verifyCart.aspx">Proceed to Checkout</a>
                        </div>
                    </div>
                </div>
            </form>	
        </div>
    </div>
</div>
<!-- PAGE SECTION END --> 
    
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
</asp:Content>
