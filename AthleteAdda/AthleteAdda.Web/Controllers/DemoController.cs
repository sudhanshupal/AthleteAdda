﻿using AthleteAdda.Web.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AthleteAdda.Data;
using System.Linq;

namespace AthleteAdda.Web.Controllers
{
    public class DemoController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage ContextualizeDashboard()
        {
            try
            {
                List<AthleteAdda.Data.Newsfeed> newFeeds = new List<AthleteAdda.Data.Newsfeed>();
                using (AthleteAddaTestEntities db = new AthleteAddaTestEntities())
                {
                    newFeeds = db.Newsfeeds.ToList();
                }
                int newFeedCount = newFeeds.Count;

                return Request.CreateResponse(HttpStatusCode.OK, new
                {
                    newFeeds,
                    newFeedCount
                });


                


                //var peoples = new List<People>();

                //peoples.Add(new People { Age = 211, Responsibility = "Developer", FirstName = "Vinicius", LastName = "Tavares" });
                //peoples.Add(new People { Age = 25, Responsibility = "Software Designer", FirstName = "Hugo", LastName = "Takahashi" });
                //peoples.Add(new People { Age = 38, Responsibility = "Developer", FirstName = "Denis", LastName = "Souza" });
                //peoples.Add(new People { Age = 40, Responsibility = "DBA", FirstName = "Raphael", LastName = "Oliveira" });
                //peoples.Add(new People { Age = 25, Responsibility = "Consultant", FirstName = "Cleber", LastName = "Souza" });
                //peoples.Add(new People { Age = 21, Responsibility = "Web Design", FirstName = "Gustavo", LastName = "Sampaio" });

                //const int messageCount = 121;

                //return Request.CreateResponse(HttpStatusCode.OK, new
                //{
                //    peoples,
                //    messageCount
                //});
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.OK, e);

            }
        }
    }
}
