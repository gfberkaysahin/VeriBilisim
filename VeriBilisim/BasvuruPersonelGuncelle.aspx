<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="BasvuruPersonelGuncelle.aspx.cs" Inherits="VeriBilisim.BasvuruPersonelGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-lg-6 col-md-6 col-sm-12" style="float: none; margin: 1% auto;">
                    <div class="form-group">
                        <div>
                            <strong>
                                <asp:Label for="TxtPersonelId" runat="server" Text="Personel Id: "></asp:Label>
                            </strong>
                            <asp:TextBox ID="TxtPersonelId" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <br />
                        
                        <div>
                            <strong>
                                <asp:Label for="TxtBasvuruTarihi" runat="server" Text="Başvuru Tarihi: "></asp:Label>
                            </strong>
                            <asp:TextBox ID="TxtBasvuruTarihi" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <br />
                        <div>
                            <strong>
                                <asp:Label for="TxtIlID" runat="server" Text="İl ID: "></asp:Label>
                            </strong>
                            <asp:TextBox ID="TxtIlID" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <br />
                        <div>
                            <strong>
                                <asp:Label for="TxtSeyahatEngeliYok" runat="server" Text="Seyahat Engeli: "></asp:Label>
                            </strong>
                            <asp:TextBox ID="TxtSeyahatEngeliYok" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <br />
                        <div>
                            <strong>
                                <asp:Label for="TxtIsYeriAdi" runat="server" Text="İş Yeri Adı: "></asp:Label>
                            </strong>
                            <asp:TextBox ID="TxtIsYeriAdi" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <br />
                        <div>
                            <strong>
                                <asp:Label for="TxtPozisyon" runat="server" Text="Pozisyon: "></asp:Label>
                            </strong>
                            <asp:TextBox ID="TxtPozisyon" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <br />
                        <div>
                            <strong>
                                <asp:Label for="TxtAciklama" runat="server" Text="Açıklama: "></asp:Label>
                            </strong>
                            <asp:TextBox ID="TxtAciklama" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    
                    <asp:Button ID="Button1" runat="server" Text="Ekle" CssClass="btn btn-warning" OnClick="Button1_Click"/>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
