import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { HttpServices } from '../../services/HttpServices';

@Component({
  selector: 'staffs-comp',
  templateUrl: './staffs.component.html',
  styleUrls: ['./staffs.component.css'],
  providers: [HttpServices]
})
export class StaffsComponent implements OnInit, OnDestroy {
  staffs: any = [];
  constructor(public service: HttpServices, public router: Router) {
   
   
 }
  ngOnInit() {
    this.service.getStaffs().subscribe(s => {
      console.log(s);
      this.staffs = s;
    })
  }
  ngOnDestroy() {
  }
}
