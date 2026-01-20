import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Calculatorcomponent } from './components/calculatorcomponent/calculatorcomponent';
import { Message } from './components/message/message';
@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Calculatorcomponent, Message],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('serviceexample');
}
