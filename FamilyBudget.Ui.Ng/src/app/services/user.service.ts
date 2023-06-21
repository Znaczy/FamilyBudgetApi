import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../models/user';
// import {Observable} from 'rxjs/internal/observable';

@Injectable({
  providedIn: 'root'
})
export class UserService {
private url = "User";

  constructor(private http: HttpClient) { }

    // public registerUser() : Observable<User> {
    //   return this.http.post<User>(`${environment.apiUrl}/${this.url}`);
    // }
}
