using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Context
{
    public interface IContextDb
    {
        DbSet<Casa> Casa { get; set; }
        DbSet<Comprador> Comprador { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);

    }
}
