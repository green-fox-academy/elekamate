using MacrotisExamApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MacrotisExamApp.Repositories
{
    public class AttractionRepository
    {
        private ContextName ContextObj;

        public AttractionRepository(ContextName ContextObj)
        {
            this.ContextObj = ContextObj;
        }

        public void Create(tableclass classObj)
        {
            ContextObj.Add(classObj);
            ContextObj.SaveChanges();
        }

        public List<tableclass> Read()
        {
            return ContextObj.tableName.ToList();
        }

        public void Update(tableclass classObj)
        {
            ContextObj.Update(classObj);
            ContextObj.SaveChanges();
        }

        public void Delete(int id)
        {
            var removable = GetTodoById(id);
            ContextObj.Remove(removable);
            ContextObj.SaveChanges();
        }

        public tableclass GetTodoById(long id)
        {
            return ContextObj.tableName.ToList().FirstOrDefault(x => x.Id == id);
        }
    }
}
