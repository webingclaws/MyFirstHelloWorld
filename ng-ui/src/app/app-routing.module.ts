import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RegisterComponent } from './component/register/register.component';
import { StaffsComponent } from './component/staffs/staffs.component';
import { StaffsModule } from './component/staffs/staffs.module';
import { RegisterModule } from './component/register/register.module';

const routes: Routes = [
  { path: 'register', component: RegisterComponent },
  { path: 'staffs', component: StaffsComponent }
];

@NgModule({
  imports: [
    StaffsModule,
    RegisterModule,
    RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
