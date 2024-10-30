using System;

namespace JobentryMvcApp.Models;

public class JobList
{
	public int Id {get;set;}
	public string? JobName {get;set;}
	public string? CityOfJob {get;set;}
	public string? SalaryofJob {get;set;}
	public string? TimeOfJob {get;set;}
	public string? ListingTime {get;set;}
	public string? logoOfCompanyUrl {get;set;}
}
