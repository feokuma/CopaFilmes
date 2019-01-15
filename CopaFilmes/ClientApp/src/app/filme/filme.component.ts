import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-filme',
  templateUrl: './filme.component.html',
  styleUrls: ['./filme.component.css']
})
export class FilmeComponent implements OnInit {

  @Input() name: string = '';
  @Input() year: number = 1970;

  constructor() { }

  ngOnInit() {
  }

}
