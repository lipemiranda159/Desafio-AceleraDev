using Codenation.AceleraDev.Services.Extension;
using Condenation.AceleraDev.Domain.Interfaces;
using Condenation.AceleraDev.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codenation.AceleraDev.Services.Interfaces
{
    public class CriptographyService : ICryptographyService
    {
        private readonly ISha1CriptService _sha1CriptService;
        public CriptographyService(ISha1CriptService sha1CriptService)
        {
            _sha1CriptService = sha1CriptService;
        }
        public Response Cript(Response input)
        {
            var aux = string.Empty;
            foreach (var item in input.Decifrado)
            {
                if (HasToChangeChar(item))
                {
                    aux += (char)(item + input.NumeroCasas);
                }
                else
                {
                    aux += item;
                }
            }
            input.Cifrado = aux;
            input.ResumoCriptografico = _sha1CriptService.Sha1Hash(aux);
            return input;
        }

        private static bool HasToChangeChar(char item)
        {
            return char.IsLetter(item);
        }

        public Response Decript(Response input)
        {
            var aux = string.Empty;
            foreach (var item in input.Cifrado)
            {
                if (HasToChangeChar(item))
                {
                    aux += (char)(item - input.NumeroCasas);
                } else
                {
                    aux += item;
                }
            }
            input.Decifrado = aux;
            input.ResumoCriptografico = _sha1CriptService.Sha1Hash(aux);
            return input;
        }
    }
}
