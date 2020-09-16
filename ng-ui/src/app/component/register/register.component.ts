import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'register-comp',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit, OnDestroy
{
  staff: any ={ };
  constructor(public router: Router) {

  }
  ngOnInit()
  {
  }
  ngOnDestroy()
  {
  }
  public Submit() {

  }
}
