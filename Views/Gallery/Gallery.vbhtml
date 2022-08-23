@Code
    ViewData("Title") = ViewData("PageTitle")
End Code

<!-- Heading Row-->
<div Class="my-3">
    <h3 class="text-center text-white">Gallery Links<img class="my-card-image" src="~/Content/Svg/Links.svg" /></h3>
    <p class="text-center text-light"></p>
</div>

<!-- Back Button -->
<div class="col-md-3 mb-2 my-group-buttons">
    <div class="h-100 text-center text-white">
        <a class="btn btn-danger text-sucess btn-sm my-group-buttons" href="~/Info/About">
            <img class="my-back-button-image" src="~/Content/Svg/backspace.svg"/>
        </a>
    </div>
</div>

<!-- Content Row-->
<div class="row gx-0 gx-lg-5">


    <!-- Column One Card -->
    @Html.Partial("Cards/Gallery/_Pictures")

    <!-- Column Two Card -->
    @Html.Partial("Cards/Gallery/_Videos")

    <!-- Column Three Card -->
    @Html.Partial("Cards/Gallery/_Webart")

</div>

