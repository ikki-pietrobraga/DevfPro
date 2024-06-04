using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevPro.Inventory
{
    public class InventoryManager
    {
        private RootModel DeserializeProducts(string products)
        {
            return JsonConvert.DeserializeObject<RootModel>(products);
        }

        private List<ProductModel> SortByName(RootModel root, bool ascending = true)
        {
            if (ascending)
            {
                return  root.Products.OrderBy(p => p.Name).ToList();
            }
            else
            {
                return root.Products.OrderByDescending(p => p.Name).ToList();
            }
        }

        private List<ProductModel> SortByPrice(RootModel root, bool ascending)
        {
            if (ascending)
            {
                return root.Products.OrderBy(p => p.Price).ToList();
            }
            else
            {
                return root.Products.OrderByDescending(p => p.Price).ToList();
            }
        }

        private List<ProductModel> SortByStock(RootModel root, bool ascending)
        {
            if (ascending)
            {
                return root.Products.OrderBy(p => p.Stock).ToList();
            }
            else
            {
                return root.Products.OrderByDescending(p => p.Stock).ToList();
            }
        }

        private string SerializeProducts(List<ProductModel> products)
        {
            return JsonConvert.SerializeObject(products);
        }

        public string SortProducts(string products, string sortKey, bool ascending = true)
        {
            var productList = DeserializeProducts(products);

            switch (sortKey.ToUpper())
            {
                case "NAME":
                    return SerializeProducts(SortByName(productList, ascending));
                case "STOCK":
                    return SerializeProducts(SortByStock(productList, ascending));
                case "PRICE":
                    return SerializeProducts(SortByPrice(productList, ascending));
                default:
                    throw new ArgumentException();
            }
        }
  
    }
}
