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

<!-- Column Container -->
<div class="container mb-lg-3 col-md-4 lh-sm text-center p-0">

    <!-- Contact Info box -->
    <div class="my-card mx-auto p-0 border border-2 border-dark shadow-lg" style="max-width: 24rem;">
        <div class="my-card-body p-0">

            <!-- Our Church -->
            <div class="my-box-church px-0 py-2">
                <a href="http://apnazarene.org/" class="nav-link text-decoration-underline" target="_blank">
                    <img class="my-med-logo" src="~/Content/Catagories/Svg/Cross-White.svg" />Our Church
                </a>
                <p class="card-text" style="font-size: 18px; font-weight: 500;">is filled with<br />caring and loving people.</p>
            </div>

            <!-- Please Contact Us -->
            <h2 class="px-0 pt-2" style="color: #4a4b4c; font-size: 36px; font-weight: 600; text-shadow: .5px 0px 0px black;">Please Contact Us</h2>

            <!-- Need Help -->
            <p style="padding: 0; font-weight:600;">If you need to reach someone for prayer,<br />or more information about us,<br />please email or call:</p>

            <!-- Quick Contact Info -->
            <div class="p-0">
                <h5><a class="text-black fw-bold" style="font-size: 18px;" href="mailto: @siteEmailContact">@siteEmailContact</a><br />@phone1</h5>

                <!-- We're Ready! -->
                <div class="pt-1 pb-2" style="color: #4a4b4c; text-shadow: .5px 0px 0px black; font-size: 20px; font-weight: 600;">We're ready to assist<br />on your spiritual journey.</div>

            </div>

            <!-- Contacts* -->
            <div class="my-box-church" style="background-color: #8E774D; text-shadow: .25px .25px 0 black; ">

                <!-- Pastors -->
                <div class="ms-5 mb-0 ps-5 pt-3">
                    <div class="card-title text-dark text-start fw-bold p-0">Lead Pastor:</div>
                    <h5 class="card-title text-white text-start fw-bolder pb-2">Curt Napier</h5>

                    <div class="card-title text-dark text-start fw-bold p-0">Associate Pastor:</div>
                    <h5 class="card-title text-white text-start fw-bolder pb-2">Patricia Bridewell</h5>
                </div>

                <!-- Address -->
                <div class="ms-5 mb-1 ps-3 pt-1">
                    <div class="card-text text-dark text-start">
                        <h6 style="font-size: 18px; font-weight: 500;">@address1<br />@address2</h6>
                    </div>
                </div>

                <!-- Buttons -->
                <div class="pt-0 pb-2">

                    <!-- Facebook Page Button -->
                    <div class="pt-1">
                        <button style="border: none; background-color: transparent; width: 200px; border-radius:8px; padding-left: 20px;text-align: left;" onclick="newTab('@siteFacebookPageURL')">
                            <img style="height:32px; width:32px;" src="~/Content/Catagories/Svg/FB-Square.Svg" /> <b>Facebook Page</b>
                        </button>
                    </div>

                    <!--Google Page Button -->
                    <div class="py-1">
                        <button style="border: none; background-color: transparent; width: 200px; border-radius: 8px; padding-left: 20px; text-align: left;" onclick="newTab('@siteGoogleMapURL')">
                            <img style="height:32px; width:32px;" src="~/Content/Catagories/Svg/Google-Square.svg" /> <b>Google Maps</b>
                        </button>
                    </div>

                </div>
                
            </div>            

            <!--Seal -->
            <div class="h-100 w-100 py-2">
                <img class="img-fluid my-big-logo" src="~/Content/Catagories/Svg/Seal-English-Gold.svg" />
            </div>

            <!--Salutations -->
            <h2 class="py-1 mb-0" style="color: #231F20; font-size: 36px; font-weight: 600; text-shadow: .5px 0px 0px black; ">
                <img class="my-med-logo" style="padding-bottom:5px;" src="~/Content/Catagories/Svg/Bird-Bible-Black.svg" /> God bless you!
            </h2>

        </div>
    </div>   

</div>


