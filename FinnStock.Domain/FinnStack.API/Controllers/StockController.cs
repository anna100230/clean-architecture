using FinnStock.Domain;
using FinnStock.Application;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinnStack.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {

        private readonly IStockService stockService;

        public StockController(IStockService stockService)
        {
            this.stockService = stockService;
        }
        // GET: api/<StockController>
        [HttpGet]
        public ActionResult<IList<StockData>> Get()
        {
            return Ok(this.stockService.GetAllStocks());
        }

    }
}