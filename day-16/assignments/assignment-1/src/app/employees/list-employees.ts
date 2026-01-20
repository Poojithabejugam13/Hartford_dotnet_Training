import { Component, OnInit } from '@angular/core'; 
import { Employee } from '../models/employee.model'; 
import { DatePipe } from '@angular/common'; 
@Component({ 
 selector: 'app-list-employees', 
 standalone: true, 
 imports: [DatePipe], 
 templateUrl: './list-employees.html', 
 styleUrl: './list-employees.css'
}) 
export class ListEmployeesComponent implements OnInit { 
 employees: Employee[] = [ 
 { 
 id: 1, 
 name: 'Mark', 
 gender: 'Male', 
 contactPreference: 'Email', 
 phoneNumber:8787665890,
 email: 'mark@pragimtech.com', 
 dateOfBirth: new Date('10/25/1988'), 
 department: 'IT', 
 isActive: true, 
 photoPath: 'emp1.jpeg'
 }, 
 { 
 id: 2, 
 name: 'Mary', 
 gender: 'Female', 
 contactPreference: 'Phone', 
 phoneNumber: 2345978640, 
 email: 'mary@pragimtech.com', 
 dateOfBirth: new Date('11/20/1979'), 
 department: 'HR', 
 isActive: true, 
 photoPath: 'emp2.jpeg'
 }, 
 { 
 id: 3, 
 name: 'Jony', 
 gender: 'Female', 
 contactPreference: 'Phone', 
 phoneNumber: 5432978640, 
 email: 'jony@pragimtech.com', 
 dateOfBirth: new Date('3/25/1976'), 
 department: 'IT', 
 isActive: false, 
 photoPath: 'emp3.jpeg'
 }, 
 ]; 
 constructor() { } 
 ngOnInit() { 
 } 
}