﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Identity;

namespace NewsApp.Themes
{
    public class Theme : Entity<int>
    {
        public string Name  { get; set; }
        public Guid UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
