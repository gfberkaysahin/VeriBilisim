<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="BasvuruPersonelListesi.aspx.cs" Inherits="VeriBilisim.BasvuruPersonelListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-lg-12 col-md-6 col-sm-12" style="float: none; margin: 5% auto;">
                <div class="form-group">
                    <table class="table table-bordered table-hover">
                        <tr>
                            <th>Personel ID</th>
                            <th>Başvuru Tarihi</th>
                            <th>İl</th>
                            <th>Seyehat Engeli Yok</th>
                            <th>İş Yeri Adı</th>
                            <th>Pozisyon</th>
                            <th>Açıklama</th>
                            <th>İşlemler</th>
                        </tr>
                        <tbody>
                            <asp:Repeater ID="rp1" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%#Eval("ID")%></td>
                                        <td><%#Eval("BASVURUTARIHI")%></td>
                                        <td><%#Eval("ADI")%></td>
                                        <td><%#Eval("SEYAHATENGELIYOK")%></td>
                                        <td><%#Eval("ISYERIADI")%></td>
                                        <td><%#Eval("POZISYON")%></td>
                                        <td><%#Eval("ACIKLAMA")%></td>
                                        <td>
                                            <asp:HyperLink NavigateUrl='<%# "~/BasvuruPersonelSil.aspx?ID="+Eval("ID") %>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                                            <asp:HyperLink NavigateUrl='<%# "~/BasvuruPersonelGuncelle.aspx?ID="+Eval("ID") %>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
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
