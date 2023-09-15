using System;   
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonDoMilhao;
internal class Static
{
    private const int NOME_MANUAL_1_ORDER = 0;// tabelaChinesFixa[0] = "Order No"
    private const int NOME_MANUAL_2_COLOR = 3;// tabelaChinesFixa[3] = "Order No"

    private const int REFERENCE_TABELA_LINEITEM_NAME = 2;// tabelaChinesFixa[2] = "Lineitem name"
    private const int REFERENCE_TABELA_SKU = 15;// tabelaChinesFixa[15] = "Product Link" (SKU)

    public static string[]? LinesArray { get; set; }
    public static List<References>? References { get; set; }

    public static string GeraCSV()
    {
        if (LinesArray == null || LinesArray.Length == 0)
            return string.Empty;

        string[][]? items = GeraTabelaConvertida();
        if (items == null) return string.Empty;

        if (References != null)
            items = CorrigeURL_SKU_Nome_ASIN(items);

        return ConvertToCsvFormat(items);
    }

    private static string ConvertToCsvFormat(string[][]? items)
    {
        if (items == null) return string.Empty;
        if (items.Length < 1) return string.Empty;

        string result = string.Empty;

        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null) continue;
            for (int j = 0; j < items[0].Length; j++)
            {
                if (j != 0) 
                    result += ",";

                result += items[i][j];
            }
            result += "\n";
        }

        return result;
    }

    private static string[][]? CorrigeURL_SKU_Nome_ASIN(string[][] items)
    {
        if (items.Length < 1) return items;

        for (int i = 0; i < items.Length; i++)
        {
            if (i == 0) continue;
            if (items[i] == null) continue;

            var itemConverted = ConvertToURL(items[i][REFERENCE_TABELA_SKU], items[i][REFERENCE_TABELA_LINEITEM_NAME]);

            items[i][REFERENCE_TABELA_SKU] = itemConverted.url;
            items[i][REFERENCE_TABELA_LINEITEM_NAME] = itemConverted.nome;
        }

        return items;
    }

    private static (string url, string nome) ConvertToURL(string sku, string nome)
    {
        string url = sku;

        if (References == null) return (url, nome);

        foreach(var reference in References)
        {
            if (string.IsNullOrEmpty(sku)) continue;

            if (sku != reference.SKU) continue;
            
            url = reference.URL;
            nome = reference.Nome;
            break;
        }

        return (url, nome);
    }

    private static string[][]? GeraTabelaConvertida()
    {
        if (LinesArray == null || LinesArray.Length == 0)
            return null;

        string[][] itemArray = new string[LinesArray.Length][];

        string[][] convertedArray = new string[LinesArray.Length][];
        convertedArray[0] = tabelaChinesFixa;

        for (int i = 0; i < LinesArray.Length; i++)
        {
            itemArray[i] = LinesArray[i].Split('\t');
        }

        int[] indexTabelaChinesFixa = GetTabelaChinesIndex(itemArray[0]);

        for (int i = 0; i < LinesArray.Length; i++)
        {
            if (i == 0) continue; //0 == cabeçalho
            for (int j = 0; j < tabelaChinesFixa.Length; j++)
            {
                if (itemArray[i].Length < itemArray[0].Length) continue;

                if (convertedArray[i] == null)
                    convertedArray[i] = new string[tabelaChinesFixa.Length];

                convertedArray[i][j] = string.Empty;
                if (j == NOME_MANUAL_1_ORDER || j == NOME_MANUAL_2_COLOR) continue; //itens que vai preencher na mão


                var item = itemArray[i][indexTabelaChinesFixa[j]];
                convertedArray[i][j] = Util.RemoveAccent(item);
            }
        }

        return convertedArray;
    }

    private static int[] GetTabelaChinesIndex(string[] headerArray)
    {
        var indexTabelaChinesFixa = new int[tabelaChinesFixa.Length];

        for (int i = 0; i < headerArray.Length; i++)
        {
            for (int j = 0; j < tabelaChinesFixa.Length; j++)
            {
                if (headerArray[i] == ConversorDeNomeChinesParaAmazon(tabelaChinesFixa[j]))
                    indexTabelaChinesFixa[j] = i;
            }
        }

        return indexTabelaChinesFixa;
    }

    private static string ConversorDeNomeChinesParaAmazon(string nomeDaAmazon)
    {
        switch (nomeDaAmazon)
        {
            case "Order No": return ""; // preenchido manualmente
            case "Lineitem quantity": return "quantity-purchased";
            case "Lineitem name": return "product-name";
            case "Lineitem color": return ""; // preenchido manualmente
            case "Shipping Name": return "recipient-name";
            case "Shipping Street": return "ship-address-1";
            case "Shipping Address1": return "ship-address-2";
            case "Shipping Address2": return "delivery-Instructions";
            case "Shipping Company/CPF": return "cpf";
            case "Shipping City": return "ship-city";
            case "Shipping Zip": return "ship-postal-code";
            case "Shipping Province": return "ship-state";
            case "Shipping Country": return "ship-country";
            case "Shipping Phone": return "ship-phone-number";
            case "Phone": return "ship-phone-number";
            case "Product link": return "sku";
            default: return "";
        }
    }

    private static string[] tabelaChinesFixa => new string[] 
    {
      "Order No",            
      "Lineitem quantity",   
      "Lineitem name",       
      "Lineitem color",      
      "Shipping Name",       
      "Shipping Street",     
      "Shipping Address1",   
      "Shipping Address2",   
      "Shipping Company/CPF",
      "Shipping City",       
      "Shipping Zip",        
      "Shipping Province",   
      "Shipping Country",    
      "Shipping Phone",      
      "Phone",               
      "Product link",          
    };

}
