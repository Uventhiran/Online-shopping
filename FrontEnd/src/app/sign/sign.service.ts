import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {User} from './user';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SignService {

  private baseUrl = 'https://localhost:44313/';
  private readonly apiPath : string = 'api/Login';

  constructor( private _http : HttpClient) { }

  enroll(user: User ) : Observable<User> {
    return this._http.post<User>('${this.baseUrl}${this.apiPath}', user,{
     headers: new HttpHeaders({
       'Content-Type' : 'application/json'
     })
    })
  
  }
}
  

