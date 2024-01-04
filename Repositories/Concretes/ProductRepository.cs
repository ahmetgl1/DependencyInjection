using DependencyInjection.Context;
using DependencyInjection.DTOs.Requests;
using DependencyInjection.DTOs.Responses;
using DependencyInjection.Model;
using DependencyInjection.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DependencyInjection.Repositories.Concretes;

public class ProductRepository : IProductRepository
{

    private readonly ApplicationDbContext applicationDbContext;

    public ProductRepository(ApplicationDbContext applicationDbContext)
    {
        this.applicationDbContext = applicationDbContext;   
    }

    public void Add(Product product)
    {
        applicationDbContext.Add(product);
        applicationDbContext.SaveChanges();
    }

    

}
