using Auctions.Api.UseCases;
using Auctions.Api.UseCases.Auctions.GetCurrent;
using Microsoft.AspNetCore.Mvc;

namespace Auctions.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCurrentAction()
        {
            var useCase = new GetCurrentAuctionUseCase();
            
            var result = useCase.Execute();

            return Ok(result);
            
        }
    }
}
