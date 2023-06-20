import { Component } from '@angular/core';
import { User } from './models/user';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'FamilyBudget.Ui.Ng';
  user?: User

  initNewUser(){
    this.user = new User();
  }
}
