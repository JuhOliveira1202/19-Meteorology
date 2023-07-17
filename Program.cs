using System;

class Program
{
    public static void Main(string[] args)
    {
        int n, t; //n = nº dias 

        Console.Write("Qual o número de dias a estudar? ");
        n = Convert.ToInt32(Console.ReadLine());

        int[,] temp = new int[n, 3];

        for (t = 0; t < n; t++)
        {
            Console.Write("Dia: ");
            temp[t, 0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Temp. Máxima: ");
            temp[t, 1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Temp. Mínima: ");
            temp[t, 2] = Convert.ToInt32(Console.ReadLine());

        }
        Console.WriteLine();

        //verificar qual a maior temperatura e em que dia
        int max = 0;

        for (t = 0; t < n; t++)
        {

            if (temp[t, 1] > max)
            {
                max = temp[t, 1];
            }
        }
        Console.WriteLine("A temperatura máxima é " + max);

        for(t= 0; t < n; t++)
        {
            if (temp[t,1] == max)
            {
                Console.WriteLine("A Temp. Máxima registou-se no dia " + temp[t, 0]);
            }
        }
        Console.WriteLine();

        //verificar qual a menor temperatura e em que dia
        int min = 50;

        for(t = 0; t < n; t++)
        {
            if (temp[t, 2] < min)
            {
                min = temp[t, 2];
            }
        }
        Console.WriteLine("A temperatura mínima é " + min);

        for (t = 0; t < n; t++)
        {
            if (temp[t, 2] == min)
            {
                Console.WriteLine("A Temp. Mínima registou-se no dia " + temp[t, 0]);
            }
        }

        Console.WriteLine();

        float soma=0;
        float media;

        for (t = 0; t < n; t++)
        {
            soma += temp[t, 1];
        }

        media = soma / n;
        Console.WriteLine("Temperatura Média Máxima: " + media);

        Console.WriteLine();

        for (t = 0; t < n; t++)
        {
            soma += temp[t, 2];
        }

        media = soma / n;
        Console.WriteLine("Temperatura Média Mínima: " + media);

        Console.WriteLine();

        for (t = 0; t < n; t++)
        {
            soma = temp[t,1] + temp[t,2];
        }

        media = soma / n;
        Console.WriteLine("Temperatura Média: " + media);
    }
}
