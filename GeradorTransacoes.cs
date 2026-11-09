using System;

namespace OrdenacaoTransacoes
{
    public static class GeradorTransacoes
    {
        private static Random random = new Random();

        public static Transacao[] Gerar(int n)
        {
            Transacao[] transacoes = new Transacao[n];

            for (int i = 0; i < n; i++)
            {
                transacoes[i] = new Transacao
                {
                    Id = i + 1,
                    Valor = (decimal)(random.NextDouble() * 10000),
                    Data = DateTime.Today.AddDays(-random.Next(365)),
                    Status = "Concluída"
                };
            }

            return transacoes;
        }
    }
}