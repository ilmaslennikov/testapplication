using System;

namespace MVCApplicationDAL.Implementation
{
    public abstract class BaseRepository<T> where T : class
    {
        private readonly MVCApplicationDbContext _context;
        internal BaseRepository(MVCApplicationDbContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            _context = context;
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        internal MVCApplicationDbContext Context
        {
            get { return _context; }
        }
    }
}
