namespace BlazorDbzPersonagem.Models
{
    public class Transformacao
    {
        public string Name { get; set; }
    }

    public class Planet
    {
        public string Name { get; set; }
    }

    public class Personagem
    {
        public string Name { get; set; }
        public Planet OriginPlanet { get; set; }
        public List<Transformacao> Transformations { get; set; }
    }
}
