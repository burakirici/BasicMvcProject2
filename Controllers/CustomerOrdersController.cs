using BasicMvcProject2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMvcProject2.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public ActionResult Index()
        {
            // Örnek müşteri bilgisi oluşturma
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Dilara",
                LastName = "Kaya",
                Email = "dilara.kaya@example.com"
            };

            // Örnek sipariş bilgileri oluşturma
            var orders = new List<Order>
        {
            new Order { Id = 1, ProductName = "Laptop", Price = 5000m, Quantity = 1 },
            new Order { Id = 2, ProductName = "Mouse", Price = 100m, Quantity = 2 },
            new Order { Id = 3, ProductName = "Klavye", Price = 200m, Quantity = 1 }
        };

            // ViewModel'i dolduruyoruz
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer, // Müşteri bilgisi ekleniyor
                Orders = orders      // Sipariş listesi ekleniyor
            };

            // View'a ViewModel'i gönderiyoruz
            return View(viewModel);
        }
    }

}
