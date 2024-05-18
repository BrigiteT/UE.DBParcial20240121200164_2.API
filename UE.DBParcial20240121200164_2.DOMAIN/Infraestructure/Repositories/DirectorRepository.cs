using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using UE.DBParcial20240121200164_2.DOMAIN.Core.Entities;
using UE.DBParcial20240121200164_2.DOMAIN.Core.Interfaces;
using UE.DBParcial20240121200164_2.DOMAIN.Infraestructure.Data;

namespace UE.DBParcial20240121200164_2.DOMAIN.Infraestructure.Repositories
{
    public class DirectorRepository : IDirectorRepository
    {
        private readonly Parcial20240121200164Context _dbContext;

        public DirectorRepository(Parcial20240121200164Context dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Director>> GetAll()
        {
            return await _dbContext.Director.ToListAsync();
        }

        public async Task<Director> GetById(int id)
        {
            return await _dbContext.Director.Where(d => d.Id == id).FirstOrDefaultAsync();
        }

        public async Task<bool> Create(Director director)
        {
            await _dbContext.Director.AddAsync(director);
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Update(Director director)
        {
            _dbContext.Director.Update(director);
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var findDirector = await _dbContext.Director.Where(d => d.Id == id).FirstOrDefaultAsync();
            if (findDirector == null) { return false; }
            _dbContext.Director.Remove(findDirector);
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0;
        }


    }
}
