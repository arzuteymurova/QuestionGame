using Game.Aplication.Dto.Category;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Aplication.Services.Abstract
{
    public interface ICategoryService
    {
        Task AddAsync(CategoryAddRequest categoryAddRequest);
        Task EditAsync(CategoryUpdateRequest categoryUpdateRequest);
        Task<CategoryTableResponse> GetCategoryById(int id);
        Task<List<CategoryTableResponse>> GetTable();
        Task DeleteByIdAsync(int id);
    }
}
