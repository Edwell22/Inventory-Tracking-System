using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using TrackIt.Data;
using TrackIt.Models;

namespace TrackIt.Services
{
    public class ProductService
    {
        private readonly AppDbContext _db;

        public ProductService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<List<Product>> Index(string? searchString = null)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                return await _db.Products
                    .Where(s => s.Name.ToUpper().Contains(searchString.ToUpper()))
                    .ToListAsync();
            }

            return await _db.Products.ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            var product = await _db.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (product == null)
            {
                throw new KeyNotFoundException($"Product with id {id} not found.");
            }
            return product;
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            var updatedProduct = await _db.Products.FindAsync(product.Id);
            if (updatedProduct == null)
            {
                throw new KeyNotFoundException($"Product with id {product.Id} not found.");
            }

            updatedProduct.Name = product.Name;
            updatedProduct.Code = product.Code;
            updatedProduct.UnitWeight = product.UnitWeight;
            updatedProduct.UnitCount = product.UnitCount;
            updatedProduct.Group = product.Group;
            updatedProduct.ImageUrl = product.ImageUrl;
            updatedProduct.ManufacturedDate = product.ManufacturedDate;
            updatedProduct.ExpiryDate = product.ExpiryDate;
            updatedProduct.ReturnStatus = product.ReturnStatus;
            updatedProduct.DamageReports = product.DamageReports;
            updatedProduct.SupplyStatus = product.SupplyStatus;

            await _db.SaveChangesAsync();
            return updatedProduct;
        }

        public async Task DeleteProduct(int id)
        {
            var product = await _db.Products.FindAsync(id);
            if (product == null)
            {
                throw new KeyNotFoundException($"Product with id {id} not found.");
            }

            _db.Products.Remove(product);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _db.Products.ToListAsync();
        }

        public async Task AddProduct(Product product)
        {
            _db.Products.Add(product);
            await _db.SaveChangesAsync();
        }
    }
}
