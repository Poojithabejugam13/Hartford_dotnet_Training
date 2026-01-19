import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Navbar } from '../components/navbar/navbar';
import { Description } from '../components/description/description';
import { WelcomeBanner } from '../components/welcome-banner/welcome-banner';
import { InsuranceProfiles } from '../components/insurance-profiles/insurance-profiles';
import { Header } from '../components/header/header';
import { Footer } from '../components/footer/footer';
@Component({
  selector: 'app-root',
  imports: [RouterOutlet,Navbar,Description,WelcomeBanner,InsuranceProfiles,Header,Footer],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('first-app');
}
