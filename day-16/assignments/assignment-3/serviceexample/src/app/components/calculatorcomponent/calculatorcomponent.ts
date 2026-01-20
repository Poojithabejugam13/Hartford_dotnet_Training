import { Component, OnInit } from '@angular/core';
import { CalculatorService } from '../../services/calculator-service';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-calculatorcomponent',
  imports: [FormsModule],
  templateUrl: './calculatorcomponent.html',
  styleUrl: './calculatorcomponent.css',
})
export class Calculatorcomponent implements OnInit {

  num1!: number;
  num2!: number;
  result!: number;

  constructor(private calcService: CalculatorService) {}

  // Lifecycle hook
  ngOnInit(): void {
    // Initial default values
    this.num1 = 0;
    this.num2 = 0;
    this.result = 0;
  }

  add() {
    this.result = this.calcService.add(this.num1, this.num2);
  }

  subtract() {
    this.result = this.calcService.sub(this.num1, this.num2);
  }

  multiply() {
    this.result = this.calcService.multiply(this.num1, this.num2);
  }

  divide() {
    this.result = this.calcService.div (this.num1, this.num2);
  }
}



