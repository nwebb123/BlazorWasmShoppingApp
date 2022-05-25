namespace ShopOnline.Api.Entities
{
    public class CartItem
    {
        public int Id { get; set; }

        //Foreign key used to join cart entity to cart item entity. The cart entity has a one-to-many relationship with the cart item entity. This means that many cart items can be included in any one cart.
        public int CartId { get; set;}

        public int ProductId { get; set; }

        public int Quantity { get; set; }

    }
}
