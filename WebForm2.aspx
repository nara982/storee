<%@ Page Title="" Language="C#" MasterPageFile="Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="f23_store.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <asp:Repeater ID="rep" runat="server" OnItemCommand="rep_ItemCommand">
        <HeaderTemplate>
            <h1>Description</h1>
   
        </HeaderTemplate>
        <ItemTemplate>
            <div style="height:300px; width:700px; border-width: 0px;">
                <div style="height:300px; width:200px; border-style:solid ;border-width :1px; float:left; ">
                    <img src ="<%# Eval("image") %> "heigh="300px" width="200px" />
                </div>
                <div style="height :300px; width: 395px; border-style :solid ;border-width :1px; float:left;">
                    product name : <%# Eval("name") %><br/> Description :  <%# Eval("desc") %><br/>
                    price :  <%# Eval("price") %><br/>
                </div>
            </div>

        </ItemTemplate>
          <FooterTemplate>
             
            </FooterTemplate>
    </asp:Repeater>

    <asp:Button ID="addtocart" runat="server" Height="47px" OnClick="addtocart_Click" Text="add to cart" Width="204px" />
    <br />
</asp:Content>
