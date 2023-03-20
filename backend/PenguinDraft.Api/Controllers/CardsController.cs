using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PenguinDraft.Api.Dtos;
using PenguinDraft.Api.Models;
using PenguinDraft.Api.Services;

namespace PenguinDraft.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CardsController : ControllerBase
  {
    private readonly ICardService _cardService;
    private readonly IMapper _mapper;


    public CardsController(ICardService cardService, IMapper mapper)
    {
      _cardService = cardService;
      _mapper = mapper;
    }

    [HttpGet("GetAll")]
    public ActionResult<List<Card>> GetAllCards()
    {
      return Ok(_cardService.GetAllCards());
    }

    [HttpGet("{cardId}")]
    public ActionResult<List<Card>> GetCard(int cardId)
    {
      return Ok(_cardService.GetCardById(cardId));
    }

    [HttpPost]
    public ActionResult<List<Card>> AddCard(Card newCard)
    {
      return Ok(_cardService.AddCard(newCard));
    }

    // [HttpGet]
    // [ProducesResponseType(200, Type = typeof(IEnumerable<Card>))]
    // public IActionResult GetAllCards()
    // {
    //   var cards = _mapper.Map<List<CardDto>>(_cardRepository.GetAllCards());

    //   if (!ModelState.IsValid)
    //     return BadRequest(ModelState);

    //   return Ok(cards);
    // }

    // [HttpGet("{cardId}")]
    // [ProducesResponseType(200, Type = typeof(Card))]
    // [ProducesResponseType(400)]
    // public IActionResult GetCardById(int cardId)
    // {
    //   if (!_cardRepository.CardExists(cardId))
    //     return NotFound();

    //   var card = _mapper.Map<CardDto>(_cardRepository.GetCardById(cardId));

    //   if (!ModelState.IsValid)
    //     return BadRequest(ModelState);

    //   return Ok(card);
    // }
  }
}