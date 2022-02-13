using Microsoft.EntityFrameworkCore;
using RestaurantApp.BL.EF;
using System.ComponentModel;

namespace RestaurantApp.BL.Controller
{
    public class EntityController<T>
        where T : class
    {
        public RestaurantAppContext Db { get; }

        public DbSet<T> Table { get; }

        public EntityController(RestaurantAppContext context)
        {
            Db = context;
            Table = Db.Set<T>();
            Table.Load();
        }

        public IEnumerable<T> GetAll() => Table.Local.ToBindingList();

        public T GetOne(object id) => Table.Find(id);

        public void Update() => Db.SaveChanges();

        public void AddRecord(T entity)
        {
            if (entity != null)
            {
                Table.Add(entity);
                Db.SaveChanges();
            }
        }

        public void RemoveRecord(T entity)
        {
            if (entity != null)
            {
                Table.Remove(entity);
                Db.SaveChanges();
            }
        }

    }
}
