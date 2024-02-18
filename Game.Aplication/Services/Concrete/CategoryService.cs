using AutoMapper;
using Game.Aplication.Dto.Category;
using Game.Aplication.Services.Abstract;
using Game.Domain.Entities;
using Game.Domain.Interfaces;

namespace Game.Aplication.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository category, IMapper mapper)
        {
            _categoryRepository = category;
            _mapper = mapper;
        }
        public async Task AddAsync(CategoryAddRequest categoryAddRequest)
        {
            Category category = _mapper.Map<Category>(categoryAddRequest);
            await _categoryRepository.CreateAsync(category);
        }

        public async Task DeleteByIdAsync(int id)
        {
            Category category = await _categoryRepository.FindByIdAsync(id);
            await _categoryRepository.DeActivate(category);
        }

        public async Task EditAsync(CategoryUpdateRequest categoryUpdateRequest)
        {
            Category category = _mapper.Map<Category>(categoryUpdateRequest);
            await _categoryRepository.UpdateAsync(category);
        }

        public async Task<CategoryTableResponse> GetCategoryById(int id)
        {
            Category category = await _categoryRepository.FindByIdAsync(id);
            CategoryTableResponse result=_mapper.Map<CategoryTableResponse>(category);

            return result;
        }

        public async Task<List<CategoryTableResponse>> GetTable()
        {
            List<Category> categories = await _categoryRepository.FindAllActiveAsync();
            List<CategoryTableResponse> result = _mapper.Map<List<CategoryTableResponse>>(categories);

            return result;
        }
    }
}
