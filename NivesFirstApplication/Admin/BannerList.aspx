<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="BannerList.aspx.cs" Inherits="KlobasTransport.Administration.BannerList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphMain" runat="server">

    <script type="text/javascript">

        $(document).ready(function () {
            $(".deleteObject").click(function (e) {
                //e.preventdefault();
                //var close = confirm('da li ste sigurni da želite obrisati ovaj baner ?');
                return false;
            });
        });
        
    </script>

    <div class="notification-success" id="divPoruka" runat="server" visible="false">
        <ul>
            <li> Baner je uspješno obrisan! </li>
        </ul>
    </div>  

     <div class="widget-top">
		<h4>Pregled banera </h4>
	</div>
   
    <div class="widget-content module">
			<div class="dataTables_wrapper">
                <form runat="server">
                    <asp:GridView ID="gridBaneri" runat="server" DataKeyNames="Id" OnRowCommand="gridBaneri_RowCommand" CssClass="display data-table-theme" AutoGenerateColumns="False">

                        <Columns>
                            <asp:ImageField HeaderText="Slika" DataImageUrlField="PutanjaSlike" ControlStyle-Width="150"></asp:ImageField>
                            <asp:BoundField HeaderText="Naslov banera" DataField="Naslov" />
                            <asp:BoundField HeaderText="Kratki opis" DataField="KratkiOpis" />
                            <asp:BoundField HeaderText="Link" DataField="Link" />
                            <asp:ButtonField ButtonType="Button" Text="Izmjeni"  CommandName ="izmjeni" />
                            <asp:ButtonField ButtonType="Button" Text="Briši"  CommandName ="ukloni" />
                        </Columns>

                    </asp:GridView>
                    <br />
                    <ul>
                        <li>
                            <p> Odaberite za unos novog banera za objavu: <br />
                             <asp:Button CssClass="submit-button" runat="server" Text="Dodaj baner" OnClick="Unnamed1_Click" ID="btnDodajBaner" CausesValidation="False" />
                            </p>
                        </li>
                    </ul> 
          </form> 
      </div>
        </div>

</asp:Content>
