﻿using Microsoft.EntityFrameworkCore;
using SocialNetwork.Data.Context;

namespace SocialNetwork.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbContext _db;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
        }
        public void Create(T item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
