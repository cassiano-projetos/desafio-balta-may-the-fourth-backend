namespace desafio_shared.Entities
{
    public class Character : Entity
    {
        public Character(int id,string name,
            string height,
            string weight,
            string hairColor,
            string skinColor,
            string eyeColor,
            string birthYear,
            string gender) : base(id)
        {
            Name = name;
            Height = height;
            Weight = weight;
            HairColor = hairColor; 
            SkinColor = skinColor;
            EyeColor = eyeColor;
            BirthYear = birthYear;
            Gender = gender;
        }

        public string Name { get; private set; } = string.Empty;
        public string Height { get; private set; } = string.Empty;
        public string Weight { get; private set; } = string.Empty;
        public string HairColor { get; private set; } = string.Empty;
        public string SkinColor { get; private set; } = string.Empty;
        public string EyeColor { get; private set; } = string.Empty;
        public string BirthYear { get; private set; } = string.Empty;
        public string Gender { get; private set; } = string.Empty;

        public IEnumerable<Movie> Movies { get; private set; } 
        
        public int PlanetId { get; private set; }
        public Planet Planet { get; private set; }
    }
}
