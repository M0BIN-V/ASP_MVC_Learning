using MyEshop.Models;

class CartViewModel
{
    public List<CartItem> CartItems { get; set; }
    public decimal OrderTotal { get; set; }
    public CartViewModel()
    {
        CartItems = new();
    }
}