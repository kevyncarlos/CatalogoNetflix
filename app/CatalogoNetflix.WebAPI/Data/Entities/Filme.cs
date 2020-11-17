namespace CatalogoNetflix.WebAPI.Data.Entities
{
    public class Filme : Entity
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string RatingLevel { get; set; }
        public string RantingDescription { get; set; }
        public string ReleaseYear { get; set; }
        public string UserRatingScore { get; set; }
        public string UserRatingSize { get; set; }
    }
}
