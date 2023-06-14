Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Gallery

Namespace DxSample.Gallery

    Public Class CustomGalleryControl
        Inherits GalleryControl

        Protected Overrides Function CreateGallery() As GalleryControlGallery
            Return New CustomGallery(Me)
        End Function
    End Class
End Namespace
