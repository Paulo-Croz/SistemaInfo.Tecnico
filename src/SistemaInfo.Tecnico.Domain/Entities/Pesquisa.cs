namespace SistemaInfo.Tecnico.Domain.Entities
{
    public class Pesquisa : Contrato
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Motorista { get; set; }
        public string Cidade { get; set; }
        public int Nota { get; set; }
        public int Contrato { get; set; }

    }
}
