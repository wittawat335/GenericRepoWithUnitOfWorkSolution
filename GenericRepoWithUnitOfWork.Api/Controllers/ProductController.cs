using GenericRepoWithUnitOfWork.Domain.RepositoryInterfaces;
using GenericRepoWithUnitOfWork.Infra.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepoWithUnitOfWork.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var result = _unitOfWork.Product.GetAll();
            return Ok(result);
        }

        [HttpGet("ProductWithCategory")]
        public ActionResult GetWithCategory()
        {
            var result = _unitOfWork.Product.GetProductWithCategory();
            return Ok(result);
        }
    }
}
