import { Component } from '@angular/core';
import { Budget } from 'src/app/models/budget';
import { BudgetService } from 'src/app/services/budget.service';

@Component({
  selector: 'app-budget',
  templateUrl: './budget.component.html',
  styleUrls: ['./budget.component.scss']
})
export class BudgetComponent {
  budget?: Budget;
  budgets: Budget[] = [];

  constructor(private budgetService: BudgetService){}

  createNewBudget() : Budget {
    let budget = new Budget()
    budget.amount = 3000;
    return budget;
  }

  ngOnIni() : void{
    this.budgets = this.budgetService.getBudgets();
  }
}


