using Microsoft.EntityFrameworkCore;
using RestaurantApp.BL.EF;

namespace RestaurantApp.BL.Controller
{
    public class EntityController<T>
        where T : class
    {
        private readonly DbSet<T> table;
        private readonly RestaurantAppContext db;

        public EntityController(RestaurantAppContext context)
        {
            db = context;
            table = db.Set<T>();
            table.Load();
        }

        public IEnumerable<T> GetAll() => table.Local.ToBindingList();

        public T GetOne(object id) => table.Find(id);

        public void Update() => db.SaveChanges();

        public void AddRecord(T entity)
        {
            if (entity != null)
            {
                table.Add(entity);
                db.SaveChanges();
            }
        }

        public void RemoveRecord(T entity)
        {
            if (entity != null)
            {
                table.Remove(entity);
                db.SaveChanges();
            }
        }

    }
}
