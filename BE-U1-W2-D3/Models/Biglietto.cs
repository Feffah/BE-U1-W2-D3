namespace BE_U1_W2_D3.Models
{
    public class Biglietto
    {

        public int Id { get; set; }
        public DateTime EmessoIl { get; set; }

        public Sala Sala { get; set; }

        public Spettatore Spettatore { get; set; }

        public decimal PrezzoPagato { get; set; }

        public bool isRidotto { get; set; }
    }
}
