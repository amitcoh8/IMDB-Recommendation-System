namespace IMDB.Recommendations.Api.Communication
{
    public class BaseResponse
    {
        public bool Success { get; } = true;
        public string[] ErrorMessages { get; }
    }
}