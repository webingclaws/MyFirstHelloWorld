import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'staffs-comp',
  templateUrl: './staffs.component.html',
  styleUrls: ['./staffs.component.css']
})
export class StaffsComponent implements OnInit, OnDestroy {
  staffs: any = [];
  constructor(public router: Router) {
    //<td>{{staff.}}</td><td>{{staff.lastname}}</td><td>{{staff.bod}}</td><td>{{staff.education}}</td><td>{{staff.soo}}</td><td>{{staff.religion}}</td></tr>
    this.staffs = [
      {
       firstname: "Tola", lastname: "Adeboye", bod: "23-07-1999", education: "University", soo: "Ogun", religion: "Christianity"
      },
      {
        firstname: "Tola", lastname: "Adeboye", bod: "23-07-1999", education: "University", soo: "Ogun", religion: "Christianity"
      },
      {
       firstname: "Tola", lastname: "Adeboye", bod: "23-07-1999", education: "University", soo: "Ogun", religion: "Christianity"
      }
    ]

  }
  ngOnInit() {
  }
  ngOnDestroy() {
  }
}
