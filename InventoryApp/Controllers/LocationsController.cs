﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InventoryApp.Data;
using InventoryApp.Models;

namespace InventoryApp.Controllers
{
    public class LocationsController : ApiController
    {
        private IInventoryRepository _repo;

        public LocationsController(IInventoryRepository repo)
        {
            _repo = repo;
        }
        [Route("api/v1/locations")]
        public IEnumerable<Location> Get()
        {
            var locationList = _repo.GetLocations().ToList();
            return locationList;
        }

        [Route("api/v1/locations/{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [Route("api/v1/locations")]
        public void Post([FromBody]string value)
        {
        }

        [Route("api/v1/locations/{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [Route("api/v1/locations/{id}")]
        public void Delete(int id)
        {
        }
    }
}