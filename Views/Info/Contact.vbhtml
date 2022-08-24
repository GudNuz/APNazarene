@Code
    ViewData("Title") = ViewData("PageTitle")
End Code

<!-- Container -->
<div Class="container px-0 px-sm-0 px-md-4 px-lg-4 px-xl-4 my-0 my-sm-0 my-md-4 my-lg-4 my-xl-4">

    <!-- Content Row-->
    <div class="row gx-0 gx-med-3 gx-lg-5 gx-xl-5 gx-xxl-5">

        <!-- Located at: [Views - Shared] - Cards - Contact - "_OurChurch" Card -->
        @Html.Partial("Cards/Contact/_OurChurch")

        <!-- Located at: [Views - Shared] - Cards - Contact - "_ContactUs" Card -->
        @Html.Partial("Cards/Contact/_ContactUs")

        <!-- Located at: [Views - Shared] - Cards - Contact - "_Salutations" Card -->
        @Html.Partial("Cards/Contact/_Salutations")

    </div>
</div>


<!-- Container - Jesus Fish -->
<div Class="container px-4 my-4 ">

    <!-- Content Row -->
    <div class="row gx-0 gx-lg-5 py-sm-0 py-md-0 pt-lg-4 pt-xl-4 pb-sm-0 pb-md-3 pb-lg-2 pb-xl-2">

        <!-- Container Box -->
        <div class="my-card h-100 text-center">
            <img class="my-jesus-fish" src="~/Content/Svg/Jesus-Fish-White.svg" />
        </div>

    </div>

</div>


