﻿using AutoMapper;
using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Entities.Addresses;
using FleetFlow.Domain.Entities.Attachments;
using FleetFlow.Domain.Entities.Authorizations;
using FleetFlow.Domain.Entities.Orders;
using FleetFlow.Domain.Entities.Orders.Feedbacks;
using FleetFlow.Domain.Entities.Products;
using FleetFlow.Domain.Entities.UserQuestions;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Domain.Entities.Warehouses;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.DTOs.Attachments;
using FleetFlow.Service.DTOs.Carts;
using FleetFlow.Service.DTOs.Discounts;
using FleetFlow.Service.DTOs.Feedbacks;
using FleetFlow.Service.DTOs.Inventories;
using FleetFlow.Service.DTOs.InventoryLogs;
using FleetFlow.Service.DTOs.Location;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.DTOs.Permissions;
using FleetFlow.Service.DTOs.Product;
using FleetFlow.Service.DTOs.User;
using ProdInven = FleetFlow.Domain.Entities.Warehouses.ProductInventoryAssignment;
using ProdInvenForCreationDto = FleetFlow.Service.DTOs.Inventories.ProductInventoryAssignmentForCreationDto;
using ProdInvenForResultDto = FleetFlow.Service.DTOs.Inventories.ProductInventoryAssignmentForResultDto;
using ProdInvenForUpdateDto = FleetFlow.Service.DTOs.Inventories.ProductInventoryAssignmentForUpdateDto;
using Location = FleetFlow.Domain.Entities.Warehouses.Location;

namespace FleetFlow.Service.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Product,ProductForCreationDto>().ReverseMap();
            CreateMap<Product,ProductForResultDto>().ReverseMap();

            CreateMap<Address, AddressForCreationDto>().ReverseMap();
            CreateMap<Address, AddressForResultDto>().ReverseMap();

            CreateMap<User, UserForCreationDto>().ReverseMap();
            CreateMap<User, UserForResultDto>().ReverseMap();
            CreateMap<User, UserForUpdateDto>().ReverseMap();

            CreateMap<CartItem, CartItemResultDto>().ReverseMap();
            CreateMap<Order, OrderResultDto>().ReverseMap();
            CreateMap<OrderItem, OrderItemForResultDto>().ReverseMap();

            CreateMap<Location, LocationForCreationDto>().ReverseMap();
            CreateMap<Location, LocationForResultDto>().ReverseMap();

            CreateMap<Inventory, InventoryForCreationDto>().ReverseMap();
            CreateMap<Inventory, InventoryForResultDto>().ReverseMap();
            CreateMap<Inventory, InventoryForUpdateDto>().ReverseMap();
            CreateMap<InventoryLogForCreationDto, InventoryForUpdateDto>().ReverseMap();

            CreateMap<InventoryLog, InventoryLogForCreationDto>().ReverseMap();
            CreateMap<InventoryLog, InventoryLogForResultDto>().ReverseMap();

            CreateMap<ProdInven, ProdInvenForCreationDto>().ReverseMap();
            CreateMap<ProdInven, ProdInvenForResultDto>().ReverseMap();
            CreateMap<ProdInven, ProdInvenForUpdateDto>().ReverseMap();
            CreateMap<ProdInvenForCreationDto, ProdInvenForUpdateDto>().ReverseMap();
        }
    }
}
