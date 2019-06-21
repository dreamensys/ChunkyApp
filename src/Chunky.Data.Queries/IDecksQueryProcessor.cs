using Chunky.Data.Model;
using System;
using System.Linq;
using System.Data;
using System.Threading.Tasks;

namespace Chunky.Data.Queries
{
    public interface IDecksQueryProcessor
    {
         IQueryable<Deck> Get();
         Deck Get(int id);
        //  Task<Deck> Create(CreateDeckModel model);
        //  Task<Deck> Update(int id, UpdateDeckModel model);
         Task Delete(int id);
    }
}