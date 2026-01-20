import { Injectable } from '@angular/core';
@Injectable({
  providedIn: 'root'
})
export class MessageService {

  // private property
  private data: string[] = [];

  constructor() {}

  // returns all messages
  getData(): string[] {
    return this.data;
  }

  // adds new message
  addData(message: string): void {
    this.data.push(message);
  }
}
