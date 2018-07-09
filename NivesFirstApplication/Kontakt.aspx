<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Kontakt.aspx.cs" Inherits="KlobasTransport.Kontakt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphMain" runat="server">

    <div class="list">
        <div class="item list2">

            <h3>Kontaktirajte nas</h3>

            <div class="formKontakt">

                <asp:Literal ID="litMessages" runat="server"></asp:Literal> 
                <asp:ValidationSummary runat="server" ID="vsKontakt" CssClass="notification-error" />
            </div>

            <div class="sdescription">
				<p>Duis et rhoncus eros.Suspendisse sollicitudin massa et eleifend sollicitudin. Suspendisse et varius enim. Nullam dui dui, ultrices sed convallis eu, placerat eu sapien. Morbi et facilisis sapien.</p>
			</div>

			<div class="clear"></div>
        </div>

        <div class="item list2">

            <div class="form" id="queryForm" runat="server">
                <h3> Kontakt obrazac:</h3>
                <p>Polja označena zvjezdicom <span class="obavezno">(*)</span> molimo obvezno ispuniti.</p>
                <fieldset class="fieldset">
                    
                    <p class="name">
                        <asp:Label ID="lblIme" runat="server" Text="Ime:" AssociatedControlID="txtIme">Ime: <span class="obavezno">*</span></asp:Label>  
                        <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ID="rfvIme" ControlToValidate="txtIme" ErrorMessage="Molimo Vas upišite Vaše ime" 
                            Display="None"></asp:RequiredFieldValidator>
					</p>
                    <p class="prezime">
                        <asp:Label ID="lblPrezime" runat="server" Text="Prezime:" AssociatedControlID="txtPrezime">Prezme:  <span class="obavezno">* </span></asp:Label>  
                        <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ID="rfvPrezime" ControlToValidate="txtPrezime" ErrorMessage="Molimo Vas upišite Vaše prezime" 
                            Display="None"></asp:RequiredFieldValidator>
					</p>
                    <p class="email">
						<asp:Label ID="lblEmail" runat="server" Text="E-mail:" AssociatedControlID="txtEmail"> E-mail: <span class="obavezno">* </span> </asp:Label>  
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator runat="server" ID="rfvEmail" ControlToValidate="txtEmail" ErrorMessage="Molimo Vas upišite Vašu e-mail adresu"
                              Display="None"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator runat="server" ID="revEmail" ControlToValidate="txtEmail" ErrorMessage="Molimo Vas upišite ispravnu e-mail adresu"
                            Display="None" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
					</p>
					<p class="phone">
						<asp:Label ID="lblPhone" runat="server" Text="Telefon:" AssociatedControlID="txtPhone">Telefon:  <span class="obavezno">* </span></asp:Label>  
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
					</p>
					<p class="text">
                        <asp:Label ID="lblPoruka" runat="server" Text="Poruka:" AssociatedControlID="txtPoruka">Poruka: <span class="obavezno">* </span></asp:Label>  
                        <asp:TextBox ID="txtPoruka" runat="server" TextMode="MultiLine" Columns="5" Rows="8"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ID="rfvPoruka" ControlToValidate="txtPoruka" ErrorMessage="Vaša poruka?" Display="None"></asp:RequiredFieldValidator>
					</p>

                    <div class="buttonPosition"> 
						<label>
                            <input type="reset" value="Obriši" class="delete" />
						</label> 
                            
						<label>
                            <asp:Button ID="btnSend" runat="server" Text="Pošalji" CssClass="submit" OnClick="btnSend_Click" />
						</label>

					</div>

                </fieldset>
            </div>
            <div id="mapa">
				<div class="item">
					<h4>Naša lokacija: </h4>
				</div>
				<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d44864.952966495344!2d14.426816299999999!3d45.34760995!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4764a12517aabe2d%3A0x373c6f383dcbb670!2sRijeka!5e0!3m2!1sen!2s!4v1402892794850"></iframe>
			</div>

            <div class="clear"></div>
        </div>

    </div>
</asp:Content>
