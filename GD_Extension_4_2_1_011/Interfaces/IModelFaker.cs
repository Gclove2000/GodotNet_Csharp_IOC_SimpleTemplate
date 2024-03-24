using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD_Extension_4_2_1_011.Interfaces
{
    public interface IModelFaker<T> where T : class
    {

        public T FakerOne();

        public IEnumerable<T> FakeMany(int num);
    }
}
