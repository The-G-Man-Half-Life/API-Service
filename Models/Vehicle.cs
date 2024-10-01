using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Service.Models;

[Table("vehicles")]
public class Vehicle
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

    public Vehicle(string? Make,string? Model,int Year,double Price,string? Color)
    {
        this.Make = Make;
        this.Model = Model;
        this.Year = Year;
        this.Price = Price;
        this.Color = Color;
    }
}
