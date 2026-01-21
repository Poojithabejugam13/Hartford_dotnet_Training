import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { Userservice } from '../../services/userservice';

@Component({
  selector: 'app-user',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './user.html'
})
export class UserComponent implements OnInit {

  users: any[] = [];
  isEdit = false;

  user: any = {
    id: null,
    name: '',
    email: '',
    role: ''
  };

  constructor(private service: Userservice) {}

  ngOnInit(): void {
    this.loadUsers();
  }

  loadUsers() {
    this.service.getUsers().subscribe((data: any[]) => {
      this.users = data;
    });
  }

  addUser() {
  const payload = {
    name: this.user.name,
    email: this.user.email,
    role: this.user.role
  };

  this.service.addUser(payload).subscribe(() => {
    this.loadUsers();
    this.reset();
  });
}


  editUser(u: any) {
    this.user = { ...u };   
    this.isEdit = true;
  }

  updateUser() {
    this.service.updateUser(this.user.id, this.user).subscribe(() => {
      this.loadUsers();
      this.reset();
    });
  }

  deleteUser(id: number) {
    this.service.deleteUser(id).subscribe(() => {
      this.loadUsers();
    });
  }

  reset() {
    this.user = {
      id: null,
      name: '',
      email: '',
      role: ''
    };
    this.isEdit = false;
  }
}
