using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Domain.Entities
{
    public class Gamer : BaseEntity
    {
        public string UserName { get; set; }
        public List<int>? AskedQuestions { get; set; }

       
    }
}
