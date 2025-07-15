using API_RandMpersonajesBack.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API_RandMpersonajesBack.Controllers
{
    [Route("Api/[controller]")]

    public class PersonajesController : Controller
    {
        private HttpClient _httpcliente;

        public PersonajesController()
        {
            _httpcliente = new HttpClient();
        }

        [HttpGet]
        [Route("Personajes")]
        public async Task<Personajes> Getall()
        {
            try
            {
                Personajes personajes = null;

                HttpResponseMessage httpResponse =
                    await _httpcliente.GetAsync("https://rickandmortyapi.com/api/character");
                httpResponse.EnsureSuccessStatusCode();
                string respondebody = await httpResponse.Content.ReadAsStringAsync();
                personajes = JsonConvert.DeserializeObject<Personajes>(respondebody);
                return personajes;
            }
            catch (Exception) {
                throw;
            }

        }
       
    }
}
