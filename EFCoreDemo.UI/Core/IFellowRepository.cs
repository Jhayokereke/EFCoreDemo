using EFCoreDemo.UI.Data;
using EFCoreDemo.UI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo.UI.Core
{
    public interface IFellowRepository
    {
        Task<DotnetFellow> FindFellowAsync(string Id);
        Task<bool> AddFellowAsync(DotnetFellow fellow);
        Task<bool> UpdateFellowAsync(DotnetFellow fellow);
        Task<bool> DeleteFellowAsync(string Id);
        Task<IReadOnlyCollection<DotnetFellow>> GetDotnetFellowsAsync();
    }

    public class FellowRepository : IFellowRepository
    {
        private readonly TheBulbDBContext _db;

        public FellowRepository(TheBulbDBContext bulbDBContext)
        {
            _db = bulbDBContext;
        }
        public async Task<bool> AddFellowAsync(DotnetFellow fellow)
        {
            _db.Add(fellow);
            int affectedRows = await _db.SaveChangesAsync();

            return affectedRows > 0;
        }

        public async Task<bool> DeleteFellowAsync(string Id)
        {
            var fellowToDelete = await FindFellowAsync(Id);

            _db.Remove(fellowToDelete);
            int affectedRows = await _db.SaveChangesAsync();

            return affectedRows > 0;
        }

        public async Task<DotnetFellow> FindFellowAsync(string Id)
        {
            return await _db.FindAsync<DotnetFellow>(Id);
        }

        public async Task<IReadOnlyCollection<DotnetFellow>> GetDotnetFellowsAsync()
        {
            return await _db.Set<DotnetFellow>().Include(d => d.State).AsNoTracking().ToListAsync();
        }

        public async Task<bool> UpdateFellowAsync(DotnetFellow fellow)
        {
            _db.Update(fellow);
            int affectedRows = await _db.SaveChangesAsync();

            return affectedRows > 0;
        }
    }
}
