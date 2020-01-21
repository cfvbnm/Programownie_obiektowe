using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Magazyn
{
    public class Product
    {
        public string _name { get; set; }
        public int _amount { get; set; }
        public double _total { get; set; }
        public Product(string name, int amount, double total)
        {
            _name = name;
            _amount = amount;
            _total = total;
        }
    }
    static class productserializer
    {
        public static void serializeproduct(IEnumerable<Product> product, string filename)
        {
            File.WriteAllText(@filename, JsonConvert.SerializeObject(product, Formatting.Indented));
        }
        public static List<Product> deserializeproduct(string filename)
        {
            var json = File.ReadAllText(@filename);
            var products = JsonConvert.DeserializeObject<List<Product>>(json);
            return products;

        }
    }
}
