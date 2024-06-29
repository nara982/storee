<%@ Page Title="" Language="C#" MasterPageFile="Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="f23_store.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
     <asp:Repeater ID="rep" runat="server" OnItemCommand="rep_ItemCommand">

        <HeaderTemplate>
            <div class="row">
                <div class="col-md-12">
                    <div class="titlepade">
                        <h1 style="text-align: center;margin-bottom:50px;font-size:400%;"> Our products </h1>
                    </div>
                </div>
            </div>
            <div class="row">
        </HeaderTemplate>
        <ItemTemplate>
            <div class="protien">
                <img src="<%# Eval("image")%>" alt="#" width="250px" />
                <h3><%# Eval("name")%> </h3>
                <h3><%# Eval("price")%> </h3>
                
                <a class="read_more mar_top" href="webForm2.aspx?id=<%# Eval("Id")%>">read more</a> 
             </div>

        </ItemTemplate>
        <FooterTemplate>
            </div>
            
        </FooterTemplate>
       
    </asp:Repeater>
    
</asp:Content>

