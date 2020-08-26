﻿using System;
using System.ComponentModel.DataAnnotations;
using EasyAbp.EShop.Stores.Stores;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.EShop.Stores.StoreOwners.Dtos
{
    public class StoreOwnerDto : ExtensibleFullAuditedEntityDto<Guid>, IMultiStore
    {
        [Required]
        public Guid StoreId { get; set; }

        [Required]
        public Guid OwnerUserId { get; set; }
    }
}