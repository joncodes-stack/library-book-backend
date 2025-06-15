using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PersonalLibrary.Api.Controllers;
using PersonalLibrary.Domain.Dtos;
using PersonalLibrary.Domain.Interface;
using PersonalLibrary.Domain.Interface.Service;

namespace LibraryBook.Api.Controllers
{
    [Route("api/item")]
    [ApiController]
    public class ItemController : BaseController
    {
        private readonly IItemService _itemService;
        private readonly IMapper _mapper;

        public ItemController(INotificador notificador,
                              IItemService bookService,
                              IMapper mapper) :base(notificador) 
        {
            _itemService = bookService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ItemDto> GetItemById(Guid idUser)
        {
            return _mapper.Map<ItemDto>(await _itemService.GetById(idUser));
        }

        [HttpGet("get-item-by-user")]
        public async Task<IEnumerable<ItemDto>> GetItemByUser(Guid idUser)
        {
            return _mapper.Map<IEnumerable<ItemDto>>(await _itemService.GetByUser(idUser));
        }

        [HttpPost]
        public async Task<ActionResult> Add(ItemDto itemDto)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _itemService.Add(itemDto);

            return CustomResponse("Dados do livro cadastrado com sucesso");
        }

        [HttpPut]
        public async Task<IActionResult> Update(ItemDto itemDto)
        {
            if (string.IsNullOrEmpty(itemDto.Id.ToString()))
            {
                return BadRequest("Id do item é obrigatório");
            }

            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _itemService.Update(itemDto);

            return CustomResponse("Dados do livro Atualizado com sucesso!");
        }

        [HttpDelete]
        public async Task<IActionResult> Remove(Guid id)
        {           
            await _itemService.Delete(id);

            return CustomResponse("Dados do livro Atualizado com sucesso!");
        }

    }
}
