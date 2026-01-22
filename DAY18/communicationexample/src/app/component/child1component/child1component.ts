import { Component, EventEmitter, Input, Output } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-child1component',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './child1component.html',
})
export class Child1component {

  @Input() product!: { id: number; name: string };
  @Output() ratingsent = new EventEmitter<{ productId: number; rating: number }>();

  selectedRating = 0;

  selectRating(star: number) {
    this.selectedRating = star;
    this.ratingsent.emit({
      productId: this.product.id,
      rating: star
    });
  }
}
