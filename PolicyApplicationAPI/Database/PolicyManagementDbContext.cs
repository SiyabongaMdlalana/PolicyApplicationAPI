using Microsoft.EntityFrameworkCore;
using PolicyApplicationAPI.Models;
using System;

namespace PolicyApplicationAPI.Database
{
    public class PolicyManagementDbContext:DbContext
    {

        public PolicyManagementDbContext(DbContextOptions<PolicyManagementDbContext> options) : base(options)
        {

        }
        public DbSet<PolicyHolder> PolicyHolders { get; set; }
    }
}
