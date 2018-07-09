<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="NovostiList.aspx.cs" Inherits="KlobasTransport.Administration.NovostiList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphMain" runat="server">

    <div class="notification-success" id="divPoruka" runat="server" visible="false">
        <ul>
            <li> Novost je uspješno obrisana! </li>
        </ul>
    </div>  

     <div class="widget-top">
		<h4>Pregled novosti </h4>
	</div>

    <div class="widget-content module">
	    <div class="dataTables_wrapper">
            <form runat="server">
               <asp:GridView ID="gridNovosti" runat="server" DataKeyNames="Id" OnRowCommand="gridNovosti_RowCommand" CssClass="display data-table-theme" AutoGenerateColumns="False">
                        
                 <Columns>
                        <asp:BoundField HeaderText="Naslov novosti" DataField="Naslov" />               
                        <asp:BoundField HeaderText="Kratki opis" DataField="KratkiOpis" />
                <%--    <asp:BoundField HeaderText="Dugi  Opis" DataField="DugiOpis" />--%>
                        <asp:BoundField HeaderText="Datum" DataField="Datum" DataFormatString="{0:dd.MM.yyyy.}"/>
                        <asp:ButtonField ButtonType="Button" Text="Izmjeni"  CommandName ="izmjeni" />
                        <asp:ButtonField ButtonType="Button" Text="Briši"  CommandName ="ukloni" />         

                 </Columns>
                    <HeaderStyle BackColor="#FFFFCC" />
               </asp:GridView>
          <br />
            <ul>
              <li>
                  <p>
                        Odaberite za unos nove vijesti.  <br />
                         <asp:Button CssClass="submit-button" runat="server" OnClick="Button1_Click" Text="Dodaj novost" />
                  </p>           
               </li> 
            </ul>                        
    </form>
         </div>
    </div>
</asp:Content>
