﻿using NetModular.Lib.Data.Abstractions;

namespace NetModular.Module.PersonnelFiles.Infrastructure.Repositories.PostgreSQL
{
    public class EmployeePersonalRepository : SqlServer.EmployeePersonalRepository
    {
        public EmployeePersonalRepository(IDbContext context) : base(context)
        {
        }
    }
}
