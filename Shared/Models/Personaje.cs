namespace API_RandMpersonajesBack.Models
{
   
        public class Origin
        {
            public string name { get; set; }
            public string url { get; set; }

        }
        public class Location
        {
            public string name { get; set; }
            public string url { get; set; }

        }
        public class Personaje
        {
            public int id { get; set; }
            public string name { get; set; }
            public string status { get; set; }
            public string species { get; set; }
            public string type { get; set; }
            public string gender { get; set; }
            public Origin origin { get; set; }
            public Location location { get; set; }
            public string image { get; set; }
            public IList<string> episode { get; set; }
            public string url { get; set; }
            public DateTime created { get; set; }
            
            public int puntaje { get; set; } = 0;

            public int likes { get; set; } = 0;
            
            public int dislikes { get; set; } = 0;

        }
    }

