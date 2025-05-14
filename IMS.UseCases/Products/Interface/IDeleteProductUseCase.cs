namespace IMS.UseCases.Products.Interface
{
    public interface IDeleteProductUseCase
    {
        Task ExecuteAsync(int productId);
    }
}