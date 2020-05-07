using Condenation.AceleraDev.Domain.Models;
using RestEase;
using System;
using System.IO;
using System.Net.Http;
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
        /// <summary>
        /// Post response
        /// </summary>
        /// <param name="file"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        [Header("Content-Disposition", "form-data; file=answer")]
        [Header("Content-Type", "multipart/form-data")]
        [Post("submit-solution")]
        Task<HttpResponseMessage> UploadFileAsync([Body] Stream file, [Query] string token);
    }
}
