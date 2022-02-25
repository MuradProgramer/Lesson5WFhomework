using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5WFhomework
{
    public class User
    {
        public User(string name, List<string> buyedFoods, double? pulDaxilOlub, double? qaliqQaytarilib, DateTime? alishVaxti)
        {
            Name = name;
            BuyedFoods = buyedFoods;
            PulDaxilOlub = pulDaxilOlub;
            QaliqQaytarilib = qaliqQaytarilib;
            AlishVaxti = alishVaxti;
        }
        public User()
        {

        }

        public string Name { get; set; }

        public List<string> BuyedFoods { get; set; }

        public double? PulDaxilOlub { get; set; } = null;

        public double? QaliqQaytarilib { get; set; } = null;

        public DateTime? AlishVaxti { get; set; } = null;
    }
}
