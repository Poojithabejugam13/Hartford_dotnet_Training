import { Component, signal } from '@angular/core';
import { Usecomponent } from './usercomponent/usecomponent';
@Component({
  selector: 'app-root',
  imports: [ Usecomponent],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('two-way-binding');
}
