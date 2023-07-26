using CasgemUow.BusinessLayer.Abstract;
using CasgemUow.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CasgemUow.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        readonly ICustomerProcessService _customerProcessService;
        readonly ICustomerService _customerService;
        public DefaultController(ICustomerProcessService customerProcessService, ICustomerService customerService)
        {
            _customerProcessService = customerProcessService;
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerProcess p)
        {
            var valueSender = _customerService.TGetById(p.CustomerProcessSenderId);
            var valueReciver = _customerService.TGetById(p.CustomerProcessReceiverId);

            valueReciver.CustomerBalance += p.CustomerProcessAmount;
            valueSender.CustomerBalance -= p.CustomerProcessAmount;

            List<Customer> modifiedCustomer = new List<Customer>()
            {
                valueSender,
                valueReciver
            };

            _customerService.TMultiUpdate(modifiedCustomer);
            return RedirectToAction("CustomerProcessList");
        }
    }
}
