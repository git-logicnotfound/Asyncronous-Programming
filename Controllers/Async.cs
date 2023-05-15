using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Asyncronous_Programming.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Async : ControllerBase
    {
        private static string API_URL = "https://ps-async.fekberg.com/api/stocks";

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<DTO.StockPrice>? stockPrice = Enumerable.Empty<DTO.StockPrice>();
            using (HttpClient _http = new HttpClient())
            {
                var response = await _http.GetAsync($"{API_URL}/MSFT");
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();

                stockPrice = JsonConvert.DeserializeObject<List<DTO.StockPrice>>(content);
            }

            return Ok(stockPrice);
        }

    }
}