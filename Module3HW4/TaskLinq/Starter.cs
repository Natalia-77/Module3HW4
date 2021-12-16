using System.Collections.Generic;
using System.Linq;

namespace Module3HW4.TaskLinq
{
    public class Starter
    {
        public void FillData()
        {
            var contact = new List<Contact>()
            {
                new Contact { Name = "Roman", LastName = "Petrov", GenderType = GenderType.Male },
                new Contact { Name = "Olga", LastName = "Petrova", GenderType = GenderType.Female },
                new Contact { Name = "Yulia", LastName = "Ivanova", GenderType = GenderType.Female },
                new Contact { Name = "Ivan", LastName = "Green", GenderType = GenderType.Male },
                new Contact { Name = "Vova", LastName = "Popov", GenderType = GenderType.Male },
                new Contact { Name = "Andrey", LastName = "Pivovar", GenderType = GenderType.Male },
                new Contact { Name = "Oleg", LastName = "Sidorov", GenderType = GenderType.Male },
            };

            var name = contact.Where(w => w.Name.ToUpper().StartsWith('R')).OrderBy(o => o);
            var count = contact.Where(w => w.LastName.ToUpper().StartsWith('P')).Count();
            var skip = contact.Where(w => w.LastName.ToUpper().StartsWith('P')).Skip(2).Take(2);
            var gender = contact.Where(w => w.Name.ToUpper().Contains('O')).Select(s => s.GenderType = GenderType.Female).Count();
            var instance = contact.Select(s => s.Name.StartsWith('V')).FirstOrDefault();
            var distinct = contact.Where(w => w.Name.EndsWith('a')).Distinct();
        }
    }
}
