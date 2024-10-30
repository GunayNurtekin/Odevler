using System;

namespace JobentryMvcApp.Models;

public class JobCategory
{

    public int Id {get;set;}
	public string? JobTitle {get;set;}
	public int NeedPeopleNumber {get;set;}
	public string? JobCategoryLogoUrl {get;set;}

}
