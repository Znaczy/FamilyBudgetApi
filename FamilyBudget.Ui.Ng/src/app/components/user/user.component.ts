import { Component } from '@angular/core';
import { Budget } from 'src/app/models/budget'

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.scss']
})
export class UserComponent {
  budget: Budget[] = [];

  constructor(){}

  ngOnInit(): void {

    console.log('from user oninit');
    console.log();

  }
}
