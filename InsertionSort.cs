namespace OrdenacaoTransacoes
{
    public static class InsertionSort
    {
        public static void Executar(Transacao[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                Transacao atual = array[i];
                int j = i - 1;

                while (j >= 0 && array[j].Valor > atual.Valor)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = atual;
            }
        }
    }
}