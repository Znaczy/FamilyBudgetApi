﻿using FamilyBudget.DataAccess.Entities.Account;
using Microsoft.EntityFrameworkCore;

namespace FamilyBudget.DataAccess.Context
{
    public class FamilyBudgetDbContext : DbContext
    {   
        public DbSet<User> Users { get; set; }
        public DbSet<Budget> Budgets { get; set; }
    }
}