using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevPro.Inventory.Tests
{
    [TestClass()]
    public class InventoryManagerTests
    {
        private const string products = "{\"products\":[" +
                                        "{\"name\": \"Product A\", \"price\": 100, \"stock\": 5}," +
                                        "{\"name\": \"Product B\", \"price\": 200, \"stock\": 3}," +
                                        "{\"name\": \"Product C\", \"price\": 50, \"stock\": 10}" +
                                        "]}";

        private const string SortedByNameAscending = "[" +
                                        "{\"name\":\"Product A\",\"price\":100,\"stock\":5}," +
                                        "{\"name\":\"Product B\",\"price\":200,\"stock\":3}," +
                                        "{\"name\":\"Product C\",\"price\":50,\"stock\":10}" +
                                        "]";

        private const string SortedByNameDescending = "[" +
                                       "{\"name\":\"Product C\",\"price\":50,\"stock\":10}," +
                                       "{\"name\":\"Product B\",\"price\":200,\"stock\":3}," +
                                       "{\"name\":\"Product A\",\"price\":100,\"stock\":5}" +
                                       "]";

        private const string SortedByPriceAscending = "[" +
                                        "{\"name\":\"Product C\",\"price\":50,\"stock\":10}," +
                                        "{\"name\":\"Product A\",\"price\":100,\"stock\":5}," +
                                        "{\"name\":\"Product B\",\"price\":200,\"stock\":3}" +
                                       "]";

        private const string SortedByStockDescending = "[" +
                                        "{\"name\":\"Product C\",\"price\":50,\"stock\":10}," +
                                        "{\"name\":\"Product A\",\"price\":100,\"stock\":5}," +
                                        "{\"name\":\"Product B\",\"price\":200,\"stock\":3}" +
                                       "]";


        private InventoryManager inventoryManager;

        [TestInitialize]
        public void TestInitialize()
        {
            this.inventoryManager = new InventoryManager();
        }

        [TestMethod()]
        public void SortProductsByNameAscending()
        {
            var sortedProducts = inventoryManager.SortProducts(products, "name", true);

            Assert.AreEqual(SortedByNameAscending, sortedProducts);
        }

        [TestMethod()]
        public void SortProductsByNameDescending()
        {
            var sortedProducts = inventoryManager.SortProducts(products, "name", false);

            Assert.AreEqual(SortedByNameDescending, sortedProducts);
        }

        [TestMethod()]
        public void SortProductsByPriceAscending()
        {
            var sortedProducts = inventoryManager.SortProducts(products, "price", true);

            Assert.AreEqual(SortedByPriceAscending, sortedProducts);
        }

        [TestMethod()]
        public void SortProductsByStockDescending()
        {
            var sortedProducts = inventoryManager.SortProducts(products, "stock", false);

            Assert.AreEqual(SortedByStockDescending, sortedProducts);
        }
    }
}