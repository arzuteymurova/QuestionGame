using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Aplication.DTOs.Question
{
    public class QuestionAddRequest
    {
        public string Content { get; set; }

       public int DifficultyId { get; set; }    
    }
}
