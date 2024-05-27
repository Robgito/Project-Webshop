﻿using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public interface IOrderRepository
    {
        Task<IEnumerable<OrderEntity>> GetAllOrdersAsync();
    }
}