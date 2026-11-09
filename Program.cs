using System;
using System.Diagnostics;

namespace OrdenacaoTransacoes
{
    class Program
    {
        static void MedirTempo(string nome, Transacao[] array, Action<Transacao[]> algoritmo)
        {
            Stopwatch relogio = Stopwatch.StartNew();

            algoritmo(array);

            relogio.Stop();

            Console.WriteLine($"{nome}: {relogio.Elapsed.TotalMilliseconds:F2} ms");
        }

        static void Main()
        {
            int[] tamanhos =
            {
                100,
                1000,
                10000,
                100000,
                1000000,
                10000000,
                100000000
            };

            foreach (int n in tamanhos)
            {
                Console.WriteLine($"\n========== DATASET: {n:N0} ==========");

                // Gerar transações aleatórias
                Transacao[] original = GeradorTransacoes.Gerar(n);

                // INSERTION SORT
                if (n <= 10000)
                {
                    Transacao[] insertion = (Transacao[])original.Clone();

                    MedirTempo("Insertion Sort", insertion, InsertionSort.Executar);
                }
                else
                {
                    Console.WriteLine("Insertion Sort: não executado (muito lento)");
                }

                // MERGE SORT
                Transacao[] merge = (Transacao[])original.Clone();

                MedirTempo("Merge Sort", merge, MergeSort.Executar);

                // QUICK SORT
                Transacao[] quick = (Transacao[])original.Clone();

                MedirTempo("Quick Sort", quick, QuickSort.Executar);

                // EXIBIR AS 10 MAIORES TRANSAÇÕES
                Console.WriteLine("\n10 maiores transações:");

                for (int i = quick.Length - 1; i >= quick.Length - 10; i--)
                {
                    Console.WriteLine(quick[i]);
                }
            }
        }
    }
}