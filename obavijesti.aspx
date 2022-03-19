<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="obavijesti.aspx.cs" Inherits="obavijesti" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <asp:Literal ID="Literal1" runat="server" Text="Obavijesti"></asp:Literal>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Sadrzaj" Runat="Server">
        <div id="middle_content">
		<h1><b>Novosti:</b></h1>
		<div id="obavijest" >
			<asp:TextBox ID="txt_obavijesti" runat="server" Columns="105" Height="320px" 
                ReadOnly="True" TextMode="MultiLine" style="resize:none;" Width="100%"></asp:TextBox>
	

			<asp:TextBox ID="txt_edit" runat="server" Visible="false" Columns="105" 
                Height="320px" TextMode="MultiLine" style="resize:none;" Width="100%"></asp:TextBox>

            <asp:Button ID="btn_edit" runat="server" Text="Objavi" 
                onclick="btn_edit_Click" />
                
		</div>
		
		
	</div>
</asp:Content>
