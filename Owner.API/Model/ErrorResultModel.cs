﻿using System.Text.Json;

namespace Owner.API.Model
{
    public class ErrorResultModel
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
