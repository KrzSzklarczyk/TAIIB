using System;
using System.Collections.Generic;
using System.Linq;
using BBLDTO.DTO;
using BBLDTO.DTO.Product;
using BBLDTO.interfaces.Product;
using DataAccesLayer;
using Microsoft.EntityFrameworkCore;
using Model;

public class ProductRepository : IProductRepository
{
    private readonly SklepDbContext _context;

    public ProductRepository(SklepDbContext context)
    {
        _context = context;
    }

    public List<ProductResponseDto> GetProducts(Page pageProperties)
    {
        var query = _context.Products.AsQueryable();

        if (pageProperties.FilterByName && !string.IsNullOrEmpty(pageProperties.SortBy))
        {
            query = query.Where(p => p.Name.Contains(pageProperties.SortBy));
        }

        if (pageProperties.FilterByActivated)
        {
            query = query.Where(p => p.IsActive == pageProperties.FilterByActivated);
        }

        if (!string.IsNullOrEmpty(pageProperties.SortBy))
        {
            query = pageProperties.Descending switch
            {
                true => query.OrderByDescending(p => EF.Property<object>(p, pageProperties.SortBy)),
                false => query.OrderBy(p => EF.Property<object>(p, pageProperties.SortBy)),
            };
        }

        var products = query
            .Skip((pageProperties.PageNumber - 1) * pageProperties.PageSize)
            .Take(pageProperties.PageSize)
            .Select(p => new ProductResponseDto
            {
                ID = p.Id,
                Name = p.Name,
                Price = p.Price,
                Image = p.Image
            })
            .ToList();

        return products;
    }

    public ProductResponseDto GetProduct(int productId)
    {
        var product = _context.Products.Find(productId);

        if (product == null)
        {
            throw new Exception("Product not found");
        }

        return new ProductResponseDto
        {
            ID = product.Id,
            Name = product.Name,
            Price = product.Price,
            Image = product.Image
        };
    }

    public void AddProduct(ProductResponseDto productRequest)
    {
        var product = new Product
        {
            Name = productRequest.Name,
            Price = productRequest.Price,
            Image = productRequest.Image,
            IsActive = true // Assuming new products are active by default
        };

        _context.Products.Add(product);
        _context.SaveChanges();
    }

    public void UpdateProduct(int productId, ProductResponseDto productRequest)
    {
        var product = _context.Products.Find(productId);

        if (product == null)
        {
            throw new Exception("Product not found");
        }

        product.Name = productRequest.Name;
        product.Price = productRequest.Price;
        product.Image = productRequest.Image;

        _context.Products.Update(product);
        _context.SaveChanges();
    }

    public void DeleteProduct(int productId)
    {
        var product = _context.Products.Find(productId);

        if (product == null)
        {
            throw new Exception("Product not found");
        }

/*        if (_context.OrderPositions.Any(oi => oi.Id == productId)
        {
            throw new Exception("Cannot delete product associated with unpaid orders");
        }*/

        if (_context.OrderPositions.Any(oi => oi.Id == productId))
        {
            product.IsActive = false;
            _context.Products.Update(product);
        }
        else
        {
            _context.Products.Remove(product);
        }

        _context.SaveChanges();
    }

    public void ChangeProductStatus(int productId, bool activated)
    {
        var product = _context.Products.Find(productId);

        if (product == null)
        {
            throw new Exception("Product not found");
        }

        product.IsActive = activated;

        _context.Products.Update(product);
        _context.SaveChanges();
    }
}
