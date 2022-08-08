@Code
    ' Get Title and Site Name
    ViewData("Title") = ViewData("Message")
End Code

<div Class="container px-4 px-lg-5">

    <!-- Heading Row-->
    <div Class="row gx-4 gx-lg-5 align-items-end mb-auto pb-1">

        <!-- Brand and description -->
        @Html.Partial("Cards/About/_Brand")

        <!-- About Video -->
        @Html.Partial("_AboutVideo")

    </div>

    <!-- Content Row-->
    <div class="row gx-1 gx-lg-5">

        <!-- Online Worship Card -->
        @Html.Partial("Cards/About/_OnlineWorship")

        <!-- Calandar Card -->
        @Html.Partial("Cards/About/_Calendar")

        <!-- Members Card -->
        @Html.Partial("Cards/About/_Members")

    </div>

    <!--SVG File -->
    <div class="row gx-1 gx-lg-5">

        <!-- Column Container -->
        <div class="container col-md-4 mb-4 lh-sm">

            <!-- Container Box -->
            <div class="my-card h-100 text-center">
                <img style="width: 300px;" src="~/Content/Catagories/Svg/Jesus-Fish-White.svg" />
            </div>

        </div>

    </div>

</div>
