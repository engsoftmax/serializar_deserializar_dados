// Apenas para exemplificar a serialização e deserialização de dados usando JSON em C#.   
// Serialização!


using Newtonsoft.Json;


List<Venda> listaDeVendas = new List<Venda>();
DateTime data1 = DateTime.Parse("2025-04-20 15:40");
DateTime data2 = DateTime.Parse("2025-04-21 10:32");


Venda v1 = new Venda(1, "Notebook", 3500.00m, data1);
Venda v2 = new Venda(2, "Smartphone", 1500.00m, data2);

listaDeVendas.Add(v1);
listaDeVendas.Add(v2);

string serializarJson = JsonConvert.SerializeObject(listaDeVendas, Formatting.Indented);
File.WriteAllText("dadosvenda.json", serializarJson);

Console.WriteLine("Objeto serializado para JSON:");
Console.WriteLine(serializarJson);


// Deserialização!
//Fora o método de deserialização, foi realizado o tratamento de atributos para se adequar ao código de boas práticas.
string LerJson = File.ReadAllText("dadosvendaAImportarDoCliente.json");
List<Venda> listaDeVendasDeserializada = JsonConvert.DeserializeObject<List<Venda>>(LerJson);

foreach (Venda venda in listaDeVendasDeserializada)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data da Venda: {venda.DataVenda}");
}