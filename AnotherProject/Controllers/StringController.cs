using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AnotherProject.Controllers
{
    public class StringController : ApiController
    {
        //GOAL: configure a certain response for an input HTTP request

        //what the input is going to look like
        // GET localhost:xx/api/string/{sean}

        //the output is going to look like
        // "Hello sean!"

        public string Get(string id)
        {
            string message = "Hello " + id + "!";
            return message;
        }


       

        /// <summary>
        /// An example post request to the webserver
        /// </summary>
        /// <returns>
        /// "Post Request"
        /// </returns>
        /// <example>
        /// POST: localhost:xx/api/string => "Post Request!"
        /// </example>

        public string Post()
        {
            return "Post Request!";
        }


    }
}
