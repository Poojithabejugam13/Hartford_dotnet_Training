import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Child1component } from '../child1component/child1component';

@Component({
  selector: 'app-parentcomponent',
  standalone: true,
  imports: [CommonModule, Child1component],
  templateUrl: './parentcomponent.html',
})
export class Parentcomponent {

  products = [
    { id: 1, name: 'iPhone 15' },
    { id: 2, name: 'Samsung S24' },
    { id: 3, name: 'OnePlus 12' }
  ];

  ratings: { [key: number]: number } = {};

  receiveRating(event: { productId: number; rating: number }) {
    this.ratings[event.productId] = event.rating;
  }
}
