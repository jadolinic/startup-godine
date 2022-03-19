<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="multimedija.aspx.cs" Inherits="multimedija" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <asp:Literal ID="Literal1" runat="server" Text="Multimedija"></asp:Literal>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Sadrzaj" Runat="Server">
    <div id="middle_content">
			<div id="container">
		<div id="example">
			
			<div id="slides">
				<div class="slides_container">
					<div class="slide">
						<img src="img/slide-1.jpg" width="" height="" alt="Svjetski kup kanada"/>
						
					</div>
                    <div class="slide">
						<img src="img/slide-2.png" width="" height="" alt="Svjetsko juniorsko" />
						
					</div>
					
					<div class="slide">
						<img src="img/slide-3.jpg" width="" height="" alt="Svjetsko juniorsko" />
						
					</div>
					<div class="slide">
						<img src="img/slide-4.jpg" width="" height="" alt="Svjetski kup"/>
						
					</div>
					<div class="slide">
						<img src="img/slide-5.jpg" width="" height="" alt="Trening"/>
						
					</div>
					<div class="slide">
						<img src="img/slide-6.jpg" width="" height="" alt="Trening"/>
				
					</div>
					
				</div>
				<a href="#" class="prev"/><img src="img/arrow-prev.png" width="24" height="43" alt="Arrow Prev"/>
				<a href="#" class="next"/><img src="img/arrow-next.png" width="24" height="43" alt="Arrow Next"/>
			</div>
			
		</div>
		
	</div>
		</div>
</asp:Content>

