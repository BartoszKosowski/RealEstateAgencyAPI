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
        private string[] _cityParams;
        private List<EstateOfferPreview> _previousSelectedEstates;

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

                if (paramArray[0] == "city")
                {
                    _cityParams = paramArray[1].Split(',');

                    for (int i = 0; i < _cityParams.Length; i++)
                    {
                        if (string.IsNullOrWhiteSpace(_cityParams[i][0].ToString()))
                        {
                            _cityParams[i] = _cityParams[i][1..];
                        }

                        _previousSelectedEstates = _selectedEstates;
                        bool wasFind = false;

                        if (_selectedEstates.Count == 0)
                        {
                            _selectedEstates = _allEstates.Where(x => SimilarityFunction.ComputeSimilarity(_cityParams[i], x.City) > 0.8).ToList();
                        }
                        else
                        {
                            _selectedEstates = _selectedEstates.Where(x => SimilarityFunction.ComputeSimilarity(_cityParams[i], x.City) > 0.8).ToList();
                        }

                        if (_previousSelectedEstates.Count != _selectedEstates.Count)
                        {
                            wasFind = true;
                        }
                        else
                        {
                            _selectedEstates = _previousSelectedEstates;
                        }

                        if (wasFind == false)
                        {
                            if (_selectedEstates.Count == 0)
                            {
                                _selectedEstates = _allEstates.Where(x => SimilarityFunction.ComputeSimilarity(_cityParams[i], x.District) > 0.8).ToList();
                            }
                            else
                            {
                                _selectedEstates = _allEstates.Where(x => SimilarityFunction.ComputeSimilarity(_cityParams[i], x.District) > 0.8).ToList();
                            }

                            if (_previousSelectedEstates.Count != _selectedEstates.Count)
                            {
                                wasFind = true;

                            }
                            else
                            {
                                _selectedEstates = _previousSelectedEstates;
                            }
                        }

                        if (_selectedEstates.Count == 0)
                        {
                            break;
                        }
                    }
                }

                if (paramArray[0] == "offerType")
                {
                    if (_selectedEstates.Count == 0)
                    {
                        _selectedEstates = _allEstates.Where(x => x.OfferType.ToLower() == paramArray[1].ToLower()).ToList();
                    }
                    else
                    {
                        _selectedEstates = _selectedEstates.Where(x => x.OfferType.ToLower() == paramArray[1].ToLower()).ToList();
                    }
                }

                if (paramArray[0] == "price")
                {
                    if (_selectedEstates.Count == 0)
                    {
                        _selectedEstates = _allEstates.Where(x => TriangularMembershipFunction.CalculateMembershipValue((int)x.Price, Int32.Parse(paramArray[1])) > 0).ToList();
                    }
                    else
                    {
                        _selectedEstates = _selectedEstates.Where(x => TriangularMembershipFunction.CalculateMembershipValue((int)x.Price, Int32.Parse(paramArray[1])) > 0).ToList();
                    }
                }

                if (paramArray[0] == "area")
                {
                    if (_selectedEstates.Count == 0)
                    {
                        _selectedEstates = _allEstates.Where(x => TriangularMembershipFunction.CalculateMembershipValue((int)x.Area, Int32.Parse(paramArray[1])) > 0).ToList();
                    }
                    else
                    {
                        _selectedEstates = _selectedEstates.Where(x => TriangularMembershipFunction.CalculateMembershipValue((int)x.Area, Int32.Parse(paramArray[1])) > 0).ToList();
                    }
                }

            }
        }
    }
}
