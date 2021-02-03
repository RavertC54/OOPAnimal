using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAnimal
{
    class Family
    {
        public string name;
        public int numberOfToes;
        public int numberOfTeeth;
        public bool whiskers;
        public bool doesJeremyLikeIt;
        public Family(string _name = null)
        {
            name = _name;
            Console.WriteLine("Creating: " + _name + " at " + DateTime.Now.ToString("yyyy-MM-dd"));
        }

        public void setAttributes(Family sentFamily)
        {
            numberOfToes = sentFamily.numberOfToes;
            numberOfTeeth = sentFamily.numberOfTeeth;
        }
        public bool doesJeremyLikeThisFamily()
        {
            return doesJeremyLikeIt;
        }
    }
}
