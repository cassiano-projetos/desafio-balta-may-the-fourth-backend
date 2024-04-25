using desafio_backend.ViewModels.MovieViewModel;

namespace desafio_backend.ViewModels
{
    public class CharacterViewModel
    {
        public CharacterViewModel(string name, string height, string weight, string hairColor, string skinColor, string eyeColor, string birthYear, string gender)
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

        public BasicInfoViewModel Planet { get; set; } = new BasicInfoViewModel();
        public IEnumerable<BasicMovieInfoViewModel> Movies { get; set; } = Enumerable.Empty<BasicMovieInfoViewModel>();

    }
}
