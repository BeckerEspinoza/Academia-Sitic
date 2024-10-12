import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-counter',
  templateUrl: './counter.component.html',
  styleUrls: ['./counter.component.css']
})
export class CounterComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

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
 export{};
