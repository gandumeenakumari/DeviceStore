//using DeviceStore.Data;
//using DeviceStore.Repositories;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.JsonPatch;
//using Microsoft.AspNetCore.Mvc;

//namespace DeviceStore.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    [Authorize]
//    public class DeviceController : ControllerBase
//    {
//        private readonly IMobileRepository _mobileRepository;

//        public DeviceController(IMobileRepository mobileRepository)
//        {
//            _mobileRepository = mobileRepository;
//        }

//        [HttpGet("")]

//        public async Task<IActionResult> GetAllMobilesAsync()
//        {
//            var mobiles = await _mobileRepository.GetAllMobilesAsync();
//            return Ok(mobiles);
//        }

//        [HttpGet("{id}")]
//        public async Task<IActionResult> GetMobilesByIdAsync([FromRoute] int id)
//        {
//            var mobile = await _mobileRepository.GetMobilesByIdAsync(id);
//            if (mobile == null)
//            {
//                return NotFound();
//            }
//            return Ok(mobile);
//        }

//        [HttpPost("")]
//        public async Task<IActionResult> AddMobileAsync([FromBody] Mobile mobileModel)
//        {
//            var id = await _mobileRepository.AddMobileAsync(mobileModel);
//            return CreatedAtAction(nameof(GetMobilesByIdAsync), new { MobileId = id, controller = "" }, id);
//        }

//        [HttpPut("{id}")]
//        public async Task<IActionResult> UpdateMobileAsync([FromBody] Mobile mobileModel, [FromRoute] int mobileId)
//        {
//            await _mobileRepository.UpdateMobileAsync(mobileId, mobileModel);
//            return Ok();
//        }

//        [HttpPatch("{MobileId}")]
//        public async Task<IActionResult> UpdateMobilePatchAsync([FromBody] JsonPatchDocument mobileModel, [FromRoute] int mobileId)
//        {
//            await _mobileRepository.UpdateMobilePatchAsync(mobileId, mobileModel);
//            return Ok();
//        }

//        [HttpDelete("{MobileId}")]
//        public async Task<IActionResult> DeleteMobileAsync([FromRoute] int mobileId)
//        {
//            await _mobileRepository.DeleteMobileAsync(mobileId);
//            return Ok();
//        }
//    }
//}
