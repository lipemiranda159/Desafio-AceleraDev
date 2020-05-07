using Condenation.AceleraDev.Domain.Models;
using RestEase;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Codenation.AceleraDev.Services
{
    public interface IAceleraDevApiService
    {
        /// <summary>
        /// Get data from api
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [Get("generate-data")]
        Task<Response> GetDataAsync([Query]string token);

        [Header("Content-Disposition", "form-data; filename=\"answer.json\"")]
        [Header("Content-Type", "text/plain")]
        [Post("submit-solution")]
        Task UploadFileVersionOneAsync([Body] Stream file, [Query] string token);
    }
}
