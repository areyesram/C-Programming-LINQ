using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace areyesram.DB
{
    public class Person
    {
        private static List<BE.Person> _cache;

        public static List<BE.Person> List()
        {
            if (_cache != null)
                return _cache;
            var lines = File.ReadAllLines("data\\Person.csv");
            _cache = lines
                .Select(o => o.Split(','))
                .Select(a => new BE.Person
                {
                    ID = int.Parse(a[0]),
                    Name = a[1],
                    DOB = DateTime.Parse(a[2]),
                    Phone = a[3]
                })
                .ToList();
            return _cache;
        }

        public static List<BE.Person> List(string filter)
        {
            return List()
                .Where(o => o.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        public static List<BE.Person> List(int page, string filter)
        {
            var start = Config.RowsPerPage * page;
            return List(filter)
                .Skip(start)
                .Take(Config.RowsPerPage)
                .ToList();
        }

        public static int Count(string filter)
        {
            return List(filter).Count;
        }
    }
}
