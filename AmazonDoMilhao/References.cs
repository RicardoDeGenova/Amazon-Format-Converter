using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonDoMilhao;
internal class References
{
    public string Nome { get; set; }
    public string ASIN { get; set; }
    public string SKU { get; set; }
    public string URL { get; set; }

    public References(string nome, string asin, string sku, string url)
    {
        Nome = nome;
        ASIN = asin;
        SKU = sku;
        URL = url;
    }
}
