using System;

namespace JobentryMvcApp.Models;

public class AppSetting
{
	public int Id {get;set;}
	public string? BrandName {get;set;}
	public string? AboutTitle {get;set;}
	public string? AboutText {get;set;}
	public string? AboutImageUrl {get;set;}
	public string? AddressText {get;set;}
	public string? AddressDistrict {get;set;}
	public string? AddressProvince {get;set;}
	public string? PhoneNumber {get;set;}
	public string? Email {get;set;}
	public DateTime CreatedDate {get;set;}
	public DateTime ModifiedDate {get;set;}
}
