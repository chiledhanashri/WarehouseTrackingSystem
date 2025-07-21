using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Warehouse_WebAPI.Controllers
{
[ApiController]
    [Route("api/[controller]")]
    public class VendorController : ControllerBase
    {
        private readonly IVendorService _vendorService;
 
        public VendorController(IVendorService vendorService)
        {
            _vendorService = vendorService;
        }
 
        [HttpGet]
        public async Task<IActionResult> GetVendors() => Ok(await _vendorService.GetAllVendorsAsync());
 
        [HttpPost]
        public async Task<IActionResult> AddVendor(VendorDto dto)
        {
            await _vendorService.AddVendorAsync(dto);
            return Ok();
        }
    }

    public interface IVendorService
    {
    }
}