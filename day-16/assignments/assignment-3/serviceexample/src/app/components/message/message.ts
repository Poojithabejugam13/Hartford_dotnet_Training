import { Component, OnInit } from '@angular/core';
import { MessageService } from '../../services/messageservice';
import {FormsModule} from'@angular/forms';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-message',
  imports: [FormsModule, CommonModule],
  templateUrl: './message.html',
  styleUrl: './message.css',
})
export class Message implements OnInit {
  messages: string[] = [];
  message: string = '';

  constructor(private messageService: MessageService) {}

ngOnInit(): void {
    this.messages = this.messageService.getData();
  }

  addMessage(): void {
    if (this.message.trim() !== '') {
      this.messageService.addData(this.message);
      this.message = '';
    }
  }
}