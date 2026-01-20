import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ListEmployeesComponent } from './employees/list-employees';
@Component({
  selector: 'app-root',
  imports: [RouterOutlet, ListEmployeesComponent],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('empexample');
}
