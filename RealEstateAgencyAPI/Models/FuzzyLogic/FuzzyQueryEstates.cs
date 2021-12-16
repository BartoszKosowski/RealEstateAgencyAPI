using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAgencyAPI.Models.FuzzyLogic
{
    public class FuzzyQueryEstates: IFuzzyQuery<EstateOfferPreview>
    {
        private readonly List<EstateOfferPreview> _allEstates;
        private readonly string[] _queryParams;
        private List<EstateOfferPreview> _selectedEstates;

        public FuzzyQueryEstates(List<EstateOfferPreview> estates, string[] queryParams)
        {
            this._allEstates = estates;
            this._queryParams = queryParams;
            this._selectedEstates = new List<EstateOfferPreview>();
        }

        public List<EstateOfferPreview> GetRecords()
        {
            SelectRecords();
            return _selectedEstates;
        }

        public void SelectRecords()
        {
            foreach(var param in _queryParams)
            {
                var paramArray = param.Split("-");

                if (paramArray[0] == "offertType")
                {
                    if (_selectedEstates.Count == 0)
                    {
                        _selectedEstates = _allEstates.Where(x => x.OfferType == paramArray[1]).ToList();
                    }
                    else
                    {
                        _selectedEstates = _selectedEstates.Where(x => x.OfferType == paramArray[1]).ToList();
                    }
                }

                if (paramArray[0] == "price")
                {
                    if (_selectedEstates.Count == 0)
                    {
                        _selectedEstates = _allEstates.Where(x => TriangularDistribution.CalculateDistributionForSingleRecord((int)x.Price, Int32.Parse(paramArray[1])) > 0).ToList();
                    }
                    else
                    {
                        _selectedEstates = _selectedEstates.Where(x => TriangularDistribution.CalculateDistributionForSingleRecord((int)x.Price, Int32.Parse(paramArray[1])) > 0).ToList();
                    }
                }

                if (paramArray[0] == "area")
                {
                    if (_selectedEstates.Count == 0)
                    {
                        _selectedEstates = _allEstates.Where(x => TriangularDistribution.CalculateDistributionForSingleRecord((int)x.Area, Int32.Parse(paramArray[1])) > 0).ToList();
                    }
                    else
                    {
                        _selectedEstates = _selectedEstates.Where(x => TriangularDistribution.CalculateDistributionForSingleRecord((int)x.Area, Int32.Parse(paramArray[1])) > 0).ToList();
                    }
                }

                if (paramArray[0] == "city")
                {
                    if (_selectedEstates.Count == 0)
                    {
                        _selectedEstates = _allEstates.Where(x => SimilarityComputing.Similarity(paramArray[1], x.City) > 0.8).ToList();
                    }
                    else
                    {
                        _selectedEstates = _selectedEstates.Where(x => SimilarityComputing.Similarity(paramArray[1], x.City) > 0.8).ToList();
                    }
                }

            }
        }
    }
}
