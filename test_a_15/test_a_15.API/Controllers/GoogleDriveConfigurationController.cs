using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using test_a_15.DTO;
using test_a_15.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace test_a_15.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoogleDriveConfigurationController : ControllerBase
    {
        private readonly GoogleDriveConfigurationService _service;
        public GoogleDriveConfigurationController(GoogleDriveConfigurationService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult CreateGoogleDriveConfiguration(GoogleDriveConfiguration config)
        {
            int id = _service.CreateGoogleDriveConfiguration(config);
            return Ok(id);
        }

        [HttpGet]
        public IActionResult ReadGoogleDriveConfiguration(int id)
        {
            GoogleDriveConfiguration config = _service.ReadGoogleDriveConfiguration(id);
            return Ok(config);
        }

        [HttpPut]
        public IActionResult UpdateGoogleDriveConfiguration(GoogleDriveConfiguration config)
        {
            _service.UpdateGoogleDriveConfiguration(config);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteGoogleDriveConfiguration(int id)
        {
            _service.DeleteGoogleDriveConfiguration(id);
            return Ok();
        }
    }
}