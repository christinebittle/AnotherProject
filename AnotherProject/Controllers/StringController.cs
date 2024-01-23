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


        //GOAL:
        //method which serves:
        //POST localhost:xx/api/string => "Post Request!"

        public string Post()
        {
            return "Post Request!";
        }


    }
}
