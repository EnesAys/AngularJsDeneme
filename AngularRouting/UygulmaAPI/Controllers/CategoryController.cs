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
    [RoutePrefix("api")][EnableCors("*","*","*")]
    public class CategoryController : ApiController
    {

        [Route("kategoriler")]
        public IHttpActionResult GetCategoryList()
        {
            using (ProjectContext db = new ProjectContext())
            {

                var model = db.Categories.Select(a => new CategoryModel
                {
                    Id = a.CategoryID,
                    Name = a.CategoryName

                }).ToList();

                return Json(model);
            }
           
        }

    }
}
