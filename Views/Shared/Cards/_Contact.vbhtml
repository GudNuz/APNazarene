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

<div class="text-center py-0">

    <!-- Please Contact us Text -->
    @*<div class="pt-4">
        <h3 class="font-weight-bold">Contact Us</h3>
    </div>*@

    <!-- Contact Info box -->
    <div class="card mx-auto border-dark mb-3" style="max-width: 24rem;">
        <div class="card-header w-100 text-center bg-secondary">
            <h5>
                <img class="smalllogo fw-bold" src=@smallLogo alt="brand logo"><a href="http://apnazarene.org/" class="nav-link site-logo active text-white" target="_blank"> @siteName</a>
            </h5>
        </div>
        <div class="card-body text-dark">
            <div class="text-left pb-2">

                <h3 class="px-0 py-2">Our Church is filled with<br />caring and loving people.</h3>
                <h2 class="px-0 pb-2">Please Contact Us</h2>

                <p>For more information about us,<br />or if you need to reach someone for prayer,<br />please email or call:</p>
                
                <!-- Quick Contact Info -->
                <div class=" pb-2">
                    <h5>@phone1 <br/><a class="text-black" style="font-size: 18px;" href="mailto: @siteEmailContact">@siteEmailContact</a></h5>                   
                </div>

                <p>We're ready to assist on your spiritual journey.</p>

            </div>  

            <!-- Salutations -->
            <h3 class="pt-2 pb-3 text-secondary">God bless you!</h3>

            <!-- Contacts -->
            <div class="px-5">
                <div class="card-title text-start fw-bold p-0">Lead Pastor:</div>
                <h5 class="card-title text-start fw-bolder pb-2">Curt Napier</h5>

                <div class="card-title text-start fw-bold p-0">Associate Pastor:</div>
                <h5 class="card-title text-start fw-bolder pb-2">Patricia Bridewell</h5>

                <div class="card-text text-start">
                    <p>@address1<br />@address2</p>
                </div>
            </div>
            

            <!-- Buttons -->
            <div class="py-2">

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
        </div>
    </div>
</div>