<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="EditBanner.aspx.cs" Inherits="KlobasTransport.Administration.EditBanner" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">

    <div class="notification-success" id="divPoruka" runat="server" visible="false">
        <ul>
             <li id="liPoruka" runat="server">  </li>
        </ul>
    </div>

    <div class="widget-top">
        <h4>Unos banera za objavu</h4>
    </div>

      <div class="widget-content module">
        <div class="form-grid">

            <form id="form"  runat="server" class="leftLabel">
      <ul>
          <li>
               <asp:Label CssClass="fldTitle"  ID="lblNaslov" runat="server" AssociatedControlID="txtNaslov" Text="Naslov:"></asp:Label>
               <div class="filedwrap">
                <asp:TextBox runat="server" ID="txtNaslov" CssClass="large textips"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNaslov" runat="server" ControlToValidate="txtNaslov" Display="Dynamic" ErrorMessage="Nije unesen naslov!" ForeColor="Red"></asp:RequiredFieldValidator>
               </div>
          </li>
          <li>
                <asp:Label  CssClass="fldTitle" ID="lblPutanja" runat="server" Text="Putanja slike"></asp:Label>
              <div class="filedwrap">                 
                  <asp:FileUpload runat="server" ID="fuImage" ValidateRequestMode="Disabled"/>
              </div>    
              <asp:Image ID="imgContentImage" runat="server"  Width="300"/>  
             
              <span class="img-pre">
                  <asp:LinkButton ID ="btnUploadImage" runat="server" OnClick="btnUploadImage_Click" CausesValidation="false" ToolTip="Učitaj sliku"></asp:LinkButton>                  
                </span>

              <span class="img-del">
                  <asp:LinkButton ID ="btnRemoveImage" runat="server" OnClick="btnRemoveImage_Click" CausesValidation="false" ToolTip="Obriši učitanu sliku"></asp:LinkButton>
              </span>
              <br />

              <asp:Label runat="server" title="Napomena"> Slika u aplikaciji nije prirodne veličine za objavu </asp:Label>
             </li>            
          <li>
               <asp:Label  CssClass="fldTitle"  ID="lblKratkiOpis" runat="server" AssociatedControlID="txtKratkiOpis" Text="Kratki opis:"></asp:Label>
              <div class="filedwrap">
                <asp:TextBox ID="txtKratkiOpis" runat="server" CssClass="large textips"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvKratkiOpis" runat="server" ControlToValidate="txtKratkiOpis" Display="Dynamic" ErrorMessage="Nije unesen kratki opis!" ForeColor="Red"></asp:RequiredFieldValidator>
              </div>

          </li>
          <li>
               <asp:Label  CssClass="fldTitle"  ID="lblLink" runat="server" AssociatedControlID="txtLink" Text="Link na sadržaj:"></asp:Label>
             <div class="filedwrap">
                    <asp:TextBox ID="txtLink" runat="server" Wrap="False" CssClass="large textips"></asp:TextBox>    
             </div>
         </li>

          <li>
             <div class="filedwrap">
               <asp:Button  CssClass="submit-button" ID="btnSpremi" runat="server" OnClick="btnSpremi_Click" Text="Spremi" />
                <asp:Button  CssClass="submit-button" ID="btnPonisti" runat="server" Text="Odustani i idi na listu" OnClick="btnPonisti_Click" CausesValidation="False" />
             </div>

             </li>         

      </ul>                       
             </form>
        </div>
     </div>

</asp:Content>
