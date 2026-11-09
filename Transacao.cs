using System;

namespace OrdenacaoTransacoes
{
    public class Transacao
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; } = "";

        public override string ToString()
        {
            return $"{Id} | R$ {Valor:F2} | {Data:dd/MM/yyyy} | {Status}";
        }
    }
}