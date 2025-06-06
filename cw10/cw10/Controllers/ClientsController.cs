using cw10.Exception;
using cw10.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService _service;
        
        public ClientsController(IClientService service)
        {
            _service = service;
        }
        
        [HttpDelete("{IdClient}")]
        public async Task<IActionResult> Delete(int IdClient)
        {
            try
            {
                await _service.DeleteClientIfHaveNotTrips(IdClient);
                return NoContent();
            }
            catch (NotFoundEX e)
            {
                return NotFound(e.Message);
            }
            catch (ConflictEX e)
            {
                return Conflict(e.Message);
            }
        }
    }
}
