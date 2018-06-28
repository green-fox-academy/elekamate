using FoxClubProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClubProject.Services
{
    public class LoginService : ILoginService
    {
        private List<Fox> foxes;

        public LoginService()
        {
            foxes.Add(new Fox("FoxA"));
            foxes.Add(new Fox("FoxB"));
            foxes.Add(new Fox("FoxC"));
        }

        public List<Fox> GetFoxes()
        {
            return foxes;
        }
    }
}
