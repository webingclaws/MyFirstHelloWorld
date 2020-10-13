import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { HttpServices } from '../../services/HttpServices';

@Component({
  selector: 'register-comp',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
  providers: [HttpServices]
})

export class RegisterComponent implements OnInit, OnDestroy
{
  staff: any ={ };
  constructor(public services: HttpServices, public router: Router) {

  }
  ngOnInit()
  {
  }
  ngOnDestroy()
  {
  }
  public Submit() {
    this.services.registerData(JSON.stringify(this.staff)).subscribe(d => console.log(d));
  }
}
