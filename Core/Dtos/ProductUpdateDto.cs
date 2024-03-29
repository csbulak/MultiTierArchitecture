﻿namespace Core.Dtos;

public class ProductUpdateDto
{
    public string Id { get; set; }
    public string? Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
}