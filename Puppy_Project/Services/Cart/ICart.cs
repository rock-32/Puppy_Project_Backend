﻿using Puppy_Project.Models.Cart;

namespace Puppy_Project.Services.Cart
{
    public interface ICart
    {
        List<outCartDTO> ListCartofUsers(int id);
        bool CreateUserCart(AddCartDTO user);
    }
}