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
        private List<ApartmentOfferPreview> _previousSelectedApartment;
        private string[] _cityParams;
        

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
            foreach (string param in _queryParams)
            {
                string[] paramArray = param.Split("-");

                if (paramArray[0] == "city")
                {
                    _cityParams = paramArray[1].Split(',');
                    for (int i = 0; i < _cityParams.Length; i++)
                    {
                        if (string.IsNullOrWhiteSpace(_cityParams[i][0].ToString()))
                        {
                            _cityParams[i] = _cityParams[i][1..];
                        }

                        _previousSelectedApartment = _selectedApartments;
                        bool wasFind = false;
                        if (_selectedApartments.Count == 0)
                        {
                            _selectedApartments = _allApartments.Where(x => SimilarityFunction.ComputeSimilarity(_cityParams[i], x.City) > 0.8).ToList();
                        }
                        else
                        {
                            _selectedApartments = _selectedApartments.Where(x => SimilarityFunction.ComputeSimilarity(_cityParams[i], x.City) > 0.8).ToList();
                        }

                        if (_previousSelectedApartment.Count != _selectedApartments.Count && _selectedApartments.Count > 0)
                        {
                            wasFind = true;
                        }
                        else
                        {
                            _selectedApartments = _previousSelectedApartment;
                        }

                        if (wasFind == false)
                        {
                            if (_selectedApartments.Count == 0)
                            {
                                _selectedApartments = _allApartments.Where(x => SimilarityFunction.ComputeSimilarity(_cityParams[i], x.District) > 0.8).ToList();
                            }
                            else
                            {
                                _selectedApartments = _selectedApartments.Where(x => SimilarityFunction.ComputeSimilarity(_cityParams[i], x.District) > 0.8).ToList();
                            }
                        }

                        if (_selectedApartments.Count == 0)
                        {
                            break;
                        }
                    }
                }

                if (paramArray[0] == "offerType")
                {
                    if (_selectedApartments.Count == 0)
                    {
                        _selectedApartments = _allApartments.Where(x => x.OfferType.ToLower() == paramArray[1].ToLower()).ToList();
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
                        _selectedApartments = _allApartments.Where(x => TriangularMembershipFunction.CalculateMembershipValue((int)x.Price, Int32.Parse(paramArray[1])) > 0).ToList();
                    }
                    else
                    {
                        _selectedApartments = _selectedApartments.Where(x => TriangularMembershipFunction.CalculateMembershipValue((int)x.Price, Int32.Parse(paramArray[1])) > 0).ToList();
                    }
                }

                if (paramArray[0] == "area")
                {
                    if (_selectedApartments.Count == 0)
                    {
                        _selectedApartments = _allApartments.Where(x => TriangularMembershipFunction.CalculateMembershipValue((int)x.Area, Int32.Parse(paramArray[1])) > 0).ToList();
                    }
                    else
                    {
                        _selectedApartments = _selectedApartments.Where(x => TriangularMembershipFunction.CalculateMembershipValue((int)x.Area, Int32.Parse(paramArray[1])) > 0).ToList();
                    }
                }

            }
        }
    }
}
