import { Component } from "@angular/core"

@Component({
    selector: 'my-employee' ,
    templateUrl:'app/employee/employee.component.html'
})

export class EmployeeComponent {
    name: string = 'James Smith';
    city: string = 'Houston';
    gender: string = 'male';
    age: number = 20;
}