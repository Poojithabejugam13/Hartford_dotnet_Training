import { Component, EventEmitter, Input, Output ,} from '@angular/core';

@Component({
  selector: 'app-child',
  imports: [],
  templateUrl: './child.html',
  styleUrl: './child.css',
})
export class Child {
@Input() messagefromparent:string='';
@Output() dataChanged=new EventEmitter<string>();
sendDataToParent(data:string){
  this.dataChanged.emit(data);
}
}
