namespace MyEshop.Models;

class Cart
{
    public int OrderId { get; set; }
    public List<CartItem> CartItems { get; set; }
    public Cart()
    {
        CartItems = new();
    }

    public void AddItem(CartItem item)
    {
        if (CartItems.Exists(i => i.Item.Id == item.Id))
        {
            CartItems.Find(i => i.Item.Id == item.Item.Id).Quantity++;
        }
        else
        {
            CartItems.Add(item);
        }
    }

    public void RemoveItem(int itemId)
    {
        var item = CartItems
        .SingleOrDefault(i => i.Item.Id == itemId);

        if (item?.Quantity <= 1)
        {
            CartItems.Remove(item);
        }
        else if (item != null)
        {
            item.Quantity--;
        }
    }
}