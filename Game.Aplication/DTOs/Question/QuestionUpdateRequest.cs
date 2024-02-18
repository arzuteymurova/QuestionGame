using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Aplication.DTOs.Question
{
    public class QuestionUpdateRequest
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public int DifficultyLevelId { get; set; }
    }
}
