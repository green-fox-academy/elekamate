using Exam_Orientation_Old.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_Orientation_Old.Repositories
{
    public class PlanetRepository
    {
        private SpaceContext spaceContextObject;

        public PlanetRepository(SpaceContext spaceContextObject)
        {
            this.spaceContextObject = spaceContextObject;
        }

        public void Create(Planet classObj)
        {
            spaceContextObject.Add(classObj);
            spaceContextObject.SaveChanges();
        }

        public List<Planet> Read()
        {
            return spaceContextObject.Planets.ToList();
        }

        public void Update(Planet classObj)
        {
            spaceContextObject.Update(classObj);
            spaceContextObject.SaveChanges();
        }

        public void Delete(int id)
        {
            var removable = spaceContextObject.Planets.ToList().FirstOrDefault(x => x.Id == id);
            spaceContextObject.Remove(removable);
            spaceContextObject.SaveChanges();
        }

        public Planet GetTodoById(long id)
        {
            return spaceContextObject.Planets.ToList().FirstOrDefault(x => x.Id == id);
        }
    }
}
