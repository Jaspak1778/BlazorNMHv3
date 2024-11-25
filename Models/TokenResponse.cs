using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MauiApp3.Models
{
    public class TokenResponse
    {
        [JsonPropertyName("access")]
        public string Access { get; set; }

        [JsonPropertyName("refresh")]
        public string Refresh { get; set; }
    }
}
