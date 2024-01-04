using DependencyInjection.DTOs.Requests;
using DependencyInjection.DTOs.Responses;
using DependencyInjection.Model;
using DependencyInjection.Repositories.Abstracts;

namespace DependencyInjection.Services;

public interface IProductService
{

    ProductResponseDto Add(ProductRequestDto productRequestDto);



}
