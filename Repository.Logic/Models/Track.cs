namespace Repository.Logic.Models
{
    public class Track : ModelObject
    {
        public int AlbumId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Musician { get; set; } = string.Empty;
        public Genre Genre { get; set; }
        public override string ToString()
        {
            return $"{Name} {Musician} {Genre}";
        }
    }
}
