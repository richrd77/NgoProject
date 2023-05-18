<%@ Page Title="About" Language="C#" MasterPageFile="~/Ngo.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="NgoProject.About" %>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    
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
    <img src="images/image1_1.jpg" alt="Cinque Terre" width="600" height="400">
</div>

<div class="gallery">
    <img src="images/image1_2.jpg" alt="Forest" width="600" height="400">
</div>

<div class="gallery">
    <img src="images/image1_3.jpg" alt="Northern Lights" width="600" height="400">
</div>

<div class="gallery">
    <img src="images/image1_4.jpg" alt="Mountains" width="600" height="400">
</div>
<br />
    <br />
    <div class="row jumbotron" style="padding: 2rem 1rem;
    margin-bottom: 2rem;
    background-color: #e9ecef;
    border-radius: 0.3rem;">
        <div class="col-md-8">
            <div class="abut-detail">
                <h2>ABOUT US</h2>
                <p>Non-governmental organizations, or NGOs, were first called such in Article 71 in the Charter of the newly formed United Nations in 1945. While NGOs have no fixed or formal definition, they are generally defined as nonprofit entities independent of governmental influence (although they may receive government funding).</p>

                <p>As one can tell from the basic definition above, the difference between nonprofit organizations (NPOs) and NGOs is slim. However, the term "NGO" is not typically applied to U.S.-based nonprofit organizations. Generally, the NGO label is given to organizations operating on an international level although some countries classify their own civil society groups as NGOs</p>

                <p>NGO activities include, but are not limited to, environmental, social, advocacy and human rights work. They can work to promote social or political change on a broad scale or very locally. NGOs play a critical part in developing society, improving communities, and promoting citizen participation. </p>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <h3>Rs.500</h3>
                    <p>Raised by your help</p>
                </div>
                <div class="col-md-4">
                    <h3>Rs.1000</h3>
                    <p>Immediate Need</p>
                </div>
                <div class="col-md-4">
                    <h3>Rs.5000</h3>
                    <p>Our initial target</p>
                </div>
            </div>
        </div>
        <%--<div class="col-md-4">
            <img src="/images/about-us.jpg" width="100%" />
        </div>--%>
    </div>
</asp:Content>
