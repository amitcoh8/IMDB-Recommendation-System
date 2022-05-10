namespace IMDB.Recommendations.Domain.Entities
{
    public class UserPreferences
    {
        public string[] Genres { get; set; }
        public string[] Actors { get; set; }
        public string[] Directors { get; set; }
        public string[] Movies { get; set; }
    }
}