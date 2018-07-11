using Exam_Orientation_Macrotis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MacrotisExamApp.Repositories
{
    public class AttractionRepository
    {
        private AttractionContext attractionContextObj;

        public AttractionRepository(AttractionContext attractionContextObj)
        {
            this.attractionContextObj = attractionContextObj;
        }

        public void Create(Attraction attraction)
        {
            attractionContextObj.Add(attraction);
            attractionContextObj.SaveChanges();
        }

        public List<Attraction> Read()
        {
            return attractionContextObj.Attractions.ToList();
        }

        public void Update(Attraction attraction)
        {
            attractionContextObj.Update(attraction);
            attractionContextObj.SaveChanges();
        }

        public void Delete(int id)
        {
            var removable = GetAttractionById(id);

            attractionContextObj.Remove(removable);
            attractionContextObj.SaveChanges();
        }

        public Attraction GetAttractionById(long id)
        {
            return attractionContextObj.Attractions.ToList().FirstOrDefault(x => x.Id == id);
        }
    }
}
