import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class CalculatorService {
  add(a:number,b:number):number{
    return a+b
  }
  sub(a:number,b:number):number{
    return a-b
  }
multiply(a:number,b:number):number{
    return a*b
  }
div(a:number,b:number):number{
    return a/b
  }

}
