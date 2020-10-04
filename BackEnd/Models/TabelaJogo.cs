using System;

namespace BackEnd.Models
{
    public class TabelaJogo
    {
        public TabelaJogo() {}

        public TabelaJogo(int id, DateTime dataJogo, int placar, int minimoTemporada, int maximoTemporada, int quebraRecordeMinimo, int quebraRecordeMaximo)
        {
            this.Id = id;
            this.DataJogo = dataJogo;
            this.Placar = placar;
            this.MinimoTemporada = minimoTemporada;
            this.MaximoTemporada = maximoTemporada;
            this.QuebraRecordeMinimo = quebraRecordeMinimo;
            this.QuebraRecordeMaximo = quebraRecordeMaximo;

        }

        public int Id { get; set; }
        public DateTime DataJogo { get; set; }
        public int Placar { get; set; }        
        public int MinimoTemporada { get; set; }
        public int MaximoTemporada { get; set; }
        public int QuebraRecordeMinimo { get; set; }
        public int QuebraRecordeMaximo { get; set; }
        
    }
}






