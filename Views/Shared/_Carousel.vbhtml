﻿@code
    Dim altText As String = ViewData("PageHeader")
    Dim folder As String = ViewData("Message")
    Dim imgCount As Integer = SiteHelpers.ImageCount(folder, ".jpg")
    Dim imageLocation As String = SiteHelpers.GetImageLocation() + folder + "/"

End Code

<!-- Carousel for Picture slides -->
<div id="my-carousel-control" class="carousel slide py-2" data-bs-ride="carousel">

    <!-- The slideshow -->
    <div class="carousel-inner shadow" id="CarouselItems"></div>

    <!-- Left And right controls -->
    <a class="carousel-control-prev" href="#my-carousel-control" role="button" data-bs-slide="prev"></a>
    <a class="carousel-control-next" href="#my-carousel-control" role="button" data-bs-slide="next"></a>

</div>

<script type="text/javascript">

    /* Create the Carousel Picture List */
    createImageList("@imageLocation", "@altText", @imgCount);

</script>

<script type="text/javascript">

    $('#Previous').click(function (e) {
        e.stopPropagation();
        $('#my-carousel-control').carousel('prev');
        return false;
    });

    $('#Next').click(function (e) {
        e.stopPropagation();
        $('#my-carousel-control').carousel('next');
        return false;
    });

</script>