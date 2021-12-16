using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAgencyAPI.Models.FuzzyLogic
{
    interface IFuzzyQuery<T>
    {
        public List<T> GetRecords();
        public void SelectRecords();
    }
}
