using FoxClubProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClubProject.Services
{
    public class LoginService : ILoginService
    {
        private List<Fox> foxes = new List<Fox>();
        private Fox actualFox;

        public LoginService()
        {
            foxes.Add(new Fox("FoxA"));
            foxes.Add(new Fox("FoxB"));
            foxes.Add(new Fox("FoxC"));
        }

        public void AddFox(Fox foxToAdd)
        {
            foxes.Add(foxToAdd);
        }

        public Fox GetActualFox()
        {
            return actualFox;
        }

        public bool Validation(string loginName)
        {
            if (loginName != null)
            {
                foreach (Fox xFox in foxes)
                {
                    if (xFox.Name.ToLower() == loginName.ToLower())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
