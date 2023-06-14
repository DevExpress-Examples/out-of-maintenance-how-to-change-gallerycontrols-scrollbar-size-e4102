Imports DevExpress.XtraBars.Ribbon.Gallery
Imports DevExpress.XtraBars.Ribbon.ViewInfo

Namespace DxSample.Gallery

    Public Class CustomGallery
        Inherits GalleryControlGallery

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal galleryControl As CustomGalleryControl)
            MyBase.New(galleryControl)
        End Sub

        Protected Overrides Function CreateViewInfo() As BaseGalleryViewInfo
            Return New CustomGalleryViewInfo(Me)
        End Function
    End Class
End Namespace
