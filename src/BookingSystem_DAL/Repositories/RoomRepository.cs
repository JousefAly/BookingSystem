using BookingSystem_DAL.Contracts;
using BookingSystem_DAL.Data;
using BookingSystem_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem_DAL.Repositories
{
    public class RoomRepository : IRepository<Room>
    {
        private readonly AppDbContext _context;

        public RoomRepository(AppDbContext context)
        {
            _context = context;
        }
        public Room Create(Room room)
        {
            if (room == null)
                return null;
            try
            {
                _context.Add(room);
                if (_context.SaveChanges() > 0)
                {
                    return room;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Room room)
        {
            if (room == null)
            {
                return false;
            }
            try
            {
                _context.Remove(room);
                _context.SaveChanges();
                if (_context.Rooms.Find(room.Id) == null)
                {
                    return true;
                }
                return false;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public IEnumerable<Room> GetAll()
        {
            return _context.Rooms.Include(r => r.Branch).ToArray();
        }

        public Room GetById(int id)
        {
            return _context.Rooms.Find(id);
        }

        public Room Update(Room room)
        {
            if (room == null)
            {
                return null;
            }
            try
            {
                _context.Update(room);
                _context.SaveChanges();
                return room;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
