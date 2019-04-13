using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public interface IIterator
    {
        object FirstItem { get; }
        object NextItem { get; }
        object CurrentItem { get; }
        bool IsDone { get; }
    }
}
