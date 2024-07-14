using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonTaskHW
{
    public class CarGallery
    {
        public CarGallery(string galleryName, List<Car> carsList)
        {
            GalleryName = galleryName;
            Cars = carsList;
        }

        public string GalleryName { get; set; }
        public List<Car> Cars { get; set; }
        public override string ToString()
        {
            //return string.Join(", ", Cars);
            return $"{GalleryName}: {string.Join(", ", Cars)}";
        }
    }
}
