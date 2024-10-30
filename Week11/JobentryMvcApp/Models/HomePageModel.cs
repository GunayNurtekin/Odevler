using System;

namespace JobentryMvcApp.Models;

public class HomePageModel
{
public AppSetting? AppSetting { get; set; }

public IEnumerable<Social>? Socials { get; set; }


public IEnumerable<Slider>? Sliders { get; set; }

public IEnumerable<JobCategory>? JobCategories { get; set; }

public IEnumerable<JobList>? JobLists { get; set; }

public IEnumerable<Customer>? Customers { get; set; }

public IEnumerable<Category>? Categories { get; set; }
}