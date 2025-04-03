import { Component } from '@angular/core';
import { tarefa } from './tarefa';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'TODOapp';
  arrayDeTarefas: tarefa[] = [];

  constructor () {
    this.READ_tarefas();
  }

  CREATE_tarefa (descricaoNovaTarefa : string) {
    var novaTarefa = new tarefa(descricaoNovaTarefa, false);
    this.arrayDeTarefas.unshift(novaTarefa);
  }

  READ_tarefas () {
    this.arrayDeTarefas = [
      new tarefa ("Estudar Frameworks WEB", false),
      new tarefa ("Comer massinha", false),
      new tarefa ("Ajudar meus pais", false)
    ];
  }
} 


