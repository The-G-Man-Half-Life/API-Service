using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Service.Models;

[Table("vehicles")]
public class Vehicle
{
    [Key]
    [Column("id")]
    public int Id {get; set;}

    [Column("Make")]
    public string? Make {get; set;}

    [Column("Model")]
    public string? Model {get; set;}

    [Column("Year")]
    public int Year {get; set;}

    [Column("Price")]
    public double Price {get; set;}

    [Column("Color")]
    public string? Color {get; set;}
}
