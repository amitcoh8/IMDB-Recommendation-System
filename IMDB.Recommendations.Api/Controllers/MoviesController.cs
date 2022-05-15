using System.Threading.Tasks;
using IMDB.Recommendations.Application.Features.GetRecommendedMovie;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMDB.Recommendations.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MoviesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("recommendation", Name = nameof(GetMovieRecommendation))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<MovieDto>> GetMovieRecommendation()
        {
            return Ok(new MovieDto());
        }
    }
}