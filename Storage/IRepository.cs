using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IRepository
    {
        void Save(IEntity entity);
        void SaveMore(List<IEntity> entities);
        int GetNewId(IEntity entity);
        void Delete(IEntity entity, int id);
        void Update(IEntity entity);

        List<IEntity> GetAll(IEntity entity);
    }
}
