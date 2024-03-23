using Mobile_Shop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mobile_Shop.ApiControllers
{
    public class ShopController : ApiController
    {
        // GET api/<controller>
        public ICollection<SANPHAM> Get()
        {
            DB_ShopMobileEntities db = new DB_ShopMobileEntities();
            ICollection<SANPHAM> sANPHAMs = db.SANPHAMs.ToHashSet();
            return sANPHAMs;
        }

        // GET api/<controller>/5
        public SANPHAM Get(int id)
        {
            DB_ShopMobileEntities db = new DB_ShopMobileEntities();
            SANPHAM sanpham = db.SANPHAMs.Where(row => row.MaSP == id).FirstOrDefault();
            return sanpham;
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}