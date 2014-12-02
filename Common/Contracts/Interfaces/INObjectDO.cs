using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuy.TechnicalProbe.FizzBuzz.Common.Contracts.Interfaces
{
    public interface INObjectDO
    {
        INObject this[int index]
        { get; }
        INObject Current
        { get; }
        IEnumerator<INObject> GetEnumerator();
        void Add(string nObject);
        void Add(INObject nObject);
        void Delete(INObject nObject);
        bool MoveNext();
        void Reset();
        int Count();
        void Sort();


        void RunDivider(IDivider divider, Delegates.DisplayDelegate display);
    }
}
