using FoxClubProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClubProject.Services
{
    public interface IFoxService
    {
        void SetUserFox(Fox foxToSet);
        Fox GetUserFox();
        List<Trick> GetTricks();
    }
}
