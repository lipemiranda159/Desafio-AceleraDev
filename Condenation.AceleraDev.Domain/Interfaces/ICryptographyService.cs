using Condenation.AceleraDev.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condenation.AceleraDev.Domain.Interfaces
{
    public interface ICryptographyService
    {
        Response Cript(Response input);
        Response Decript(Response input);
    }
}
