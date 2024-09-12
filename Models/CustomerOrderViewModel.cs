namespace BasicMvcProject2.Models
{
    public class CustomerOrderViewModel
    {
            public Customer Customer { get; set; }    // Müşteri bilgilerini tutacak
            public List<Order> Orders { get; set; }   // Sipariş bilgilerini liste olarak tutacak

    }
}
