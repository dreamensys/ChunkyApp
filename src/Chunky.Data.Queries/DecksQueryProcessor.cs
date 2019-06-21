using System;
using System.Data;
using System.Linq;
using Chunky.Data.Model;
using System.Threading.Tasks;
using Chunky.Data.Access.DAL;

namespace Chunky.Data.Queries
{
    public class DecksQueryProcessor : IDecksQueryProcessor
    {
        private readonly IUnitOfWork _uow;
        //private readonly ISecurityContext _securityContext;
        public DecksQueryProcessor(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public IQueryable<Deck> Get()
        {
            var query = GetQuery();
            return query;
        }
        private IQueryable<Deck> GetQuery()
        {
            var q = _uow.Query<Deck>();
            return q;
        }
        public Deck Get(int id)
        {
            var deck = GetQuery().FirstOrDefault(x=>x.Id==id);
            if(deck == null){
                //return new NotFoundException("Deck not found");
                throw new Exception();
            }
            return deck;
        }
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}