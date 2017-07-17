using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Product_Info { get; set; }

        public virtual ICollection<Image> Image_Ids { get; set; }

        public Product()
        {
            Image_Ids = new List<Image>();
        }
    }
}
