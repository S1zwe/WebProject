<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="S_Interior.log" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="utf-8">
    <meta http-equiv="x-ua-compatible" content="ie=edge">
    <title>S Interior</title>
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- Favicon -->
    <link rel="shortcut icon" type="image/x-icon" href="img/favicon.ico">
    
    <link href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700,900" rel="stylesheet"> 
    
    <!-- All CSS Files -->
    <!-- Bootstrap css -->
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <!-- Icon Font -->
    <link rel="stylesheet" href="css/font-awesome.min.css">
    <link rel="stylesheet" href="css/pe-icon-7-stroke.css">
    <!-- Plugins css file -->
    <link rel="stylesheet" href="css/plugins.css">
    <!-- Theme main style -->
    <link rel="stylesheet" href="style.css">
    <!-- Responsive css -->
    <link rel="stylesheet" href="css/responsive.css">

    <!-- Modernizr JS -->
    <script src="js/vendor/modernizr-2.8.3.min.js"></script>
</head>
    <!-- Body main wrapper start -->
<div class="wrapper">

<!-- START HEADER SECTION -->
<header class="header-section section sticker header-transparent">
    <div class="container-fluid">
        <div class="row">
            <!-- logo -->
            <div class="col-md-2 col-sm-6 col-xs-6">
                <div class="header-logo">
                    <a href="modernshop.aspx"><img src="img/logo.png" alt="main logo"></a>
                </div>
            </div>
            <!-- header-search & total-cart -->
           
            <!-- primary-menu -->
            <div class="col-md-8 col-xs-12">
                <nav class="main-menu text-center">
                    <ul>
                        <li class="active"><a href="register.aspx">Register</a>
                        </li>
                    </ul>
                </nav>
                <div class="mobile-menu"></div>
            </div>
        </div>
    </div>
</header>
<!-- END HEADER SECTION -->
<body>


     <!-- PAGE BANNER SECTION -->
<div class="page-banner-section section">
    <div class="container">
        <div class="row">
            <div class="page-banner-content col-xs-12">
                <h2>login</h2>
                <ul class="breadcrumb">
                    <li><a href="modernshop.aspx">Home</a></li>
                    <li class="active">login</li>
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



    <form id="form1" runat="server">
<div class="page-section section pt-100 pb-100">
    <div class="container">
        <div class="row">
            <div class="col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2 col-xs-12">
                <div class="login-reg-form">
                    
               


              <div class="row form-group">
                <div class="col-md-12 mb-3 mb-md-0">
                  <label class="font-weight-bold" for="Email">Email</label>
                  <input type="text" id="Email" class="form-control" runat="server" placeholder ="Here...">
                </div>
              </div>
              <div class="row form-group">
                <div class="col-md-12">
                  <label class="font-weight-bold" for="password">Password:</label>
                  <input type="password" id="pass" class="form-control" runat="server" placeholder="Here...">
                </div>
              </div>


                          <div class="col-xs-12">
                                <a href="#">Lost your password?</a>
                            </div>
              



              <div class="row form-group">
                
              </div>

              <div class="row form-group">
                <div class="col-md-12">
     
                    <asp:Button ID="btnLog" runat="server" BackColor="Black" Height="36px" OnClick="btnLog_Click" Text="Login" />
                </div>
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



        <div>
        </div>
    </form>
</body>
    <!-- FOOTER TOP SECTION START -->
<div class="footer-top-section section pb-60 pt-100">
	<div class="container">
		<div class="row">
            <!-- Footer Widget -->
			<div class="footer-widget col-md-3 col-sm-6 col-xs-12 mb-40">
				<h4 class="widget-title">Contact Info</h4>
				<p><strong>Address :</strong> <span>159 Juta Street, Braamfontain, Johannesburg RSA</span></p>
				<p><strong>Phone :</strong> <span>0767645130</span></p>
				<p><strong>Email :</strong> <a href="#">sinterior@gmail.com</a></p>
				<!-- Footer Social -->
				<div class="footer-social fix">
					<a href="#"><i class="fa fa-facebook"></i></a>
					<a href="#"><i class="fa fa-instagram"></i></a>
					<a href="#"><i class="fa fa-rss"></i></a>
					<a href="#"><i class="fa fa-twitter"></i></a>
					<a href="#"><i class="fa fa-pinterest"></i></a>
				</div>
			</div>
			<!-- Footer Widget -->
			<div class="footer-widget col-md-3 col-sm-6 col-xs-12 mb-40">
				<h4 class="widget-title">Newsletters</h4>
				<p>.</p>
				<form action="http://devitems.us11.list-manage.com/subscribe/post?u=6bbb9b6f5827bd842d9640c82&amp;id=05d85f18ef" method="post" id="mc-embedded-subscribe-form" name="mc-embedded-subscribe-form" class="sunscribe-form validate" target="_blank" novalidate>
                    <div id="mc_embed_signup_scroll">
                        <label for="mce-EMAIL" class="hidden">Subscribe to our mailing list</label>
                        <input type="email" value="" name="EMAIL" class="email" id="mce-EMAIL" placeholder="Email Address" required>
                        <!-- real people should not fill this in and expect good things - do not remove this or risk form bot signups-->
                        <div style="position: absolute; left: -5000px;" aria-hidden="true"><input type="text" name="b_6bbb9b6f5827bd842d9640c82_05d85f18ef" tabindex="-1" value=""></div>
                        <div class="clear"><input type="submit" value="Subscribe" name="subscribe" id="mc-embedded-subscribe" class="button"></div>
                    </div>
                </form>
			</div>
		</div>
	</div>
</div>
<!-- FOOTER TOP SECTION END -->  

<!-- FOOTER BOTTOM SECTION START -->
<div class="footer-bottom-section section pb-20 pt-20">
	<div class="container">
		<div class="row">
            <!-- Copyright -->
			<div class="copyright text-left col-sm-6 col-xs-12">
				<p>Copyright &copy; 2019 <a href="#"> Vestige</a>. All Right Reserved.</p>
			</div>
			<!-- Payment Method -->
			<div class="payment-method text-right col-sm-6 col-xs-12">
				<img src="img/payment/1.png" alt="payment" />
				<img src="img/payment/2.png" alt="payment" />
				<img src="img/payment/3.png" alt="payment" />
				<img src="img/payment/4.png" alt="payment" />
			</div>
		</div>
	</div>
</div>
<!-- FOOTER BOTTOM SECTION END -->  
  



    <!-- Body main wrapper end -->


<!-- Placed JS at the end of the document so the pages load faster -->

<!-- jQuery latest version -->
<script src="js/vendor/jquery-3.1.1.min.js"></script>
<!-- Bootstrap js -->
<script src="js/bootstrap.min.js"></script>
<!-- Plugins js -->
<script src="js/plugins.js"></script>
<!-- Ajax Mail js -->
<script src="js/ajax-mail.js"></script>
<!-- Main js -->
<script src="js/main.js"></script>  
</html>
