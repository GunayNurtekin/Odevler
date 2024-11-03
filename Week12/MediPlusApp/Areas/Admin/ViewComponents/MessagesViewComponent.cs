using System;
using Microsoft.AspNetCore.Mvc;

namespace MediPlusApp.Areas.Admin.ViewComponents;

public class MessagesViewComponent : ViewComponent
{
    public async Task <IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}
