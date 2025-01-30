using Microsoft.EntityFrameworkCore;

namespace MyNewResourceFromMssqlAndRest.Infrastructure;

public class MyNewResourceFromMssqlAndRestDbContext : DbContext
{
    public MyNewResourceFromMssqlAndRestDbContext(
        DbContextOptions<MyNewResourceFromMssqlAndRestDbContext> options
    )
        : base(options) { }
}
