using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_AE6.Models
{
    public class AddToStore
    {
        public AddToStore()
        {
            albums = new List<Album>();
        }

        public int StoreId { get; set; }

        public int AlbumId { get; set; }

        public ICollection <Album> albums { get; set; }
    }
}