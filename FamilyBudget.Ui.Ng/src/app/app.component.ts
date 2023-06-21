import { Component, Input } from '@angular/core';
import { User } from './models/user';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'FamilyBudget.Ui.Ng';
  user?: User;
  // @Input() user?: User;

  // private url = "User";
  

  constructor(private http: HttpClient) { }

  public initNewUser(){
    this.user = new User();
  }

  // public updateUser(user: User): Observable<User[]>{
  //   this.user = new User();
  // }
}
 