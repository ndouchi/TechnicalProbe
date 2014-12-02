using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BestBuy.TechnicalProbe.FizzBuzz.Common.Contracts.Interfaces;
using BestBuy.TechnicalProbe.FizzBuzz.Common.Contracts;
using BestBuy.TechnicalProbe.FizzBuzz.Common.Contracts.Enums;
using BestBuy.TechnicalProbe.FizzBuzz.Common.Utility;

namespace BestBuy.TechnicalProbe.FizzBuzz.Model
{
    public class NObjects :  INObjectDO
    {
        #region Private Variables
        private int _position = -1;
        private List<INObject> _nObjects = new List<INObject>();
        #endregion Private Variables

        #region Public Methods
        public IEnumerator<INObject> GetEnumerator()
        {
            return (IEnumerator<NObject>)this;
        }
        public void Add(string nObject)
        {
            if (nObject != null)
            {
                NObject n = new NObject(nObject);
                Add(n);
            }
        }
        public void Add(INObject nObject)
        {
            if (nObject != null)
            {
                _nObjects.Add(nObject);
            }
        }
        public void Delete(INObject nObject)
        {
            if (nObject != null)
            {
                _nObjects.Remove(nObject);
            }
        }
        public bool MoveNext()
        {
            _position++;
            if (_position < _nObjects.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            _position = -1;
            _nObjects.Clear();
        }
        public int Count()
        {
            return _nObjects.Count;
        }
        public void Sort()
        {
            var orderedList =
                    _nObjects.OrderByDescending(x => x.ObjectValue)
                            .ThenByDescending(x => x.ObjectValue);
            _nObjects = (List<INObject>)orderedList;
        }
        #endregion Public Methods

        #region Constructors
        public NObjects() { }
        #endregion Constructors

        #region Properties
        public INObject this[int index]
        {
            get
            {
                if (_nObjects[index] != null)
                    return _nObjects[index];
                else
                    return null;
            }
        }
        public INObject Current
        {
            get { return _nObjects[_position]; }
        }
        #endregion Properties
        /// <summary>
        /// This function loops through the items of the collection of values and performs the division or attemps to divide.
        /// The result returned will be displayed by the print delegate, which is set by the caller.
        /// </summary>
        /// <param name="divider"></param>
        /// <param name="print"></param>
        public void RunDivider(IDivider divider, Delegates.DisplayDelegate display)
        {
            string returnResult;
            display("There are " + _nObjects.Count() + " elements in the collection.");

            foreach (NObject nObject in _nObjects)
            {
                returnResult = divider.Divide(nObject);
                display(returnResult);
            }
        }
    }
}
