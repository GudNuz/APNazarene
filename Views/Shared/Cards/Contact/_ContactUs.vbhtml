@code
    
    Dim siteEmailContact As String = "apnazarene@apnazarene.org"
    Dim phone1 As String = "863-453-4851"
 
    Dim siteGoogleMapURL As String = "https://www.google.com/maps/place/Avon+Park+Church+of+the+Nazarene/@27.5953222,-81.5091936,15z/data=!4m5!3m4!1s0x0:0x3b2af50abe7f8f95!8m2!3d27.5953222!4d-81.5091936"
    Dim siteFacebookPageURL As String = "https://www.facebook.com/APNazarene/"
    
End Code 


<!-- Column Container -->
<div class="container col-sm-12 col-md-12 col-lg-4 mb-sm-0 mb-md-4 mb-lg-4 mb-xl-4 lh-sm pt-0">

    <div class=" my-card text-white my-0 pt-3 border border-1 border-dark shadow" style="background-color: white;">
        <div class="my-card-body lh-sm text-center pt-2" style="background-color: white; color:black;">

            <!-- Contact Box -->
            <div class="text-center">

                <!-- Please Contact Us -->
                <h2 class="px-0 pt-2" style="color: #4a4b4c; font-size: 36px; font-weight: 600; text-shadow: .5px 0px 0px black;">Please Contact Us</h2>

                <!-- Need Help -->
                <p style="padding: 0; font-weight:600;">If you need to reach someone for prayer,<br />or more information about us,<br />please email or call:</p>

                <!-- Quick Contact Info -->
                <div class="px-0 pt-1">
                    <h5><a class="text-black fw-bold" style="font-size: 18px;" href="mailto: @siteEmailContact">@siteEmailContact</a><br />@phone1</h5>

                    <!-- We're Ready! -->
                    <div class="pt-1 pb-2" style="color: #4a4b4c; text-shadow: .5px 0px 0px black; font-size: 20px; font-weight: 600;">We're ready to assist<br />on your spiritual journey.</div>

                </div>

                <!-- Contacts* -->
                <div class="my-card-body m-0 text-start " style="background-color: #8E774D; text-shadow: .25px .25px 0 black; ">

                    <!-- Pastors -->
                    <div class="pt-3 pb-2 text-center">

                        <img class="my-contact" src="~/Content/Svg/Contact-Us.svg" />

                    </div>

                    <!-- Buttons -->
                    <div class="pt-0 pb-2 text-center">

                        <!-- Facebook Page Button -->
                        <div class="pt-1">
                            <button style="border: none; background-color: transparent; width: 200px; border-radius:8px; padding-left: 20px;text-align: left;" onclick="newTab('@siteFacebookPageURL')">
                                <img style="height:32px; width:32px;" src="~/Content/Svg/FB-Square.Svg" /> <b>Facebook Page</b>
                            </button>
                        </div>

                        <!--Google Page Button -->
                        <div class="py-1">
                            <button style="border: none; background-color: transparent; width: 200px; border-radius: 8px; padding-left: 20px; text-align: left;" onclick="newTab('@siteGoogleMapURL')">
                                <img style="height:32px; width:32px;" src="~/Content/Svg/Google-Square.svg" /> <b>Google Maps</b>
                            </button>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>