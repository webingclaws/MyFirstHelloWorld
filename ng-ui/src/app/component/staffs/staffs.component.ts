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

  }
  ngOnInit() {
  }
  ngOnDestroy() {
  }
}
