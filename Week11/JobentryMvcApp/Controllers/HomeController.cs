using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using JobentryMvcApp.Models;
using JobentryMvcApp.Data;

namespace JobentryMvcApp.Controllers;

public class HomeController : Controller
{
  
  private readonly IRepository<AppSetting> _appSettingsRepository;
  private readonly IRepository<Social> _socialRepository;
  private readonly IRepository<Slider> _sliderRepository;

  private readonly IRepository<JobCategory> _jobCategoryRepository;

  private readonly IRepository<JobList> _jobListRepository;

private readonly IRepository<Customer> _customerRepository;

private readonly IRepository<Category> _categoryRepository;

    public HomeController(IRepository<AppSetting> appSettingsRepository, IRepository<Social> socialRepository, IRepository<Slider> sliderRepository, IRepository<JobCategory> jobCategoryRepository, IRepository<JobList> jobListRepository, IRepository<Customer> customerRepository, IRepository<Category> categoryRepository)
    {
        _appSettingsRepository = appSettingsRepository;
        _socialRepository = socialRepository;
        _sliderRepository = sliderRepository;
        _jobCategoryRepository = jobCategoryRepository;
        _jobListRepository = jobListRepository;
        _customerRepository = customerRepository;
        _categoryRepository = categoryRepository;
    }

    public async Task <IActionResult> Index()
    {
        var appSettings = (await _appSettingsRepository.GetAllAsync()).First();
        var socials = await _socialRepository.GetAllAsync();
        var sliders = await _sliderRepository.GetAllAsync();
        var jobcategories = await _jobCategoryRepository.GetAllAsync();
        var joblists= await _jobListRepository.GetAllAsync();
        var customers= await _customerRepository.GetAllAsync();
        var categories = await _categoryRepository.GetAllAsync();

        HomePageModel model = new () {
            AppSetting = appSettings,
            Socials = socials,
            Sliders = sliders,
            JobCategories = jobcategories,
            JobLists = joblists,
            Customers = customers,
            Categories = categories,
        };

        return View(model);
        
    }

}
