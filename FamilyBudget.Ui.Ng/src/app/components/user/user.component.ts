import { Component } from '@angular/core';
import { Budget } from 'src/app/models/budget'
import { User } from 'src/app/models/user'


@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.scss']
})
export class UserComponent {
  user?: User;
  budget: Budget[] = [];

  constructor(){}

  ngOnInit(): void {

    console.log('from user oninit');
    console.log();

  }

  registerNewUser() : User {
    let user = new User();
    user.email = 'x@wp.pl';
    user.name = 'Jan';
    user.password = '1234';
    return user;
  }
}
