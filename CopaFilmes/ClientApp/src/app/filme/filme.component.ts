import { Component, OnInit, Input, Output } from '@angular/core';
import { EventEmitter } from '@angular/core';
import { Filme } from './filme';

@Component({
  selector: 'app-filme',
  templateUrl: './filme.component.html',
  styleUrls: ['./filme.component.css']
})
export class FilmeComponent implements OnInit {

  @Input() name: string = '';
  @Input() year: number = 0;

  @Input() objFilmeReference: Filme;

  @Output() selectionChange:EventEmitter<any> = new EventEmitter();

  constructor() { }

  ngOnInit() {
    
  }

  onSelectionChange(event){
    this.selectionChange.emit({ checked: event, filme: this.objFilmeReference });
  }
}
