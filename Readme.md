<!-- default file list -->
*Files to look at*:

* [CustomGallery.cs](./CS/DxSample/Gallery/CustomGallery.cs) (VB: [CustomGalleryViewInfo.vb](./VB/DxSample/Gallery/CustomGalleryViewInfo.vb))
* [CustomGalleryControl.cs](./CS/DxSample/Gallery/CustomGalleryControl.cs) (VB: [CustomGalleryControl.vb](./VB/DxSample/Gallery/CustomGalleryControl.vb))
* [CustomGalleryViewInfo.cs](./CS/DxSample/Gallery/CustomGalleryViewInfo.cs) (VB: [CustomGalleryViewInfo.vb](./VB/DxSample/Gallery/CustomGalleryViewInfo.vb))
<!-- default file list end -->
# How to change GalleryControl's scrollbar size


<p>Unlike other WinForms controls, our <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraBarsRibbonGalleryControltopic"><u>GalleryControl</u></a> has a fixed scrollbar width. If the default scrollbar width is not acceptable due to the application design, it is possible to create a custom GalleryControl component and change the default scrollbar size by overriding the CalcControlBounds method in the GalleryControlGalleryViewInfo class. This method should return a rectangle that will be used as scroll bar bounds.</p>

<br/>


