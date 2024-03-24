using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD_Extension.Interfaces
{
    public interface IModelFaker<T> where T : class
    {

        public T FakerOne();

        public IEnumerable<T> FakeMany(int num);
    }
}
