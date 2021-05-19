namespace Entities
{
    public class Moeda
    {
        public int Id { get; set; }
        public string TipoMoeda { get; set; }
        public string Simbolo { get; set; }
        public double ValorConversao { get; set; }

        public Moeda() { }

        public Moeda(int p_Id, string p_Simbolo, double p_ValorConversao)
        {
            Id = p_Id;
            Simbolo = p_Simbolo;
            ValorConversao = p_ValorConversao;
        }

        public Moeda(string p_TipoMoeda, string p_Simbolo, double p_ValorConversao)
        {
            TipoMoeda = p_TipoMoeda;
            Simbolo = p_Simbolo;
            ValorConversao = p_ValorConversao;
        }
    }
}
