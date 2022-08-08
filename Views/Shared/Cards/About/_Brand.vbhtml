@code
    ' Get Image Info
    Dim mybiglogo As String = SiteHelpers.GetSiteInfo("mybiglogo")
End Code

<div class="col-lg-5 pb-3">

    <!-- My Big Logo -->
    <div class="card h-100 bg-transparent my-no-border" style="background-color: transparent;">
        <div class="card-body text-center py-0">
            
            <!-- Show  my Big Logo -->
            <img src=@mybiglogo class="img-fluid my-big-logo border-0" alt="Responsive My Big Logo" />
                        
        </div>
    </div>

    <!-- Site Description -->
    <div class="my-card text-white my-0 px-3 pt-2 pb-0 border border-2 border-dark shadow" style="background-color: #4a4b4c;">
        <div class="my-card-body lh-sm" style="background-color: #4a4b4c;">
            <p class="text-white m-0 py-1">WHO ARE WE?</p>
            <p class="text-white m-0 py-2">Our congregation is a family, part of the global family of people called Nazarenes, who, in turn, are part of the Body of Christ Universal.</p>
            <p class="text-white m-0 py-2">We invite you to worship and learn with us.</p>
        </div>
    </div>

</div>
