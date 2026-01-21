import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class Userservice {

  private api = 'http://localhost:3000/users';

  constructor(private http: HttpClient) {}

  getUsers(): Observable<any[]> {
    return this.http.get<any[]>(this.api);
  }

  addUser(user: any) {
    return this.http.post(this.api, user);
  }

  updateUser(id: number, user: any) {
    return this.http.put(`${this.api}/${id}`, user);
  }

  deleteUser(id: number) {
    return this.http.delete(`${this.api}/${id}`);
  }
}
