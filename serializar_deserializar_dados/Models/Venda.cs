using System.Text.Json.Serialization;

public class Venda
{
    public int Id { get; set; }
    [JsonPropertyName("Produto_da_minha_loja")]
    public string Produto { get; set; }
    [JsonPropertyName("Preco_Barato")]
    public decimal Preco { get; set; }
    public DateTime DataVenda { get; set; }

    public Venda(int id, string produto, decimal preco, DateTime dataVenda)
    {
        Id = id;
        Produto = produto;
        Preco = preco;
        DataVenda = dataVenda;
    }

}