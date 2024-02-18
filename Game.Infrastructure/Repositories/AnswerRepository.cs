using Game.Domain.Entities;
using Game.Domain.Interfaces;
using Game.Persistence;

namespace Game.Infrastructure.Repositories
{
    public class AnswerRepository : RepositoryBase<Answer>, IAnswerRepository
    {
        public AnswerRepository(GameContext context) : base(context)
        {
        }
    }
}
