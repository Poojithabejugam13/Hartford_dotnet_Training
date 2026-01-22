import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Child } from './components/child/child';
import { Parentcomponent } from './component/parentcomponent/parentcomponent';
import { Child1component } from './component/child1component/child1component';
@Component({
  selector: 'app-root',
  imports: [RouterOutlet,Child,Parentcomponent,Child1component],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('communicationexample');
  handleDataChange(data:string){
    console.log(data)
  }
}
