using System.Collections.Generic;
using MusicHouse.Models;

namespace MusicHouse.ViewModels
{
    public class ShoppingCartViewModel
    {
        
        public List<Cart> CartItems { get; set; }
        
        public decimal CartTotal    { get; set; }
    }
}
