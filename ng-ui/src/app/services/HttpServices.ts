import {
  HttpClient,
  HttpEvent,
  HttpHandler,
  HttpInterceptor,
  HttpRequest,
  HttpHeaders
} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable()
export class HttpServices {
  httpOption = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  }
  constructor(private http: HttpClient) {
  }
  public registerData(data: string): Observable<any> {
    return this.http.post('http://localhost:5000/service/register/submit', data, this.httpOption)
      .pipe(catchError(this.handlerError));
  }
  public getStaffs(): Observable<any> {
    return this.http.get('http://localhost:5000/service/staffs/get', this.httpOption)
      .pipe(catchError(this.handlerError));
  }
  private handlerError(error: Response) {
    console.log(error);
    return throwError(error || 'Server error');
  }
}
