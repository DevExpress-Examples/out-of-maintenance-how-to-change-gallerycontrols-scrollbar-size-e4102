using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraBars.Ribbon.Gallery;
using System.Drawing;

namespace DxSample.Gallery {
    public class CustomGalleryViewInfo :GalleryControlGalleryViewInfo {
        public CustomGalleryViewInfo(CustomGallery gallery) : base(gallery) { }

        protected override Rectangle CalcControlBounds() {
            const int controlWidth = 34;
            if (IsVertical)
                return new Rectangle(ContentBounds.Right - controlWidth, GalleryContentBounds.Y, controlWidth, GalleryContentBounds.Height);
            return new Rectangle(GalleryContentBounds.X, ContentBounds.Bottom - controlWidth, GalleryContentBounds.Width, controlWidth);
        }
    }
}
