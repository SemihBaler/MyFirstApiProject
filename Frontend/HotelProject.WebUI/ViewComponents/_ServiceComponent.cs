using HotelProject.WebUI.Dtos.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents
{
    public class _ServiceComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _ServiceComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory=httpClientFactory;
            
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5038/api/Service");
            if(responseMessage.IsSuccessStatusCode)
            {
                var json = await responseMessage.Content.ReadAsStringAsync();   
                var value=JsonConvert.DeserializeObject<List<ResultServiceDto>>(json);
                return View(value);
            }
            return View();
        }
    }
}
