using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnonymFinance.Models;

public class ExpenseCategory
{
    public int Id { get; set; }
    public required string Name { get; set; }

    [Column(TypeName = "varchar(256)")]
    public required string UserHash { get; set; }
    public long CreatedTs { get; set; }

    public ICollection<Expense> Expenses { get; set; }
}
