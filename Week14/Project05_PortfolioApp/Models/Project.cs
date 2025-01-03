using System;

namespace Project05_PortfolioApp.Models;

public class Project
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? ImageUrl { get; set; }
    public string? Description { get; set; }
    public string? GithubUrl { get; set; }
    public string? ProjectUrl { get; set; }
    public int ProjectYear { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public int CategoryId { get; set; }
    public string? CategoryName { get; set; }
}
