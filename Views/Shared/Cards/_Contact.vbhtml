@code

    Dim siteName As String = SiteHelpers.GetSiteInfo("SiteName")
    Dim siteGoogleMapURL As String = SiteHelpers.GetSiteInfo("SiteGoogleMapURL")
    Dim siteFacebookPageURL As String = SiteHelpers.GetSiteInfo("SiteFacebookPageURL")
    Dim siteContact As String = SiteHelpers.GetSiteInfo("SiteContact")
    Dim siteEmailContact As String = SiteHelpers.GetSiteInfo("SiteEmailContact")
    Dim address1 As String = SiteHelpers.GetSiteInfo("Address1")
    Dim address2 As String = SiteHelpers.GetSiteInfo("Address2")
    Dim phone1 As String = SiteHelpers.GetSiteInfo("Phone1")

    ' Page Images
    Dim smallLogo = SiteHelpers.GetSiteInfo("SmallLogo")

End Code

<div class="text-center p-0">

    <!-- Contact Info box -->
    <div class="card mx-auto text-dark border-dark m-0 p-0 rounded-0" style="max-width: 24rem;">        
        <div class="card-body border-0 m-0 p-0">

            <!-- Our Church -->
            <div class="ourChurch-box border-bottom border-dark px-0 py-2">
                <a href="http://apnazarene.org/" class="nav-link text-decoration-underline" target="_blank"><img class="medlogo" src="~/Content/Catagories/Svg/Cross-White.svg" />Our Church
                </a>
                <p>is filled with<br />caring and loving people.</p>
            </div>

            <!-- Please Contact Us -->
            <h2 class="px-0 pb-2 pt-2" style="color: #265039; font-size: 36px; font-weight: 600; text-shadow: .5px 0px 0px black;">Please Contact Us</h2>

            <!--  Need Help -->
            <p>If you need to reach someone for prayer,<br />or more information about us,<br />please email or call:</p>

            <!-- Quick Contact Info -->
            <div class="pb-1 border-bottom">
                <h5>@phone1 <br /><a class="text-black" style="font-size: 18px;" href="mailto: @siteEmailContact">@siteEmailContact</a></h5>

                <!-- We're Ready!-->
                <div class="pt-1 pb-1" style="color: #265039; text-shadow: .5px 0px 0px black; font-size: 20px; font-weight: 600;">We're ready to assist<br />on your spiritual journey.</div>

            </div>                               

            <!-- Contacts -->
            <div class="ourChurch-box border-bottom border-top border-dark" style="color: #265039; background-color: #84CBA0; text-shadow: .30px .30px 0 black; ">
                <div class="ms-5 mb-1 ps-5 pt-3">
                    <div class="card-title text-start fw-bold p-0">Lead Pastor:</div>
                    <h5 class="card-title text-start fw-bolder pb-2">Curt Napier</h5>

                    <div class="card-title text-start fw-bold p-0">Associate Pastor:</div>
                    <h5 class="card-title text-start fw-bolder pb-2">Patricia Bridewell</h5>

                    <div class="card-text text-start">
                        <p>@address1<br />@address2</p>
                    </div>
                </div>
            </div>            

            <!-- Buttons -->
            <div class="pt-1 border-top">

                <!-- Facebook Page Button -->
                <div class="py-1">
                    <button style="border: none; background-color: transparent; width: 200px; border-radius:8px; padding-left: 20px;text-align: left;" onclick="newTab('@siteFacebookPageURL')">
                        <img style="height:32px; width:32px;" src="~/Content/Catagories/Svg/FB-Square.Svg" /> <b>Facebook Page</b>
                    </button>
                </div>

                <!-- Google Page Button -->
                <div class="py-1">
                    <button style="border: none; background-color: transparent; width: 200px; border-radius: 8px; padding-left: 20px; text-align: left;" onclick="newTab('@siteGoogleMapURL')">
                        <img style="height:32px; width:32px;" src="~/Content/Catagories/Svg/Google-Square.svg" /> <b>Google Maps</b>
                    </button>
                </div>

            </div>

            <!-- Salutations -->
            <h2 class="pt-1 pb-2" style="font-size: 36px; font-weight:600; text-shadow: .5px .5px 0 black; color: #265039;">
                <img class="medlogo" src="~/Content/Catagories/Svg/Bird-Bible-Black.svg" /> God bless you!
            </h2>

        </div>
    </div>
</div>