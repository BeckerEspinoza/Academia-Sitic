import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Mi primera App en Angular';
  contador: number = 10;

  incrementar(value: number){
    this.contador += value;
  }

  decrementar(value: number){
    this.contador -= value;
  }

  reset(){
    this.contador = 10;
  }
}
