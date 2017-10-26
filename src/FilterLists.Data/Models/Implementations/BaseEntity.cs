﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FilterLists.Data.Models.Contracts;
using Newtonsoft.Json;

namespace FilterLists.Data.Models.Implementations
{
    public abstract class BaseEntity : IBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public long Id { get; set; }

        [JsonIgnore]
        public DateTime CreatedDateUtc { get; set; }

        [JsonIgnore]
        public DateTime? ModifiedDateUtc { get; set; }
    }
}