using System;
using Microsoft.AspNetCore.Http;

namespace Tombini.Jacopo._5H.Secondaweb.Models
{
    public class CreatePost
    {
        public IFormFile MyCSV {get; set;}
        public string Descrizione { get; set; }

    }
}