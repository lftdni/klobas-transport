<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" ValidateRequest="false" AutoEventWireup="true" CodeBehind="~/Admin/EditNovosti.aspx.cs" Inherits="KlobasTransport.Administration.EditNovosti" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphMain" runat="server">
    
    <div class="notification-success" id="divPoruka" runat="server" visible="false">
        <ul>
            <li id="liPoruka" runat="server">  </li>
        </ul>
    </div>
     
    <div class="widget-top">
        <h4>Unos novosti za objavu </h4>
    </div>
        
    <div class="widget-content module">
        <div class="form-grid">
            
   <form id="form"  runat="server" class="leftLabel">
       <ul>
           <li>
               <asp:Label  CssClass="fldTitle"  ID="lblNaslov" runat="server" AssociatedControlID="txtNaslov" Text="Naslov"></asp:Label>
                <div class="fieldwrap">
                    <asp:TextBox CssClass="large textips" ID="txtNaslov" runat="server" Wrap="False"></asp:TextBox>
                    <asp:RequiredFieldValidator   ID="rfvNaslov" runat="server" ControlToValidate="txtNaslov" Display="Dynamic" ErrorMessage="Naslov novosti je obavezan!" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
          </li>
       
           <li>
               <asp:Label  CssClass="fldTitle"  ID="lblKratkiO" runat="server" AssociatedControlID="txtKratkiO" Text="Kratki Opis"></asp:Label>
                <div class="fieldwrap">
                    <asp:TextBox CssClass="large textips" ID="txtKratkiO" runat="server" Wrap="False"></asp:TextBox>
                    <asp:RequiredFieldValidator   ID="rfvKratkiO" runat="server" ControlToValidate="txtKratkiO"  Display="Dynamic" ErrorMessage="Nije unesen kratki opis!" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
           </li>
          
           <li>
                <asp:Label  CssClass="fldTitle"  ID="lblDugiO" runat="server" Text="Dugi Opis" AssociatedControlID="txtDugiO"></asp:Label>
                <div class="fieldwrap">
                    <asp:TextBox CssClass="large tinymce-simple" ID="txtDugiO" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
           </li>
         
           <li>
               <asp:Label  CssClass="fldTitle"  ID="lblDatum" runat="server" Text="Datum" AssociatedControlID="txtDatum"></asp:Label>
                <div class="fieldwrap">
                    <asp:TextBox  ID="txtDatum" runat="server" CssClass="datepicker"></asp:TextBox>
                    <asp:RequiredFieldValidator  ID="rfvDatum" runat="server" ControlToValidate="txtDatum"  Display="Dynamic" ErrorMessage="Nije unesen datum!" ForeColor="Red">  </asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvDatum" runat="server" ControlToValidate="txtDatum" Display="None" ErrorMessage="Datum nije ispravan" MaximumValue="01.01.2099" MinimumValue="01.01.1900" Type="Date"></asp:RangeValidator>
                </div>
           </li>
           <li>
                  <asp:Button CssClass="submit-button" ID="btnPotvrdi" runat="server" OnClick="Button1_Click" Text="Potvrdi" />
                  <asp:Button CssClass="submit-button" ID="Button2" CausesValidation="false" runat="server" OnClick="Button2_Click" Text="Odustani i idi na listu" />
           </li>          
                 
       </ul>
     </form>
   </div>
        </div>
</asp:Content>
