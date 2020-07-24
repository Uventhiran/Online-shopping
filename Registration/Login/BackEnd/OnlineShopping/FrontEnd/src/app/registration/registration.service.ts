import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../sign/user';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class RegistrationService {

  private readonly apiPath : string = 'api/Users/registrate';

  constructor(private _http : HttpClient) { }

  registrate(user: User) : Observable<User> {
    return this._http.post<User>(`${environment.apiUrl}${this.apiPath}`, user,{
     headers: new HttpHeaders({
       'Content-Type' : 'application/json'
     })
    })
}
}
