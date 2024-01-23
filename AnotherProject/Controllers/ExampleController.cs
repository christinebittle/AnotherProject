using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AnotherProject.Controllers
{
    public class ExampleController : ApiController
    {

        /// <summary>
        /// This method will return the value -1
        /// </summary>
        /// <returns>
        /// -1
        /// </returns>
        /// <example>
        /// GET: localhost:xx/api/example => -1
        /// </example>
        public int Get()
        {
            return -1;
        }


        /// <summary>
        /// Receives an input number and returns that number divided by 2. Truncates the result to an integer
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>
        /// The number divided by 2.
        /// </returns>
        /// <example>
        /// GET: localhost:xx/api/example/8 => 4
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/example/10 => 5
        /// </example> 
        /// <example>
        /// GET: localhost:xx/api/example/-16 => -8
        /// </example> 
        /// <example>
        /// GET: localhost:xx/api/example/-11 => -5
        /// </example> 
        public int Get(int id)
        {
            int result = id / 2;
            return result;
        }
    }
}
