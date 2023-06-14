using Microsoft.AspNetCore.Mvc;
using UnitTest_Demo.Data.Interface;
using UnitTest_Demo.Model;

namespace UnitTest_Demo.Controllers
{
    [ApiController]
    public class MangaController : Controller
    {
        public readonly IManga _mangaService;
        public MangaController(IManga manga) 
        {
            _mangaService = manga;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = _mangaService.GetAll();
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Post")]
        public async Task<IActionResult> Post([FromBody] Manga manga)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _mangaService.Post(manga);
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Put")]
        public async Task<IActionResult> Put([FromBody] Manga manga)
        {
            try
            {
                var newManga = _mangaService.Put(manga);
                return Ok(newManga);
            } catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int mangaId)
        {
            try
            {
                var deleteManga = _mangaService.Delete(mangaId);
                return Ok(deleteManga);
            }
            catch(Exception ex)
            {
                return NotFound();
            }
        }
    }
}
