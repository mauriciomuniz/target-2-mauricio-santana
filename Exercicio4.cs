using System;
using System.Collections.Generic;

public class Exercicio4
{
    public void Execute()
    {
      Dictionary<string, double> faturamentoPorEstado = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

        double valorTotal = 0;
        foreach (var valor in faturamentoPorEstado.Values)
        {
            valorTotal += valor;
        }

        Console.WriteLine("Percentual de representação de cada estado:");

        foreach (var estado in faturamentoPorEstado)
        {
            double percentual = (estado.Value / valorTotal) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }
    }
}
