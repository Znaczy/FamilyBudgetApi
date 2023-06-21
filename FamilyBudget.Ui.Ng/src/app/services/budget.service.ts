import { Injectable } from '@angular/core';
import { Budget } from '../models/budget';

@Injectable({
  providedIn: 'root'
})
export class BudgetService {

  constructor() { }

  public getBudgets() : Budget[] {
    let budget = new Budget()

  return [budget];
  }
}
