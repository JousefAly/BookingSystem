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
    public class BranchRepository : IRepository<Branch>
    {
        private readonly AppDbContext _context;

        public BranchRepository(AppDbContext context)
        {
            _context = context;
        }
        public Branch Create(Branch branch)
        {
            if (branch == null)
                return null;
            try
            {
                _context.Add(branch);
                if (_context.SaveChanges() > 0)
                {
                    return branch;
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

        public bool Delete(Branch branch)
        {
            if (branch == null)
            {
                return false;
            }
            try
            {
                _context.Remove(branch);
                _context.SaveChanges();
                if (_context.Branches.Find(branch.Id) == null)
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

        public IEnumerable<Branch> GetAll()
        {
            return _context.Branches.ToArray();
        }
        public IEnumerable<Branch> GetAllWithRooms()
        {
            return _context.Branches.Include(b => b.Rooms).ToArray();
        }

        public Branch GetById(int id)
        {
            return _context.Branches.Include(b => b.Rooms).FirstOrDefault(b => b.Id == id);
        }

        public Branch Update(Branch branch)
        {
            if (branch == null)
            {
                return null;
            }
            try
            {
                _context.Update(branch);
                _context.SaveChanges();
                return branch;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
