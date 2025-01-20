using System.ComponentModel.DataAnnotations.Schema;

namespace AnonymFinance.Models;

public class Expense
{
    public long Id { get; set; }

    [Column(TypeName = "decimal")]
    public decimal Value { get; set; }
    public required int ExpenseCategoryId { get; set; }
    public required ExpenseCategory ExpenseCategory { get; set; }

    [Column(TypeName = "timestamp")]
    public required DateTime DateTime { get; set; }
    public string? Description { get; set; }

    [Column(TypeName = "varchar(256)")]
    public required string UserHash { get; set; }
    public long CreatedTs { get; set; }
    public long LastUpdatedTs { get; set; }
}
