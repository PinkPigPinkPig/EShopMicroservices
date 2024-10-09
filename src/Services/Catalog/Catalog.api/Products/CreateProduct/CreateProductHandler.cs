using MediatR;

namespace Catalog.api.Products.CreateProduct
{

    public record CreateProdcutCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price) : IRequest<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    internal class CreateProductCommandHandler : IRequestHandler<CreateProdcutCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProdcutCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
