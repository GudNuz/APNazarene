@code
    ' Get Image Info
    Dim mybiglogo As String = SiteHelpers.GetSiteInfo("mybiglogo")
End Code

<div class="col-lg-5 pb-3">

    <!-- My Big Logo (and Site Name) -->
    <div class="card h-100 bg-transparent noborder" style="background-color: transparent;">
        <div class="card-body text-center pt-2">
            
            <!-- Show  my Big Logo -->
            <img src=@mybiglogo class="img-fluid my-big-logo" alt="Responsive My Big Logo" />
                        
        </div>
    </div>

    <!-- Site Description -->
    <div class="my-card text-white my-0 py-0 border border-dark shadow" style="background-color: #4a4b4c;">
        <div class="card-body lh-sm">
            <p class="text-white m-0 py-1">WHO ARE WE?</p>
            <p class="text-white m-0 py-2">Our congregation is a family, part of the global family of people called Nazarenes, who, in turn, are part of the Body of Christ Universal. We invite you to worship and learn with us.
            </p>
        </div>
    </div>

</div>
