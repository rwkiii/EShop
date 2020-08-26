﻿using EasyAbp.EShop.Products;
using EasyAbp.EShop.Stores;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace EasyAbp.EShop.Orders
{
    [DependsOn(
        typeof(EShopOrdersDomainModule),
        typeof(EShopOrdersApplicationContractsModule),
        typeof(EShopProductsApplicationContractsModule),
        typeof(EShopStoresDomainSharedModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class EShopOrdersApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<EShopOrdersApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<EShopOrdersApplicationModule>(validate: true);
            });
        }
    }
}
