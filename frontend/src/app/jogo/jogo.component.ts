
import { JogoService } from './../Services/jogo.service';
import { Jogo } from './../Models/Jogo';
import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-jogo',
  templateUrl: './jogo.component.html',
  styleUrls: ['./jogo.component.css']
})

export class JogoComponent implements OnInit {

  public titulo = 'Jogos';
  public jogoSelecionado: Jogo;
  public jogoForm: FormGroup;
  public modalRef: BsModalRef;
  public modo = 'post';

  public jogos = [];

  constructor(private fb: FormBuilder, private modalService: BsModalService, private jogoService: JogoService) {
    this.criarForm();
  }

  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

  ngOnInit() {
    this.carregarJogos();
  }

  carregarJogos() {
    this.jogoService.getAll().subscribe(
      (resultado: Jogo[]) => {
        this.jogos = resultado;
      },
      (erro: any) => {
        console.log(erro);
      }
    );
  }

  salvarJogo(jogo: Jogo) {
    (jogo.id === 0 ? this.modo = 'post' : this.modo = 'put');

    this.jogoService[this.modo](jogo).subscribe(
      (resultado: Jogo) => {
        console.log(resultado);
        this.jogoSelecionado = resultado;
        this.carregarJogos();
        this.voltar();
      },
      (erro: any) => {
        console.log(erro);
      }
    );
  }

  criarForm() {
    this.jogoForm = this.fb.group({
      id: [''],
      dataJogo: ['', Validators.required],
      placar: ['', Validators.required],
      minimoTemporada: ['', Validators.required],
      maximoTemporada: ['', Validators.required],
      quebraRecordeMinimo: ['', Validators.required],
      quebraRecordeMaximo: ['', Validators.required]
    });
  }

  novoJogo() {
    this.jogoSelecionado = new Jogo();
    this.jogoForm.patchValue(this.jogoSelecionado);
  }

  jogoSelect(jogo: Jogo) {
    this.jogoSelecionado = jogo;
    this.jogoForm.patchValue(jogo);
  }

  voltar() {
    this.jogoSelecionado = null;
  }

  jogoSubmit() {
    this.salvarJogo(this.jogoForm.value);
  }

  excluirJogo(jogo: Jogo) {
    this.jogoService.delete(jogo.id).subscribe(
      (retorno: string) => {
        console.log(retorno);
        this.carregarJogos();
      },
      (erro: any) => {
        console.log(erro);
      }
    );
  }

}
