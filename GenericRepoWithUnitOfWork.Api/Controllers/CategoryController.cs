using GenericRepoWithUnitOfWork.Domain.RepositoryInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepoWithUnitOfWork.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var result = _unitOfWork.Category.GetAll();
            return Ok(result);
        }

        [HttpGet("ProductWithCategory")]
        public ActionResult GetWithCategory()
        {
            var result = _unitOfWork.Category.GetCategoryWithProduct();
            return Ok(result);
        }
    }
}
