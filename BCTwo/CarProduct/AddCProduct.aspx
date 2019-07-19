<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddCProduct.aspx.cs" Inherits="BCTwo.CarProduct.AddCProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div>
            <h2 style="text-align: center;">新增租賃車相關資料</h2>
            <hr />
            <form runat="server" id="f1">
                <div class="row">
                    <div class="form-group">
                        <label class="control-label col-md-2" style="font-size: 18px; text-align: right;">車輛名稱</label>
                        <div class="col-md-5">
                            <asp:TextBox ID="txtName" runat="server" CssClass="form-control" />
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="form-group">
                        <label class="control-label col-md-2" style="font-size: 18px; text-align: right;">品牌分類</label>
                        <div class="col-md-5">
                            <asp:DropDownList ID="DList1" runat="server" CssClass="form-control">
                                <asp:ListItem>請選擇品牌</asp:ListItem>
                                <asp:ListItem Value="1">Mitsubishi</asp:ListItem>
                                <asp:ListItem Value="2">Nissan</asp:ListItem>
                                <asp:ListItem Value="3">Ford</asp:ListItem>
                                <asp:ListItem Value="4">Toyota</asp:ListItem>
                                <asp:ListItem Value="5">Honda</asp:ListItem>
                                <asp:ListItem Value="6">Luxgen</asp:ListItem>
                                <asp:ListItem Value="7">菱利</asp:ListItem>
                                <asp:ListItem Value="8">得利卡</asp:ListItem>
                                <asp:ListItem Value="9">堅達</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="form-group">
                        <label class="control-label col-md-2" style="font-size: 18px; text-align: right;">排氣量</label>
                        <div class="col-md-5">
                            <asp:TextBox ID="txtCate" runat="server" CssClass="form-control" />
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="form-group">
                        <label class="control-label col-md-2" style="font-size: 18px; text-align: right;">車種分類</label>
                        <div class="col-md-5">
                            <asp:DropDownList ID="DList2" runat="server" CssClass="form-control">
                                <asp:ListItem>請選擇車種類型</asp:ListItem>
                                <asp:ListItem Value="1">客轎車</asp:ListItem>
                                <asp:ListItem Value="2">休旅車</asp:ListItem>
                                <asp:ListItem Value="3">貨車</asp:ListItem>
                                <asp:ListItem Value="4">小巴士</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="form-group">
                        <label class="control-label col-md-2" style="font-size: 18px; text-align: right;">乘座人數</label>
                        <div class="col-md-5">
                            <asp:DropDownList ID="DList3" runat="server" CssClass="form-control">
                                <asp:ListItem>請選擇乘坐人數</asp:ListItem>
                                <asp:ListItem Value="1">5人</asp:ListItem>
                                <asp:ListItem Value="2">6人</asp:ListItem>
                                <asp:ListItem Value="3">7人</asp:ListItem>
                                <asp:ListItem Value="4">9人</asp:ListItem>
                                <asp:ListItem Value="5">20人</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="form-group">
                        <label class="control-label col-md-2" style="font-size: 18px; text-align: right;">車輛庫存</label>
                        <div class="col-md-5">
                            <asp:TextBox ID="txtStock" runat="server" CssClass="form-control" />
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="form-group">
                        <label class="control-label col-md-2" style="font-size: 18px; text-align: right;">租賃價錢</label>
                        <div class="col-md-5">
                            <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" />
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="form-group">
                        <label class="control-label col-md-2" style="font-size: 18px; text-align: right;">產品圖片</label>
                        <div class="col-md-5">
                            <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="True" CssClass="file-path validate" />
                            <asp:Label ID="Label1" runat="server" Text="" />
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="form-group">
                        <label class="control-label col-md-2" style="font-size: 18px; text-align: right;">產品說明</label>
                        <div class="col-md-5">
                            <asp:TextBox ID="txtDesc" runat="server" CssClass="form-control" TextMode="MultiLine" />
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="form-group">
                        <div class="col-md-3">
                            <asp:Button ID="btnAdd" runat="server" Text="確定送出" CssClass="btn btn-primary" OnClick="btnAdd_Click" />
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
