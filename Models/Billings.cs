namespace AspNet_API_App.Models;

public class Billing{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime Date { get; set; }
    public double Value { get; set; }
    public string? Type { get; set; }

}