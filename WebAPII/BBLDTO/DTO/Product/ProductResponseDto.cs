﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBLDTO.DTO.Product
{
    public class ProductResponseDto
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Image { get; set; }
    }
}
