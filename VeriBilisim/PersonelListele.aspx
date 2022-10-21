<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="PersonelListele.aspx.cs" Inherits="VeriBilisim.PersonelListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-lg-12 col-md-6 col-sm-12" style="float: none; margin: 5% auto;">
                <div class="form-group">
                    <table class="table table-bordered table-hover">
                        <tr>
                            <th>ID</th>
                            <th>Personel Adı Soyadı</th>
                            <th>İl</th>
                            <th>İlçe</th>
                            <th>Cinsiyet</th>
                            <th>Doğum Tarihi</th>
                            <th>Açıklama</th>
                            <th>İşlemler</th>
                        </tr>
                        <tbody>
                            <asp:Repeater ID="rp1" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%#Eval("ID")%></td>
                                        <td><%#Eval("ADISOYADI")%></td>
                                        <td><%#Eval("ADI")%></td>
                                        <td><%#Eval("ILCEADI")%></td>
                                        <td><%#Eval("CINSIYET")%></td>
                                        <td><%#Eval("DOGUMTARIHI")%></td>
                                        <td><%#Eval("ACIKLAMA")%></td>
                                        <td>
                                            <asp:HyperLink NavigateUrl='<%# "~/PersonelSil.aspx?ID="+Eval("ID") %>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                                            <asp:HyperLink NavigateUrl='<%# "~/PersonelGuncelle.aspx?ID="+Eval("ID") %>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
