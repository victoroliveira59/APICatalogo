using APICatalogo.Context;
using APICatalogo.Interface;

namespace APICatalogo.Repository;

/// <summary>
/// Implements the Unit of Work pattern for managing repositories and database context.
/// Essa implemenção foi baseada no lazy loading, ou seja, os repositórios são instanciados apenas quando necessário.
/// </summary>
public class UnitOfWork : IUnitOfWork
{
    private IProdutoRepository? _produtoRepo;
    private ICategoryRepository? _categoriaRepo;
    public readonly APIWebContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
    /// </summary>
    /// <param name="context">The database context to be used by the repositories.</param>
    public UnitOfWork(APIWebContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Gets the product repository.
    /// </summary>
    public IProdutoRepository ProdutoRepository
    {
        get
        {
            return _produtoRepo ??= new ProdutoRepository(_context);
        }
    }

    /// <summary>
    /// Gets the category repository.
    /// </summary>
    public ICategoryRepository CategoryRepository
    {
        get
        {
            return _categoriaRepo ??= new CategoryRepository(_context);
        }
    }

    /// <summary>
    /// Commits all changes made in the context to the database.
    /// </summary>
    public void Commit()
    {
        _context.SaveChanges();
    }

    /// <summary>
    /// Disposes the database context, releasing all resources used by it.
    /// </summary>
    public void Dispose()
    {
        _context.Dispose();
    }
}