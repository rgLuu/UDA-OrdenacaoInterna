namespace OrdenacaoTransacoes
{
    public static class QuickSort
    {
        public static void Executar(Transacao[] array)
        {
            Ordenar(array, 0, array.Length - 1);
        }

        private static void Ordenar(Transacao[] array, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int pivo = Particionar(array, inicio, fim);

                Ordenar(array, inicio, pivo - 1);
                Ordenar(array, pivo + 1, fim);
            }
        }

        private static int Particionar(Transacao[] array, int inicio, int fim)
        {
            decimal pivo = array[fim].Valor;
            int i = inicio - 1;

            for (int j = inicio; j < fim; j++)
            {
                if (array[j].Valor <= pivo)
                {
                    i++;

                    Transacao temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            Transacao troca = array[i + 1];
            array[i + 1] = array[fim];
            array[fim] = troca;

            return i + 1;
        }
    }
}