﻿using Shopping.Api.DTO.ArticleDTO;
using Shopping.Api.DTO.OrderDTO;

namespace Shopping.Api.Interfaces.IServices
{
    public interface IOrderService
    {
        public Task<List<HistoryOrderDto>> History(int id);
        public Task<GetCreatedOrderDto> Create(CreateOrderDto newArticle);
        public Task<List<GetAllOrderDto>> AllOrders();
        public Task<List<GetActiveOrderDto>> GetActiveOrders(int id);
        public Task<bool> CancelOrder(CancelOrderDto cancelOrder);

    }
}
