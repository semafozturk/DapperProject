﻿namespace Dapper.API.Dtos.CategoryDtos
{
    public class GetByIdCategoryDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
