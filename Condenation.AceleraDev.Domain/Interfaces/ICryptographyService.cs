using System;
using System.Collections.Generic;
using System.Text;

namespace Condenation.AceleraDev.Domain.Interfaces
{
    public interface ICryptographyService
    {
        string Cript(string input);
        string Decript(string input);
    }
}
