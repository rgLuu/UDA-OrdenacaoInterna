using System;

namespace OrdenacaoTransacoes
{
    public static class MergeSort
    {
        public static void Executar(Transacao[] array)
        {
            Ordenar(array, 0, array.Length - 1);
        }

        private static void Ordenar(Transacao[] array, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int meio = inicio + (fim - inicio) / 2;

                Ordenar(array, inicio, meio);
                Ordenar(array, meio + 1, fim);

                Merge(array, inicio, meio, fim);
            }
        }

        private static void Merge(Transacao[] array, int inicio, int meio, int fim)
        {
            int n1 = meio - inicio + 1;
            int n2 = fim - meio;

            Transacao[] esquerda = new Transacao[n1];
            Transacao[] direita = new Transacao[n2];

            Array.Copy(array, inicio, esquerda, 0, n1);
            Array.Copy(array, meio + 1, direita, 0, n2);

            int i = 0;
            int j = 0;
            int k = inicio;

            while (i < n1 && j < n2)
            {
                if (esquerda[i].Valor <= direita[j].Valor)
                {
                    array[k] = esquerda[i];
                    i++;
                }
                else
                {
                    array[k] = direita[j];
                    j++;
                }

                k++;
            }

            while (i < n1)
            {
                array[k] = esquerda[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = direita[j];
                j++;
                k++;
            }
        }
    }
}