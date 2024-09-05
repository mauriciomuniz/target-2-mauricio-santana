using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Exercicio3
{
    public void Execute()
    {
        string caminhoArquivo = @"faturamento.json"; 
        string jsonData = File.ReadAllText(caminhoArquivo);
        List<double> faturamentoDiario = JsonConvert.DeserializeObject<List<double>>(jsonData);

        if (faturamentoDiario == null || faturamentoDiario.Count == 0)
        {
            Console.WriteLine("Nenhum dado de faturamento disponível.");
            return;
        }

        double menorFaturamento = double.MaxValue;
        double maiorFaturamento = double.MinValue;
        double somaFaturamento = 0;
        int diasComFaturamento = 0;

        foreach (double valor in faturamentoDiario)
        {
            if (valor > 0)
            {
                if (valor < menorFaturamento)
                {
                    menorFaturamento = valor;
                }

                if (valor > maiorFaturamento)
                {
                    maiorFaturamento = valor;
                }

                somaFaturamento += valor;
                diasComFaturamento++;
            }
        }

        if (diasComFaturamento == 0)
        {
            Console.WriteLine("Não há dias com faturamento.");
            return;
        }

        double mediaMensal = somaFaturamento / diasComFaturamento;

        int diasAcimaDaMedia = 0;
        foreach (double valor in faturamentoDiario)
        {
            if (valor > mediaMensal)
            {
                diasAcimaDaMedia++;
            }
        }

        Console.WriteLine($"Menor valor de faturamento: {menorFaturamento:C}");
        Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento:C}");
        Console.WriteLine($"Número de dias com faturamento acima da média mensal: {diasAcimaDaMedia}");
    }
}
