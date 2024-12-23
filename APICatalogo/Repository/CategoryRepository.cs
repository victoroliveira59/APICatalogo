using System.Collections;
using APICatalogo.Context;
using APICatalogo.Interface;
using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Repository;

public class CategoryRepository : Repository<Categoria>, ICategoryRepository
{
    public CategoryRepository(APIWebContext context) : base(context)
    {
    }
}