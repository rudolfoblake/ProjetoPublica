
export class Jogo {

  constructor() {
      this.id = 0;
      this.dataJogo = null;
      this.placar = 0;
      this.minimoTemporada = 0;
      this.maximoTemporada = 0;
      this.quebraRecordeMinimo = 0;
      this.quebraRecordeMaximo = 0;
    }

    id?: number;
    dataJogo: Date;
    placar: number;
    minimoTemporada: number;
    maximoTemporada: number;
    quebraRecordeMinimo: number;
    quebraRecordeMaximo: number;
  }
