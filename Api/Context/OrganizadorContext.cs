
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Context;

public class OrganizadorContext: DbContext
{
    public OrganizadorContext(DbContextOptions<OrganizadorContext> options): base(options)
    {
        
    }

    public DbSet<Tarefa> Tarefas {get; set;}
}
