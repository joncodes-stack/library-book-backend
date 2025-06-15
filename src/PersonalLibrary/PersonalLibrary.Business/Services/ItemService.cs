using AutoMapper;
using PersonalLibrary.Domain.Dtos;
using PersonalLibrary.Domain.Entities;
using PersonalLibrary.Domain.Interface;
using PersonalLibrary.Domain.Interface.Repository;
using PersonalLibrary.Domain.Interface.Service;
using PersonalLibrary.Domain.Services;


namespace PersonalLibrary.Application.Services
{
    public class ItemService : BaseService, IItemService
    {
        private readonly IItemRepository _itemRepository;
        private readonly IMapper _mapper;

        public ItemService(INotificador notificador, IItemRepository bookRepository, IMapper mapper) : base(notificador)
        {
            _itemRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task Add(ItemDto itemDto)
        {
            var item = _mapper.Map<Item>(itemDto);

            await _itemRepository.Add(item);
        }

        public async Task Update(ItemDto itemDto)
        {
            var item = _mapper.Map<Item>(itemDto);

            await _itemRepository.Update(item);
        }

        public async Task Delete(Guid id)
        {
            var book = await _itemRepository.GetById(id);

            await _itemRepository.Delete(id);
        }

        public async Task<IEnumerable<ItemDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<ItemDto>>(await _itemRepository.GetAll());
        }

        public async Task<ItemDto> GetById(Guid id)
        {
            return _mapper.Map<ItemDto>(await _itemRepository.GetById(id));
        }

        public async Task<IEnumerable<ItemDto>> GetByUser(Guid idUser)
        {
            return _mapper.Map<IEnumerable<ItemDto>>(await _itemRepository.GetItemByUser(idUser));
        }

        public void Dispose()
        {
            _itemRepository.Dispose();
        }
    }
}
