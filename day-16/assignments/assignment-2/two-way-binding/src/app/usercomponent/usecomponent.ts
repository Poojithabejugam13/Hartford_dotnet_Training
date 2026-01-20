import { Component } from '@angular/core';
import { User } from '../interface/user';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-usecomponent',
  imports: [FormsModule],
  templateUrl: './usecomponent.html',
  styleUrl: './usecomponent.css',
})
export class Usecomponent {
users: User[] = [];
user: User = { 
 id: 0, 
 name: '', 
 email: ''
 };
 isEditMode = false;
 saveUser() { 
 if (this.isEditMode) { 
 const index = this.users.findIndex(u => u.id === 
this.user.id); 
 this.users[index] = { ...this.user }; 
 this.isEditMode = false; 
 } else { 
 this.user.id = Date.now(); // simple unique id
 this.users.push({ ...this.user }); 
 } 
 this.resetForm(); 
 } 
 // READ (Edit mode)
 editUser(selectedUser: User) { 
 this.user = { ...selectedUser }; 
 this.isEditMode = true; 
 } 
 // DELETE
 deleteUser(id: number) { 
 this.users = this.users.filter(u => u.id !== id); 
 } 
 resetForm() { 
 this.user = { id: 0, name: '', email: '' }; 
 } 
}
