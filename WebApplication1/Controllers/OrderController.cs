using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.IServices;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IOrderService _orderService; 
        public OrderController(ILogger<ProductController> logger, IOrderService orderService)
        {
            _logger = logger; 
            _orderService = orderService;
        }
        [HttpPost(Name = "InsertOrder")]

        public int Post([FromBody] Order order)
        {
            return _orderService.InsertOrder(order);
        }
        [HttpDelete(Name = "DeleteOrder")]
        public void Delete([FromQuery] int Id)
        {
            _orderService.DeleteOrder(Id);

        }
        [HttpPatch(Name = "ModifyOrder")]
        public void Patch([FromBody] Order order)
        {
            {
                _orderService.UpdateOrder(order);
            }

        }
        [HttpGet(Name = "GetAllOrder")]
        public List<Order> GetAll()
        {
            return _orderService.GetAll();
        }
    }
}
