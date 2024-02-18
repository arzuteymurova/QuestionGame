using Game.Domain.Entities;
using Game.Domain.Interfaces;
using Game.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Infrastructure.Repositories
{
    public class DifficultyLevelRepository : RepositoryBase<DifficultyLevel>, IDifficultyLevelRepository
    {
        public DifficultyLevelRepository(GameContext context) : base(context)
        {
        }
    }
}
