using DependencyInjection.DTOs.Requests;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ProductsController : ControllerBase
{

    private readonly IProductService productService;

    public ProductsController(IProductService productService)
    {
        this.productService = productService;
        
    }



    [HttpPost]
    public IActionResult CreateProduct(ProductRequestDto productRequestDto)
    {

        var createProduct = productService.Add(productRequestDto);

        return Ok(createProduct);
    }






}
