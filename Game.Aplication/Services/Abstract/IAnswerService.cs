using Game.Aplication.DTOs.Answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Aplication.Services.Abstract
{
    public interface IAnswerService 
    {
        Task AddAsync(AnswerAddRequest answerAddRequest);
        Task EditAsync(AnswerUpdateRequest answerUpdateRequest);
        Task<AnswerTableResponse> GetAnswerById(int id);
        Task<List<AnswerTableResponse>> GetTable();
        Task DeleteByIdAsync(int id);
    }
}
