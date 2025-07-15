namespace API_RandMpersonajesBack.Models
{
    public class Personajes
    {
        public Info info { get; set; } = null;
        public List<Personaje> Results {  get; set; }
        public class Info
        {
            public int count { get; set; }
            public int pages { get; set; }
            public string next { get; set; }
            public string prev { get; set; }

        }
      
            

       
    }
}
