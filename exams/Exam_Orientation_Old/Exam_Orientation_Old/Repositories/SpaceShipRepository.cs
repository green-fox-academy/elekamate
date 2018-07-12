using Exam_Orientation_Old.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_Orientation_Old.Repositories
{
    public class SpaceShipRepository
    {
        private SpaceContext SpaceContextObject;

        public SpaceShipRepository(SpaceContext SpaceContextObject)
        {
            this.SpaceContextObject = SpaceContextObject;
        }

        public void Create(SpaceShip SpaceShipObject)
        {
            SpaceContextObject.Add(SpaceShipObject);
            SpaceContextObject.SaveChanges();
        }

        public List<SpaceShip> Read()
        {
            return SpaceContextObject.SpaceShip.ToList();
        }

        public void Update(SpaceShip SpaceShipObject)
        {
            SpaceContextObject.Update(SpaceShipObject);
            SpaceContextObject.SaveChanges();
        }

        public void Delete(int id)
        {
            var removable = SpaceContextObject.SpaceShip.ToList().FirstOrDefault(x => x.Id == id);
            SpaceContextObject.Remove(removable);
            SpaceContextObject.SaveChanges();
        }

        public SpaceShip GetTodoById(long id)
        {
            return SpaceContextObject.SpaceShip.ToList().FirstOrDefault(x => x.Id == id);
        }
    }
}
