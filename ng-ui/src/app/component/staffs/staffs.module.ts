import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';
import { StaffsComponent } from './staffs.component';

@NgModule({
  declarations: [
    StaffsComponent
  ],
  imports: [
    CommonModule,
    BrowserModule,
    ReactiveFormsModule,
    CommonModule,
    RouterModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
  ],
  entryComponents: [
  ]
})
export class StaffsModule { }
