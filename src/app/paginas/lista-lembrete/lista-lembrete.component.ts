import { Component, OnInit, ViewChild } from '@angular/core';
import { Lembrete } from '../../interfaces/lembrete';
import { LembreService } from '../../services/lembre.service';
import { ErrorMsgComponent } from '../../compartilhado/error-msg/error-msg.component';

@Component({
  selector: 'app-lista-lembrete',
  templateUrl: './lista-lembrete.component.html',
  styleUrls: ['./lista-lembrete.component.css']
})
export class ListaLembreteComponent implements OnInit {
  public lembretes: Lembrete[];
  @ViewChild(ErrorMsgComponent) errorMsgComponent: ErrorMsgComponent;
  constructor(private lembreteService: LembreService) { }

  ngOnInit() {
    this.getListaLembretes();
  }

  getListaLembretes() {
    this.lembreteService.getListaLembretes()
    .subscribe((lembretes: Lembrete[]) => {
      this.lembretes = lembretes;
    }, () => { this.errorMsgComponent.setError('Falha ao buscar lembretes'); });
  }

  deletaLembrete(id: number) {
    this.lembreteService.deletaLembrete(id)
    .subscribe(() => {
      this.getListaLembretes();
    }, () => { this.errorMsgComponent.setError('Falha ao deletar lembretes'); });
  }

  existemLembretes(): boolean {
    return this.lembretes && this.lembretes.length > 0;
  }
}
