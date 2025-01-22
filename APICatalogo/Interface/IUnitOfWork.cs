namespace APICatalogo.Interface;

public interface IUnitOfWork
{
    IProdutoRepository ProdutoRepository { get; }
    ICategoryRepository CategoryRepository { get; }
    void Commit(); // SaveChanges 
}