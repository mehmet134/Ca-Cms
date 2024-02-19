﻿using Ca.Cms.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Infrastructure.Persistence.Common
{
    public interface ISeeder
    {
        Task Seed(IApplicationDbContext context);
    }
}
