using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Videos.Controllers
{
    public class VideosController : ApiController
    {

        public class Video
        {
            public int Id { get; set; }
            public string Title { get; set; }
        }
        // GET: api/Video
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Video/5
        public string Get(int id)
        {
            return "value" + " "+ id.ToString();
        }

        // POST: api/Video
        public Video Post(Video video)
        {
            return video;
        }

        // PUT: api/Video/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Video/5
        public void Delete(int id)
        {
        }
    }
}
