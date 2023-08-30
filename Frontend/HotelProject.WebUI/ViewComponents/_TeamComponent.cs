using HotelProject.WebUI.Dtos.StaffDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents
{
    public class _TeamComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _TeamComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5038/api/Staff");
            if(responseMessage.IsSuccessStatusCode)
            {
                var json=await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultStaffDto>>(json);
                return View(value);
            }
            return View();
        }
    }
}
