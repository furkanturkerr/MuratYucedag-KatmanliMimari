namespace EntityLayer;

public class Job
{
    public int JobId { get; set; }
    public string Name { get; set; }
    public List<Customer> customers { get; set; }
}