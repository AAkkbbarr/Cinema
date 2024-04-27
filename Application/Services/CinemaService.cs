using Application.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CinemaService : IBaseService<Cinema>
    {
        public readonly IBaseRepository<Cinema> _cinemaRepository;

        public CinemaService(IBaseRepository<Cinema> cinemaRepository)
        {

            _cinemaRepository = cinemaRepository;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            Cinema cinema = await GetAsync(id);
            if (cinema == null)
            {
                return false;
            } 
            await _cinemaRepository.DeleteAsync(id);
            return true;
        }

        public async Task<IEnumerable<Cinema>> GetAllAsync()
        {
            return await _cinemaRepository.GetAllAsync();
        }

        public async Task<Cinema> GetAsync(Guid id)
        {
            return await _cinemaRepository.GetAsync(id);
        }

        public async Task<Cinema> InsertAsync(Cinema entity)
        {
            return await _cinemaRepository.InsertAsync(entity);
        }

        public async Task<bool> UpdateAsync(Cinema entity)
        {
            var cinema = await _cinemaRepository.GetAsync(entity.Id);
            if (cinema == null)
            {
                return false;
            }
            cinema.Name = entity.Name;
            cinema.Halls = entity.Halls;
            return await _cinemaRepository.UpdateAsync(cinema);
        }
    }
}
