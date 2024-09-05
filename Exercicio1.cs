using System;

public class Exercicio1
{
    public void Execute()
    {
        int INDICE = 13, SOMA = 0, K = 0;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine(SOMA);
    }
}
