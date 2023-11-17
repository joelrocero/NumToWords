using Microsoft.AspNetCore.Mvc;
using NumToWords.Services;

namespace NumToWords.Controllers
{
    [Route("api/[controller]")]
    public class NumtoWordsController : ControllerBase
    {
        private readonly INumberToWordsService _numberToWordsService;

        public NumtoWordsController(INumberToWordsService numberToWordsService)
        {
            _numberToWordsService = numberToWordsService;
        }

        public INumberToWordsService NumberToWordsService { get; }

        [HttpGet("{num:double}")]
        public IActionResult GetNumber(double num)
        {
            try
            {
                var result = _numberToWordsService.ConvertNumberToWords(num);
                return Ok(new { result});
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
