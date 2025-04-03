import { Component, Input, Output, EventEmitter, input } from '@angular/core';
import { Tarefa } from "../tarefa";
@Component({
selector: 'app-item',
templateUrl: './item.component.html',
styleUrls: ['./item.component.css']
})
export class ItemComponent {
emEdicao = false;
@Input() tarefa: Tarefa = new Tarefa("", false);

@Output() removerTarefa = new EventEmitter<Tarefa>();

EventBinding(){
    this.removerTarefa.emit(this.tarefa)
}

onRemoverTarefa(){
    return this.tarefa;
}
}

