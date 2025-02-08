using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Api.DTOs;
using AutoMapper;
namespace AdminPanel.Api.Controllers{
    [ApiController]
    [Route("dotnetapi/[controller]")]
    public class UploadController:ControllerBase{
        private readonly IUploadService _service;
        private readonly IMapper _mapper;
        public UploadController(IUploadService service, IMapper mapper) => (_service, _mapper) = (service, mapper);
        [HttpPost("upload-base64")]
        public async Task<IActionResult> UploadBase64(IFormFile file){
            if (file == null || file.Length == 0){
                return BadRequest("File is empty");
            }
            try{
                using MemoryStream memoryStream = new ();
                await file.CopyToAsync(memoryStream);
                byte[] base64Content = memoryStream.ToArray();


                Base64FileUploadDto dto = new(){
                    FileName = file.FileName,
                    Base64Content = base64Content
                };

                Upload upload = await _service.CreateAsync(_mapper.Map<Upload>(dto));

                return Created(nameof(UploadBase64), upload);
            }
            catch (Exception ex){
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}