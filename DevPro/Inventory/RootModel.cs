using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevPro.Inventory
{
    public class RootModel
    {
        [JsonProperty(PropertyName = "products")]
        public List<ProductModel> Products { get; set; }

    }
}
