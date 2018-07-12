using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_Orientation_Macrotis.Models;
using MacrotisExamApp.Repositories;

namespace Exam_Orientation_Macrotis.Services
{
    public class FilterService
    {
        public AttractionRepository attractionRepositoryObject { get; set; }

        public FilterService(AttractionRepository attractionRepositoryObject)
        {
            this.attractionRepositoryObject = attractionRepositoryObject;
        }

        public AttractionsJson CategoryAndCityFilterJson(string category, string city)
        {
            IEnumerable<Attraction> filteredDBcat = FilterCategory(category);
            IEnumerable<Attraction> filteredDBfinal = FilterCity(filteredDBcat, city);
            int resultCounter = filteredDBfinal.Count();
            return new AttractionsJson
            {
                Result = (resultCounter > 0) ? "ok" : "error",
                Count = resultCounter,
                Attractions = filteredDBfinal.ToList()
            };
        }

        private IEnumerable<Attraction> FilterCategory(string category)
        {
            return  (category.Length > 0) ?
                attractionRepositoryObject.Read().Where(att => att.Category.ToLower().Contains(category.ToLower())) :
                attractionRepositoryObject.Read();
        }

        private IEnumerable<Attraction> FilterCity(IEnumerable<Attraction> filteredDBcat, string city)
        {
            return (city.Length > 0) ?
                filteredDBcat.ToList().Where(att => att.City.ToLower().Equals(city.ToLower())) :
                filteredDBcat;
        }
    }
}
