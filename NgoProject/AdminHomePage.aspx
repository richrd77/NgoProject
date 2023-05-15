<%@ Page Title="Admin" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHomePage.aspx.cs" Inherits="NgoProject.AdminHomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <h1 style="text-align: center;"> Welcome Administrator</h1>
    
    <link media="all" rel="stylesheet" href="css/all.css">

    <link href="https://www.jqueryscript.net/css/jquerysctipttop.css" rel="stylesheet" type="text/css">
    <style>
        .lead {
            text-align: center;
        }
    </style>
<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="js/slider.js"></script>
    <div class="widget">

        <ul class="slideset">
            <li class="active">
                <img src="images/image5.jpg" style="height: 250px;" alt="" />
                <div class="description">
                    <strong>NGO</strong>
                    <p>A Non-Governmental Organisation (NGO) is a non-profitable charitable organisation. In India, NGOs established under Section 8 of the Companies Act are governed by the provisions of the Companies Act, 2013, while the NGOs established as a trust or society are governed by the state governments. 
                        <br />
All NGOs work for the betterment of society and to help people in need. Since NGOs are non-profitable organisations, they need to raise funds to earn money for doing their work. This article provides how to get funds for NGOs in India.</p>
                </div>
            </li>
            <li>
                <img src="images/image1.jpg" style="height: 250px;" alt="" />
                <div class="description">
                    <strong>Fund raise</strong>
                    <p>Ways to Raise Funds for NGOs
Raising funds through events.
Network fundraising.
Personal solicitation.
Online fundraising.
Volunteering.
Periodic donation through the adoption of a project.
Raising money from young people and in schools.
Donations in kind.
Collections.
Corporate partnerships.
Product sales.
Crowdfunding.
Raising money from corporates under CSR.
Raising money under government schemes.
Fundraising from social media.
Fundraising from abroad, in the case of NGOs holding FCRA (Foreign Contribution Regulation Act) certificate.</p>
                </div>
            </li>
            <li>
                <img src="images/image2.jpg" style="height: 250px;" alt="" />
                <div class="description">
                    <strong>NGO Funding</strong>
                    <p>NGO funding is done by getting membership fees, selling goods and services, grants from other charitable foundations, state governments, municipal and private donors, donations from affluent individuals, etc. Despite their autonomy, many NGOs depend substantially on government subsidies and money for funds. Some government financing for NGOs could be considered contentious since it may promote political aims instead of a nation’s development.</p>
                </div>
            </li>
            <li>
                <img src="images/image4.jpg" style="height: 250px;" alt="" />
                <div class="description">
                    <strong>NGO Donations</strong>
                    <p>Donations made to NGOs are deductible under Section 80G of the Income Tax Act, 1961. NGOs must register under Section 80G and obtain the 80G certificate. When individuals or organisations contribute to an NGO, having a Section 80G certificate, the contributions are deductible up to 50% of their taxable income.</p>
                </div>
            </li>
            <%--<li>
                <img src="images/image5.jpg" alt="" />
                <div class="description">
                    <strong>Internet Explorer</strong>
                    <p>Quisque sollicitudin nisi vitae turpis imperdiet interdum. Nam quis erat vehicula libero fringilla tempus. Sed neque urna, egestas sit amet dapibus nec, viverra ut sem. Nunc ut tellus diam. Ut sed fringilla lacus. Phasellus ac nisl id neque porttitor faucibus vel ut lorem. Aenean quam odio, porta ut vestibulum sit amet, scelerisque quis libero. Nunc gravida pharetra libero, id malesuada nisl ultricies sed.</p>
                </div>
            </li>--%>
        </ul>
        <div class="control-links">
            <a class="btn-prev" href="#">&lt;</a>
            <div class="switcher-holder">
                <ul class="switcher">
                    <li><a href="#">NGO</a></li>
                    <li><a href="#">Fund Raise</a></li>
                    <li><a href="#">Funding</a></li>
                    <li><a href="#">Tax deduction</a></li>
                    <%--<li><a href="#">Members</a></li>--%>
                </ul>
            </div>
            <a class="btn-next" href="#">&gt;</a>
        </div>

    </div>
</asp:Content>
