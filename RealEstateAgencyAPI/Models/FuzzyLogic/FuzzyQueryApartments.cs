using System;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateAgencyAPI.Models.FuzzyLogic
{
    public class FuzzyQueryApartments : IFuzzyQuery<ApartmentOfferPreview>
    {
        private readonly List<ApartmentOfferPreview> _allApartments;
        private readonly string[] _queryParams;
        private List<ApartmentOfferPreview> _selectedApartments;

        public FuzzyQueryApartments(List<ApartmentOfferPreview> apartments, string[] queryParams)
        {
            this._allApartments = apartments;
            this._queryParams = queryParams;
            this._selectedApartments = new List<ApartmentOfferPreview>();
        }

        public List<ApartmentOfferPreview> GetRecords()
        {
            SelectRecords();
            return _selectedApartments;
        }

        public void SelectRecords()
        {
            foreach (var param in _queryParams)
            {
                var paramArray = param.Split("-");

                if (paramArray[0] == "offertType")
                {
                    if (_selectedApartments.Count == 0)
                    {
                        _selectedApartments = _allApartments.Where(x => x.OfferType == paramArray[1]).ToList();
                    }
                    else
                    {
                        _selectedApartments = _allApartments.Where(x => x.OfferType == paramArray[1]).ToList();
                    }
                }

                if (paramArray[0] == "price")
                {
                    if (_selectedApartments.Count == 0)
                    {
                        _selectedApartments = _allApartments.Where(x => TriangularDistribution.CalculateDistributionForSingleRecord((int)x.Price, Int32.Parse(paramArray[1])) > 0).ToList();
                    }
                    else
                    {
                        _selectedApartments = _selectedApartments.Where(x => TriangularDistribution.CalculateDistributionForSingleRecord((int)x.Price, Int32.Parse(paramArray[1])) > 0).ToList();
                    }
                }

                if (paramArray[0] == "area")
                {
                    if (_selectedApartments.Count == 0)
                    {
                        _selectedApartments = _allApartments.Where(x => TriangularDistribution.CalculateDistributionForSingleRecord((int)x.Area, Int32.Parse(paramArray[1])) > 0).ToList();
                    }
                    else
                    {
                        _selectedApartments = _selectedApartments.Where(x => TriangularDistribution.CalculateDistributionForSingleRecord((int)x.Area, Int32.Parse(paramArray[1])) > 0).ToList();
                    }
                }

                if (paramArray[0] == "city")
                {
                    if (_selectedApartments.Count == 0)
                    {
                        _selectedApartments = _allApartments.Where(x => SimilarityComputing.Similarity(paramArray[1], x.City) > 0.8).ToList();
                    }
                    else
                    {
                        _selectedApartments = _selectedApartments.Where(x => SimilarityComputing.Similarity(paramArray[1], x.City) > 0.8).ToList();
                    }
                }

            }
        }
    }
}
