import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'podium',
  templateUrl: './podium.component.html',
  styleUrls: ['./podium.component.css']
})
export class PodiumComponent implements OnInit {

  @Input() position: string = "1";
  @Input() filmeName: string = "";

  constructor() { }

  ngOnInit() {
  }

}
