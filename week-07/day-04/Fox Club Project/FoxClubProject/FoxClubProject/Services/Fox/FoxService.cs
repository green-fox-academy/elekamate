using FoxClubProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClubProject.Services
{
    public class FoxService : IFoxService
    {
        private Fox userFox;
        private List<Trick> tricks = new List<Trick>()
        {
            new Trick("code in C#"),
            new Trick("code in Java")
        };

        public Fox GetUserFox()
        {
            return userFox;
        }

        public void SetUserFox(Fox foxToSet)
        {
            userFox = foxToSet;
        }

        public List<Trick> GetTricks()
        {
            return tricks;
        }
    }
}
