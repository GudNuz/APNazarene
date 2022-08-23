@Code
    ViewData("Title") = ViewData("PageTitle")
End Code

<!-- Container -->
<div Class="container px-sm-2 px-md-3 px-lg-3 px-xl-3">

    <!-- Content Row - Heading -->
    <div Class="row gx-4 gx-lg-5 align-items-end mb-auto pb-sm-1 pb-md-1 pb-lg-0">

        <!-- Brand and description -->
        @Html.Partial("Cards/About/_Brand")

        <!-- Welcome Video -->
        @Html.Partial("Cards/About/_WelcomeVideo")

    </div>

    <!-- Content Row - Cards -->
    <div class="row gx-sm-1 gx-md-3 gx-lg-5 gx-xl-5">

        <!-- Card Columns -->

        <!-- Online Worship Card -->
        @Html.Partial("Cards/About/_OnlineWorship")

        <!-- Calandar Card -->
        @Html.Partial("Cards/About/_Calendar")

        <!-- Members Card -->
        @Html.Partial("Cards/About/_Members")

    </div>

    <!--Content Row - Jesus Fish -->
    <div class="row gx-1 gx-lg-5">

        <!-- Column Container -->
        <div class="container col-md-4 mb-4 lh-sm pb-sm-0 pb-md-0 pb-lg-2">

            <!-- Container Box -->
            <div class="my-card h-100 text-center">
                <img class="my-jesus-fish" src="~/Content/Svg/Jesus-Fish-White.svg" />
            </div>

        </div>

    </div>

</div>
