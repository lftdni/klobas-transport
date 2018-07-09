<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="KlobasTransport.Administration.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />  
    <title>Prijava korisnika</title>
    <!-- stylesheets -->
<link rel="stylesheet" href="css/styles.css" type="text/css" media="screen" />
<link rel="stylesheet" href="css/grid.css" type="text/css" media="screen" />
<link rel="stylesheet" href="css/ui/jquery-ui-1.8.13.custom.css" type="text/css" media="screen" />
<link rel="stylesheet" href="css/uniform.default.css" type="text/css" media="screen" />
<link rel="stylesheet" href="css/jquery.noty.css" type="text/css" media="screen" />
    <!-- Jquery -->
<script src="js/jquery-1.6.2.min.js"></script>
<script src="js/jquery-ui-1.8.16.custom.js"></script>

</head>
<body>
 
<div id="login-wrapper">
	<div id="login-header" class="top-round">
		<div class="login-left">
			<span class="icon-wrap-lb-less"><span class="icon-block-black key-tw-b"></span>Korisnička prijava</span>
		</div>
		<div class="login-right">
			<a href="#" title="Admin Panel"><img src="css/images/LogozaadminKlobas1.png" width="142" height="58" alt="Admin Panel" /></a>
		</div>
	</div>

	<div class="login-box bottom-round">
		<form  method="post" id="formLogin" runat="server">  
            <asp:ValidationSummary ID="vsLogin" runat="server" ForeColor="Black" CssClass="notification-error" />  
            <div class="notification-error" id="divPoruka" runat="server" visible="false">
                <ul>
                    <li>                         
                           Unesite ispravne pristupne podatke !                             

                    </li>
                    
                </ul>
            </div>          
			<ul>
				<li><label>Korisničko ime</label><asp:TextBox ID="txtKorisnickoIme" runat="server" CssClass="login-text-box"></asp:TextBox></li>

                <asp:RequiredFieldValidator ID="rfvKorisnickoIme" runat="server" ControlToValidate="txtKorisnickoIme" ErrorMessage="Unesite korisničko ime !" Display="None"></asp:RequiredFieldValidator>
                        <asp:RequiredFieldValidator ID="rfvLozinka" runat="server" ControlToValidate="txtLozinka" ErrorMessage="Unesite lozinku !" Display="None"></asp:RequiredFieldValidator>
				<li><label>Lozinka</label><asp:TextBox ID="txtLozinka" TextMode="Password" runat="server" CssClass="login-text-box usr"></asp:TextBox></li>
                <li>
                    <label>&nbsp;</label>

                     <%-- Persistent Cookie:--%>
                    <span class="rem-check"> <asp:CheckBox ID="cbRememberMe" runat="server" />  </span>
                    <span class="rem-text">Zapamti me </span>
				</li>

				<li><label>&nbsp;</label>
                <asp:Button CssClass="submit-button-login" runat="server" Text="Prijava" OnClick="eventPrijava" ID="Prijava" CausesValidation="True" />
               
                </li>			
			</ul>

		</form>
	</div>            
</div>
    <div id="footer-wrap">
	<div id="footer">
		<div class="login-footer-container">
			 © 2014 Klobas transport. All rights reserved
		</div>
	</div>
</div>
   
</body>
</html>
