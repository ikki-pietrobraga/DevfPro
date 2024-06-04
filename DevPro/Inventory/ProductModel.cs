using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevPro.Inventory
{ 
    public class ProductModel
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "price")]
        public int Price { get; set; }

        [JsonProperty(PropertyName = "stock")]
        public int Stock { get; set; }
    }
}
