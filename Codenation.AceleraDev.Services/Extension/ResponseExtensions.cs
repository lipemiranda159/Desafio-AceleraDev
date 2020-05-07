using Condenation.AceleraDev.Domain.Models;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace Codenation.AceleraDev.Services.Extension
{
    public static class ResponseExtensions
    {
        public static Stream ToStream(this Response response)
        {
            var byteArray = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(response));
            var stream = new MemoryStream(byteArray);
            return stream;
        }
        public static byte[] ToByteArray(this Response response)
        {
            var byteArray = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(response));
            
            return byteArray;
        }
    }
}
