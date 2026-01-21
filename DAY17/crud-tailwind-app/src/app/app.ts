import { Component, signal } from '@angular/core';
import { UserComponent } from './components/user/user';

@Component({
  selector: 'app-root',
  standalone:true,
  imports: [UserComponent],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('crud-tailwind-app');
}
