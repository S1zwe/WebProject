<%@ Page Title="" Language="C#" MasterPageFile="~/Modern.Master" AutoEventWireup="true" CodeBehind="invoicepage.aspx.cs" Inherits="S_Interior.invoicepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

           <!-- PAGE BANNER SECTION -->
<div class="page-banner-section section">
    <div class="container">
        <div class="row">
            <div class="page-banner-content col-xs-12">
                <h3>Invoice</h3>
            </div>
        </div>
    </div>
</div>
<!-- END PAGE BANNER SECTION -->

    <!-- END PAGE BANNER SECTION -->
     <div class="container">

        <div class="row">	
            <div class="checkout-form">
                    <div class="col-lg-6 col-md-6 mb-40">
                        <form action="#">
                             <div class="col-md-8 col-sm-7 col-xs-12">
                                 <hr />
                    <div class="cart-buttons mb-30">
                        <a href="modernshop.aspx">Continue Shopping</a>
                    </div>
                   
                </div>  
                        </form>		
                    </div>
                    <div class="col-lg-6 col-md-6 col-xs-12 mb-40">
                        <div class="order-wrapper">
                            <div id="oderDis" runat="server"> 
                                  
                            </div>
                           
                            <div class="order-table table-responsive mb-30">
                                <table>
                                    <thead>
                                        <tr>
                                            <th class="product-name">Product</th>
                                            <th class="product-total">Total</th>
                                        </tr>							
                                    </thead>
                                   
                                    <tbody>
                                      <div id="smallCartHtml" runat="server">
                                        
                                        
                                       </div>
                                    </tbody>
                                    
                                   
                                       <tfoot>
                                           <div id="Totalmytml" runat="server">
                                       
                                       
                                            </div>
                                    </tfoot>
                                  
                                    
                                </table>
                            </div>
                    </div>
            </div>
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
