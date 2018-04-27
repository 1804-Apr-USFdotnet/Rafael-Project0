using ResterauntReview.dl.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ResterauntReview.dl.Models;

namespace ResterauntReview.dl.Repositories
{
  public   class ResterauntRepository : ApplicationDbContext
    {
        private readonly ApplicationDbContext dataContext = new ApplicationDbContext();

        private readonly ResterauntsEntities _db;
        public ResterauntRepository()
        {
            
        }

        

        public ResterauntRepository(ApplicationDbContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public  ICollection<Resteraunt> GetAllResteraunts()
        {
           return  dataContext.Resteraunts.ToList();
        }

        public List<int> ConvertNameIntoId(string resterauntName)
        {
            var ids = dataContext.Resteraunts.Where(x => x.Name == resterauntName).Select(r => r.ResterauntId).ToList();
            return ids;
        }
        public Resteraunt GetResterauntById(int id)
        {
            return dataContext.Resteraunts.Find(id);
        }

        public virtual void InsertAndSubmit(Resteraunt entity)
        {
            this.dataContext.Set<Resteraunt>().Add(entity);
            this.SaveChanges();
        }


        public virtual void DeleteAndSubmit(Resteraunt entity)
        {
            this.dataContext.Set<Resteraunt>().Remove(entity);
            this.SaveChanges();
        }

        //public virtual void SoftDeleteAndSubmit(Resteraunt entity)
        //{
        //    if (typeof(Resteraunt).GetProperty("Deleted") != null)
        //    {
        //        entity.GetType().GetProperty("Deleted").SetValue(entity, DateTime.Now, null);
        //        this.UpdateAndSubmit(Resteraunt);
        //    }
        //    else
        //    {
        //        throw new InvalidOperationException("This entity type does not support soft deletion. Please add a DateTime? property called Deleted and try again.");
        //    }

        //}

        public void ExecuteCommand(string sql, params object[] parameters)
        {
            this.dataContext.ExecuteCommand(sql, parameters);
        }

        #region Private Helpers
        /// <summary>
        /// Returns expression to use in expression trees, like where statements. For example query.Where(GetExpression("IsDeleted", typeof(boolean), false));
        /// </summary>
        /// <param name="propertyName">The name of the property. Either boolean or a nulleable typ</param>
        private Expression<Func<Resteraunt, bool>> GetExpression(string propertyName, object value)
        {
            var param = Expression.Parameter(typeof(Resteraunt));
            var actualValueExpression = Expression.Property(param, propertyName);

            var lambda = Expression.Lambda<Func<Resteraunt, bool>>(
                Expression.Equal(actualValueExpression,
                    Expression.Constant(value)),
                param);

            return lambda;
        }

        protected IQueryable<Resteraunt> DataSource()
        {
            var query = dataContext.Set<Resteraunt>().AsQueryable<Resteraunt>();
            var property = typeof(Resteraunt).GetProperty("Deleted");

            if (property != null)
            {
                query = query.Where(GetExpression("Deleted", null));
            }

            return query;
        }

        protected virtual void SaveChanges()
        {
            this.dataContext.SaveChanges();
        }
        #endregion
    }






















}

