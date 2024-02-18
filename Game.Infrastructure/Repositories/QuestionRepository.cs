using Game.Domain.Entities;
using Game.Domain.Interfaces;
using Game.Persistence;

namespace Game.Infrastructure.Repositories
{
    public class QuestionRepository : RepositoryBase<Question>, IQuestionRepository
    {
        public QuestionRepository(GameContext context) : base(context)
        {
        }
    }
    public class GamerRepository : RepositoryBase<Gamer>, IGamerRepository
    {
        public GamerRepository(GameContext context) : base(context)
        {
        }
    }
}
