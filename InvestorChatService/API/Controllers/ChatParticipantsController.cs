using InvestorChatService.Application.Interfaces;
using InvestorChatService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvestorChatService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatParticipantsController(IChatParticipantService chatParticipantService) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var participants = chatParticipantService.GetAllParticipants();

            return Ok(participants);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromBody]int id)
        {
            var participant = await chatParticipantService.GetParticipantByIdAsync(id);

            return Ok(participant);
        }

        [HttpPost]
        public async Task<IActionResult> AddParticipant([FromBody]ChatParticipant chatParticipant)
        {
            await chatParticipantService.AddParticipantAsync(chatParticipant);

            return CreatedAtAction("Participant created!", chatParticipant);
        }
    }
}
