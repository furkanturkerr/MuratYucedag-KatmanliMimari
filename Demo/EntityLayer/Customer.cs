namespace EntityLayer;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public int JobId { get; set; }
    public Job Job { get; set; }
}