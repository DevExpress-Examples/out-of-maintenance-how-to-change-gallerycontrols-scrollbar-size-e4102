<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128616211/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4102)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomGallery.cs](./CS/DxSample/Gallery/CustomGallery.cs) (VB: [CustomGallery.vb](./VB/DxSample/Gallery/CustomGallery.vb))
* [CustomGalleryControl.cs](./CS/DxSample/Gallery/CustomGalleryControl.cs) (VB: [CustomGalleryControl.vb](./VB/DxSample/Gallery/CustomGalleryControl.vb))
* [CustomGalleryViewInfo.cs](./CS/DxSample/Gallery/CustomGalleryViewInfo.cs) (VB: [CustomGalleryViewInfo.vb](./VB/DxSample/Gallery/CustomGalleryViewInfo.vb))
<!-- default file list end -->
# How to change GalleryControl's scrollbar size


<p>Unlike other WinForms controls, our <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraBarsRibbonGalleryControltopic"><u>GalleryControl</u></a> has a fixed scrollbar width. If the default scrollbar width is not acceptable due to the application design, it is possible to create a custom GalleryControl component and change the default scrollbar size by overriding the CalcControlBounds method in the GalleryControlGalleryViewInfo class. This method should return a rectangle that will be used as scroll bar bounds.</p>

<br/>


