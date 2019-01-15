import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';

  filmes = [{ name: "Os Incriveis", year: 2010 }, { name: "Thor", year: 2017 }, { name: "Vingadores", year: 2013 }, { name: "Vingadores", year: 2013 },
            { name: "Os Incriveis", year: 2010 }, { name: "Thor", year: 2017 }, { name: "Vingadores", year: 2013 }, { name: "Vingadores", year: 2013 },
            { name: "Os Incriveis", year: 2010 }, { name: "Thor", year: 2017 }, { name: "Vingadores", year: 2013 }, { name: "Vingadores", year: 2013 },
            { name: "Os Incriveis", year: 2010 }, { name: "Thor", year: 2017 }, { name: "Vingadores", year: 2013 }, { name: "Vingadores", year: 2013 }]

}
