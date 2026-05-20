using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using API_PetCare_Connect.Data.Models;
using API_PetCare_Connect.Repository.IRepository;

namespace API_PetCare_Connect.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly PetCareConnectContext _context;
    internal DbSet<T> DbSet;

    public Repository(PetCareConnectContext context)
    {
        _context = context;
        DbSet = _context.Set<T>();
    }

    public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null)
    {
        IQueryable<T> query = DbSet;
        if (filter is not null)
            query = query.Where(filter);
        return await query.ToListAsync();
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await DbSet.FindAsync(id);
    }

    public async Task<T> AddAsync(T entity)
    {
        await DbSet.AddAsync(entity);
        return entity;
    }

    public Task UpdateAsync(T entity)
    {
        DbSet.Update(entity);
        return Task.CompletedTask;
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await DbSet.FindAsync(id);
        if (entity is not null)
            DbSet.Remove(entity);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
