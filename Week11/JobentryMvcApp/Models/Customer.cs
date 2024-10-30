using System;

namespace JobentryMvcApp.Models;

public class Customer
{

    public int Id {get;set;}
	public string? CustomerName {get;set;}
	public string? CustomerPhotoURL {get;set;}
	public string? CustomerMessage {get;set;}
	public DateTime CreatedDate {get;set;}
	public DateTime ModifiedDate {get;set;}

}
