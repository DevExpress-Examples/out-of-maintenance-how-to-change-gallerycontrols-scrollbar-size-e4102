using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace DxSample.Gallery {
    public class CustomGallery :GalleryControlGallery {
        public CustomGallery() : base() { }
        public CustomGallery(CustomGalleryControl galleryControl) : base(galleryControl) { }

        protected override BaseGalleryViewInfo CreateViewInfo() {
            return new CustomGalleryViewInfo(this);
        }
    }
}
