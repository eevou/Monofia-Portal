using AutoMapper;
using Menofia_Portal.Core.Entities;
using Menofia_Portal.Core.Interfaces;
using Menofia_Portal.Core.Specification;
using Microsoft.AspNetCore.Mvc;
using Monofia_Portal.Services.DTOs;

namespace Monofia_Portal.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly IGenericRepository<PortalNews> _repository;
        private readonly IMapper _mapper;

        public NewsController(IGenericRepository<PortalNews> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<NewsDto>>> GetAll(DateTime? dateTime)
        {
            var spec = new NewsWithTranslationSpecification(dateTime);
            var news = await _repository.GetAllAsync(spec);
            var mappedData = _mapper.Map<IEnumerable<NewsDto>>(news);
            return Ok(mappedData);
        }
    }
}
