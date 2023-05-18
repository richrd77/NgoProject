<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Ngo.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="NgoProject.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    
<style>
div.gallery {margin: 5px;
    border: 1px solid #ccc;
    float: left;
    width: 300px;
    /* height: 300px; */
    margin-top: 50px;
}

div.gallery:hover {
  border: 1px solid #777;
}

div.gallery img {
  width: 100%;
  height: 200px;
}

div.desc {
  padding: 15px;
  text-align: center;
}
</style>

<div class="gallery">
    <img src="images/image1_5.jpg" alt="Cinque Terre" width="600" height="400">
</div>

<div class="gallery">
    <img src="images/image1_6.jpg" alt="Forest" width="600" height="400">
</div>

<div class="gallery">
    <img src="images/image1_7.jpg" alt="Northern Lights" width="600" height="400">
</div>

<div class="gallery">
    <img src="images/image1_8.jpg" alt="Mountains" width="600" height="400">
</div>
<br />
    <br />
    <div class="jumbotron" style="padding: 2rem 1rem;
    margin-bottom: 2rem;
    background-color: #e9ecef;
    border-radius: 0.3rem;">

        <p style="padding: 2px;">
            <h2>CONTACT US</h2>
        </p>
        <p style="padding: 2px;">
            AMIT SINGHRAJ WELFARE & CHARITABLE TRUST(ASWCT)
        </p>
        <p style="padding: 2px;">
            <i class="fas fa-map-marker-alt" style="margin-right: 5px;"></i>C.O: #B/1116,11th Floor Mittal Tower,Mg Road,Bangalore,Karnataka - 560001
        <br />
            Reg. Offc.: Y-Axis Institute Campus, Trimuhani, Shahganj, VIP Road Benta, Darbhanga, Bihar – 846003
        </p>
        <p style="padding: 2px;">
            <i class="fas fa-mobile-alt" style="margin-right: 5px;"></i>+91 - 9507977671
                        
        </p>
    </div>
</asp:Content>
