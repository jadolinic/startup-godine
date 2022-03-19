<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Sadrzaj" Runat="Server">
    <div id="middle_content">
        
     

        <h3>Administracijsko sučelje</h3>
      
        <br />
        <br />

        <asp:Label ID="lblError" runat="server" 
            Text="Krivi unos korisnickog imena ili lozinke, pokušajte ponovo!" 
            Visible="False" ForeColor="black" meta:resourcekey="lblErrorResource1"></asp:Label><br />

        <asp:Label ID="lblKorIme" runat="server" Text="Korisničko ime" 
            ForeColor="Black" ></asp:Label>

        <asp:TextBox ID="txtKorIme" runat="server" TabIndex="1"></asp:TextBox>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtKorIme" ForeColor="black" 
            
            Text="Morate unijeti korisničko ime!"></asp:RequiredFieldValidator><br />

        <asp:Label ID="lblLoz" runat="server" Text="Lozinka" ForeColor="Black" 
           ></asp:Label>

        <asp:TextBox ID="txtLoz" runat="server" TextMode="Password" TabIndex="2" 
             ></asp:TextBox>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtLoz" ForeColor="black"            
            Text="Morate unijeti lozinku!"></asp:RequiredFieldValidator>

        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Potvrdi" 
                TabIndex="3" src="images/login_bt.gif" /><br />   

            <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
                SelectCommand="SELECT * FROM [korisnici]"></asp:SqlDataSource>
        </div> 

    </div>


</asp:Content>

