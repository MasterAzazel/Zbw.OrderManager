﻿using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using ZbW.ITB1821H.OrderManager.Model.Dto;
using ZbW.ITB1821H.OrderManager.Model.Entities;
using ZbW.ITB1821H.OrderManager.Model.Repository.Interfaces;
using ZbW.ITB1821H.OrderManager.Model.Service.Interfaces;

namespace ZbW.ITB1821H.OrderManager.Model.Service
{
    public class ArticleService : ServiceBase<Article, ArticleDto>, IArticleService
    {
        public ArticleService(IArticleRepository repo) : base(repo)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Article, ArticleDto>().ReverseMap();
                cfg.CreateMap<ArticleGroup, ArticleGroupDto>().ReverseMap();
                cfg.CreateMap<Position, PositionDto>().ReverseMap();
                cfg.CreateMap<Order, OrderDto>().ReverseMap();
                cfg.AddExpressionMapping();
            });
            _mapper = new Mapper(config);
        }

        public new void Delete(ArticleDto entity)
        {
            entity.IsActive = false;
            _repo.Update(_mapper.Map<Article>(entity));
        }
    }
}
