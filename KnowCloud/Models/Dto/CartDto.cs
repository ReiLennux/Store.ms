﻿namespace KnowCloud.Models.Dto
{
    public class CartDto
    {
        public CartHeaderDto CartHeader { get; set; }

        public IEnumerable<CartDetailsDto> CartDetailsDtos { get; set; }
    }
}
