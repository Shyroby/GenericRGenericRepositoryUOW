using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericRepositoryDemo.DAL;
using GenericRepositoryDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepositoryDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        [HttpGet]
        public IEnumerable<Documents> index()
        {
            var documents = unitOfWork.DocumentsRepository.Get();
            return documents.ToArray();

        }
        [HttpGet("{id}")]
        public Documents Detail(string id)
        {
            var query = "SELECT * FROM Documents WHERE Id = @p0";
            var document = unitOfWork.DocumentsRepository.GetWithRawSql(query, id).Single();
            return document;
        }
    }
}