using DependencyInjection.DTOs.Requests;
using DependencyInjection.DTOs.Responses;
using DependencyInjection.Model;

namespace DependencyInjection.Repositories.Abstracts;

public interface IProductRepository 
{

   // Product GetById(int id);
   // List<Product> GetAll();
    void Add(Product product);
    //void Update(ProductUpdateRequestDto requestDto);
    //void Delete(int id);

}
