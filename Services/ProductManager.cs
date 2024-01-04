using AutoMapper;
using DependencyInjection.DTOs.Requests;
using DependencyInjection.DTOs.Responses;
using DependencyInjection.Model;
using DependencyInjection.Repositories.Abstracts;
using DependencyInjection.Repositories.Concretes;

namespace DependencyInjection.Services;

public class ProductManager : IProductService
{

    private readonly IProductRepository productRepository;

    public ProductManager(IProductRepository productRepository)                         
    {
        this.productRepository = productRepository;
    }

    public ProductResponseDto Add(ProductRequestDto productRequestDto)
    {

        ProductResponseDto productResponseDto = new()
        {
            Name = productRequestDto.Name,
            Description = productRequestDto.Description,
            Price = productRequestDto.Price,

        };

        Product product = new()
        {
            Name = productRequestDto.Name,
            Description = productRequestDto.Description,
            Price = productRequestDto.Price,
        };

        productRepository.Add(product);

        return productResponseDto;
    }







 
}
