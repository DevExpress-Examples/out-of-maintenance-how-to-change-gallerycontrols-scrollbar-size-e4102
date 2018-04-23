Imports Microsoft.VisualBasic
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports System.Drawing

Namespace DxSample.Gallery
	Public Class CustomGalleryViewInfo
		Inherits GalleryControlGalleryViewInfo
		Public Sub New(ByVal gallery As CustomGallery)
			MyBase.New(gallery)
		End Sub

		Protected Overrides Function CalcControlBounds() As Rectangle
			Const controlWidth As Integer = 34
			If IsVertical Then
				Return New Rectangle(ContentBounds.Right - controlWidth, GalleryContentBounds.Y, controlWidth, GalleryContentBounds.Height)
			End If
			Return New Rectangle(GalleryContentBounds.X, ContentBounds.Bottom - controlWidth, GalleryContentBounds.Width, controlWidth)
		End Function
	End Class
End Namespace
