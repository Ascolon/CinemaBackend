using BackendPart.Models;
using System.Linq;
using System.Web.Http;

namespace BackendPart.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/<controller>
        CinemaContext context = new CinemaContext();
        public IQueryable<Movie> Get()
        {
            context.Configuration.ProxyCreationEnabled = false;
            return context.Movies;
        }
        

    }
}