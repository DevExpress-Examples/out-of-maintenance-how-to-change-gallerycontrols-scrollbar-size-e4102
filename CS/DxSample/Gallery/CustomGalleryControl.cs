using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;

namespace DxSample.Gallery {
    public class CustomGalleryControl :GalleryControl {
        protected override GalleryControlGallery CreateGallery() {
            return new CustomGallery(this);
        }
    }
}
