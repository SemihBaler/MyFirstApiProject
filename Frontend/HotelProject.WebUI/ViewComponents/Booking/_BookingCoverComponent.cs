﻿using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Booking
{
    public class _BookingCoverComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
