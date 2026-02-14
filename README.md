# Serialização e Desserialização JSON em C# (.NET)

Este repositório demonstra, de forma prática e objetiva, como **serializar** e **desserializar** objetos em **JSON** no C#, utilizando uma classe de domínio (`Venda`) e a biblioteca **Newtonsoft.Json (Json.NET)**.  
Além disso, o exemplo mostra como **tratar atributos de serialização** para **padronizar nomes de propriedades** no JSON (ex.: integração com sistemas legados, APIs de terceiros ou contratos já definidos).

---

## ✅ Conceitos abordados

### 1) Serialização
**Serialização** é o processo de **converter objetos (C#) em JSON** (texto) para:
- persistir em arquivo (ex.: `.json`)
- enviar via rede (ex.: APIs, filas, mensageria)
- integrar sistemas

No exemplo, uma lista de vendas é convertida em JSON e gravada em arquivo.

### 2) Desserialização
**Desserialização** é o processo inverso: **converter JSON em objetos C#**, permitindo:
- reconstruir entidades a partir de arquivos
- receber payloads de APIs e transformar em modelos
- importar dados externos

No exemplo, um arquivo JSON é lido e transformado novamente em `List<Venda>`.

### 3) Tratamento de atributos (mapeamento de propriedades)
Em integrações reais, o JSON pode vir com nomes diferentes dos nomes usados no código C#.  
Para evitar “gambiarras” e manter **boas práticas**, usamos **atributos** para mapear o nome do campo JSON para a propriedade C#.

Exemplo:
- JSON do cliente: `Produto_da_minha_loja`
- Propriedade do sistema: `Produto`

---

## 🧱 Estrutura de exemplo

### Classe `Venda` com atributos de mapeamento
A classe representa uma venda com:
- `Id`
- `Produto`
- `Preco`
- `DataVenda`

E usa atributos para alterar o nome das propriedades no JSON:

```csharp
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
```

Maximiliano R Pinto
