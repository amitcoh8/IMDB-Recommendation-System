using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using IMDB.Recommendations.Application.Contracts.Data;
using IMDB.Recommendations.Application.Contracts.Persistance;
using MediatR;

namespace IMDB.Recommendations.Application.Features.GetRecommendedMovie
{
    public class GetRecommendedMovieHandler : IRequestHandler<GetRecommendedMovieQuery, MovieDto>
    {
        private readonly IMapper _mapper;
        private readonly IMoviesDataProvider _moviesDataProvider;
        private readonly IUserFavoritesRepository _userFavoritesRepository;
        private readonly IRecommendedMoviesRepository _recommendedMoviesRepository;

        public GetRecommendedMovieHandler(IMapper mapper , IMoviesDataProvider moviesDataProvider, IUserFavoritesRepository userFavoritesRepository, IRecommendedMoviesRepository recommendedMoviesRepository)
        {
            _mapper = mapper;
            _moviesDataProvider = moviesDataProvider;
            _userFavoritesRepository = userFavoritesRepository;
            _recommendedMoviesRepository = recommendedMoviesRepository;
        }
        
        public Task<MovieDto> Handle(GetRecommendedMovieQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}