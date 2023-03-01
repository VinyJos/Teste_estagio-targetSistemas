using System;
using System.IO;
using Newtonsoft.Json;
using Test03;

string dadosDoarquivo = File.ReadAllText(@"./Dados/dados.json");

List<Faturamento> listaFaturamento = JsonConvert.DeserializeObject<List<Faturamento>>(dadosDoarquivo);

decimal maiorValor = listaFaturamento.Max(f => f.Valor);
int diaMax = listaFaturamento.First(f => f.Valor == maiorValor).Dia;

decimal menorValor = listaFaturamento.Where(f => f.Valor != 0).Min(f => f.Valor);
int diaMin = listaFaturamento.First(f => f.Valor == menorValor).Dia;

decimal media = listaFaturamento.Where(f => f.Valor != 0).Average(f => f.Valor);

var dias = new List<int>();
int contDia = 0;
foreach (Faturamento item in listaFaturamento)
{
    if (item.Valor > media)
    {
        contDia += 1;
        dias.Add(item.Dia);
    }


}


Console.WriteLine($"Maior valor faturado : R$ {maiorValor} dia {diaMax}");
Console.WriteLine($"Menor valor faturado : R$ {menorValor} dia {diaMin}");
Console.WriteLine($"O mês teve {contDia} dias em que o valor foi maior que a média do mês,\n" +
                    $"sendo os dias {string.Join(", ", dias)}");



