using MVC_AE3_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_AE3_EF.Models
{
    public class ClientMovie
    {
        public ClientMovie()
        {
            clients = new List<Client>();
        }

        public int MovieId { get; set; }

        public Movie movie { get; set; }

        public int ClientId { get; set; }

        public List<Client> clients { get; set; }


    }
}