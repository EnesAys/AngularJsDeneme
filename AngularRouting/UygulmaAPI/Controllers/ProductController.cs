using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using UygulmaAPI.Data;
using UygulmaAPI.Models;

namespace UygulmaAPI.Controllers
{
    [RoutePrefix("api")]
    [EnableCors("*", "*", "*")]
    //api ön takısını koyarız.
    public class ProductController : ApiController
    {
        //method önüne yazılan GET ile HttpGet işlemi yaparız
        //Default dönüş formatımız xml eğer return json yaparsak veriler json formatına serilize edilir. 

        [Route("kategorideki-urunler/{id}")]
        public IHttpActionResult GetListByCategoryId(int id)
        {
            using (ProjectContext db = new ProjectContext())
            {
                var model = db.Products.Where(x => x.CategoryID == id).Select(a => new ProductModel
                {
                    Id = a.ProductID,
                    Name = a.ProductName,
                    Price = a.UnitPrice

                }).ToList();

                return Ok(model);
            }

        }
    }
}
