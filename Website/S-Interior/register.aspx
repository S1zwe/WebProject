<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="S_Interior.registernew" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
       <!-- PAGE BANNER SECTION -->
<div class="page-banner-section section">
    <div class="container">
        <div class="row">
            <div class="page-banner-content col-xs-12">
                 <h2>Register</h2>
                <ul class="breadcrumb">
                    <li><a href="modernhome.aspx">Home</a></li>
                    <li class="active">Register</li>
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
<div class="page-section section pt-100 pb-100">
    <div class="container">
        <div class="row">
            <div class="col-md-8 col-md-offset-2 col-xs-12">
                <div class="login-reg-form">
                  <form action="#" class="p-5 bg-white">
                <div class="row form-group">
                <div class="col-md-12 mb-3 mb-md-0">
                  <label class="font-weight-bold" for="fullname">Name</label>
                  <input type="text" id="Name" class="form-control" runat="server" placeholder ="Full Name">
                </div>
                    </div>
                    <div class="row form-group">
                <div class="col-md-12 mb-3 mb-md-0">
                  <label class="font-weight-bold" for="Lastname">Surname</label>
                  <input type="text" id="Surname" class="form-control" runat="server" placeholder ="Surname">
                </div>
                        </div>
                        <div class="row form-group">
                <div class="col-md-12 mb-3 mb-md-0">
                  <label class="font-weight-bold" for="Email">Email</label>
                  <input type="text" id="Email" class="form-control" runat="server" placeholder ="Email">
                </div>
                            </div>
                            <div class="row form-group">
                <div class="col-md-12 mb-3 mb-md-0">
                  <label class="font-weight-bold" for="HomeAddress">Home Adress</label>
                  <input type="text" id="Adress" class="form-control" runat="server" placeholder ="Address">
                </div>
                 </div>
             
              <div class="row form-group">
                <div class="col-md-12">
                  <label class="font-weight-bold" for="pass">Password:</label>
                  <input type="password" id="pass" class="form-control" runat="server" placeholder="Password">
                </div>
                  </div>

                  <div class="row form-group">
                <div class="col-md-12">
                  <label class="font-weight-bold" for="cpass">Confirm Password:</label>
                  <input type="password" id="cPass" class="form-control" runat="server" placeholder="Confirm Password">
                </div>
                      </div>

                      <div class="row form-group">
              </div>

              <div class  ="row form-group">
                  <div class="col-md-12">
                      <label class="font-weight-bold" for=" Design favorite">Design First Choice:</label>
                      <select type="txt" id="choice"  runat="server">
                          <option value="modern">Modern</option>
                          <option value="vintage">Vintage</option>
                          <option value="smart">Smart</option>
                      </select>
                  </div>
              </div>

              <div class="row form-group">
                  <div class="col-md-12">
                      <asp:Button ID="btnRegister" runat="server" Text="Register" BackColor="Black" BorderColor="#FF6600" ForeColor="White" OnClick="btnRegister_Click" />
                  
                </div>
              </div>

            </form>
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


