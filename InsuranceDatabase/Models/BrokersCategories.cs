﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InsuranceDatabase
{
    public partial class BrokersCategories
    {
        public int Id { get; set; }
        [Remote(action: "BrokersValid", controller: "BrokersCategories", AdditionalFields = nameof(CategoryId))]
        public int BrokerId { get; set; }
        public int CategoryId { get; set; }

        [Display(Name = "Брокер")]
        public virtual Brokers Broker { get; set; }

        [Display(Name = "Категорія")]
        public virtual Categories Category { get; set; }
    }
}