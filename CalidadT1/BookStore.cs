namespace CalidadT1;

public class BookStore
{
    private List<Book> shoppingCart;


    public BookStore(List<Book> shopping)
    {
        this.shoppingCart = shopping;
    }
    
    public decimal GetTotal()
    {
        return shoppingCart.Sum(x => x.Price);
    }
}