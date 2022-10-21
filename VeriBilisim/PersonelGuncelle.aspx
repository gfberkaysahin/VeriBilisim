<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="PersonelGuncelle.aspx.cs" Inherits="VeriBilisim.PersonelGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-lg-6 col-md-6 col-sm-12" style="float: none; margin: 2% auto;">
                    <div class="form-group">
                        <div>
                                <strong>
                                    <asp:Label for="TxtId" runat="server" Text="ID: "></asp:Label>
                                </strong>
                                <asp:TextBox ID="TxtId" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <br />
                        <div>
                            <strong>
                                <asp:Label for="TxtAdıSoyadı" runat="server" Text="Adı Soyadı: "></asp:Label>
                            </strong>
                            <asp:TextBox ID="TxtAdıSoyadı" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <br />
                        <div>
                            <strong>
                                <asp:Label for="TxtIlId" runat="server" Text="İl Id: "></asp:Label>
                            </strong>
                            <asp:TextBox ID="TxtIlId" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <br />
                        <div>
                            <strong>
                                <asp:Label for="TxtIlceId" runat="server" Text="İlçe Id: "></asp:Label>
                            </strong>
                            <asp:TextBox ID="TxtIlceId" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <br />
                        <div>
                            <strong>
                                <asp:Label for="TxtCinsiyet" runat="server" Text="Cinsiyet: "></asp:Label>
                            </strong>
                            <asp:TextBox ID="TxtCinsiyet" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <br />
                        <div>
                            <strong>
                                <asp:Label for="TxtDogumTarihi" runat="server" Text="Doğum Tarihi: "></asp:Label>
                            </strong>
                            <asp:TextBox ID="TxtDogumTarihi" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <br />
                        <div>
                            <strong>
                                <asp:Label for="TxtAcıklama" runat="server" Text="Açıklama: "></asp:Label>
                            </strong>
                            <asp:TextBox ID="TxtAcıklama" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-warning" OnClick="Button1_Click" />
                </div>
            </div>
        </div>
    </form>
</asp:Content>
