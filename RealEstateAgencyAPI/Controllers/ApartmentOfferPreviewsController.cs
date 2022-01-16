using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateAgencyAPI.Models;
using RealEstateAgencyAPI.Models.FuzzyLogic;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAgencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentOfferPreviewsController : ControllerBase
    {
        private readonly estate_agency_dbContext _context;

        public ApartmentOfferPreviewsController(estate_agency_dbContext context)
        {
            _context = context;
        }

        //GET: api/ApartmentOfferPreviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApartmentOfferPreview>>> GetApartmentOfferPreviews()
        {
            return await _context.ApartmentOfferPreviews.ToListAsync();
        }

        //GET: api/ApartmentOfferPreviews/params
        [HttpGet("{query}")]
        public async Task<ActionResult<IEnumerable<ApartmentOfferPreview>>> GetSpecificApartmentOfferPreviews(string query)
        {
            var apartments = await _context.ApartmentOffers.FromSqlRaw(GetSqlExpression(query)).ToListAsync();

            var idApartments = apartments.Select(a => a.IdOffers).ToList();
            return await _context.ApartmentOfferPreviews.Where(a => idApartments.Contains(a.IdOffer)).ToListAsync();
        }

        [HttpGet("fuzzy/{query}")]
        public async Task<ActionResult<IEnumerable<ApartmentOfferPreview>>> GetFuzzyOfferPreviews(string query)
        {
            var apartments = await _context.ApartmentOfferPreviews.ToListAsync();

            if (!query.Contains("empty"))
            {
                FuzzyQueryApartments fuzzyQueryApartments = new FuzzyQueryApartments(apartments, query.Split("~"));
                return fuzzyQueryApartments.GetRecords();
            }
            else
            {
                return apartments;
            }
        }

        private string GetSqlExpression(string query)
        {
            if (query.Contains("empty") || query == "propertyType-Mieszkanie")
            {
                return @"SELECT * FROM apartment_offer_view";
            }
            else
            {
                var queryParams = query.Split("~");
                string sqlExpression = @"SELECT * FROM apartment_offer_view";

                int remainArrayLength = queryParams.Length;
                sqlExpression += " WHERE";
                foreach (var param in queryParams)
                {
                    var paramArray = param.Split("-");

                    if (remainArrayLength != queryParams.Length)
                    {
                        sqlExpression += " AND";
                    }

                    switch (paramArray[0])
                    {
                        case "offerType":
                            {
                                sqlExpression += $" offer_type LIKE \"{paramArray[1]}\"";
                                break;
                            };
                        case "city":
                            {
                                sqlExpression += $" city LIKE \"{paramArray[1]}\"";
                                break;
                            };
                        case "market":
                            {
                                sqlExpression += $" market LIKE \"{paramArray[1]}\"";
                                break;
                            };
                        case "priceFrom":
                            {
                                sqlExpression += $" price > {paramArray[1]}";
                                break;
                            };
                        case "priceTo":
                            {
                                sqlExpression += $" price < {paramArray[1]}";
                                break;
                            };
                        case "priceForMeterFrom":
                            {
                                sqlExpression += $" price_for_meter > {paramArray[1]}";
                                break;
                            };
                        case "priceForMeterTo":
                            {
                                sqlExpression += $" price_for_meter < {paramArray[1]}";
                                break;
                            };
                        case "numberOfRoomsFrom":
                            {
                                sqlExpression += $" number_of_rooms > {paramArray[1]}";
                                break;
                            };
                        case "numberOfRoomsTo":
                            {
                                sqlExpression += $" number_of_rooms < {paramArray[1]}";
                                break;
                            };
                        case "numberOfFloorsFrom":
                            {
                                sqlExpression += $" number_of_floors > {paramArray[1]}";
                                break;
                            }
                        case "numberOfFloorsTo":
                            {
                                sqlExpression += $" number_of_floors < {paramArray[1]}";
                                break;
                            }
                        case "areaFrom":
                            {
                                sqlExpression += $" property_area > {paramArray[1]}";
                                break;
                            };
                        case "areaTo":
                            {
                                sqlExpression += $" property_area < {paramArray[1]}";
                                break;
                            }
                        case "agents":
                            {
                                sqlExpression += " (";
                                var agentsNumbers = paramArray[1].Split("_");
                                int agentsLength = agentsNumbers.Length;
                                foreach (var agent in agentsNumbers)
                                {
                                    if (agentsLength != agentsNumbers.Length)
                                    {
                                        sqlExpression += " OR";
                                    }
                                    if (!string.IsNullOrEmpty(agent))
                                    {
                                        sqlExpression += $" agent = {agent}";
                                        agentsLength--;
                                    }
                                }
                                sqlExpression += ")";
                                break;
                            }
                        case "state":
                            {
                                sqlExpression += $" property_state LIKE \"{paramArray[1]}\"";
                                break;
                            }
                        case "distForest":
                            {
                                sqlExpression += $" near_forest = 1";
                                break;
                            }
                        case "distMountains":
                            {
                                sqlExpression += $" near_mountains = 1";
                                break;
                            }
                        case "distRiver":
                            {
                                sqlExpression += $" near_river = 1";
                                break;
                            }
                        case "distHighway":
                            {
                                sqlExpression += $" near_highway = 1";
                                break;
                            }
                        case "distCenter":
                            {
                                sqlExpression += $" near_center = 1";
                                break;
                            }
                        case "distMall":
                            {
                                sqlExpression += $" near_mall = 1";
                                break;
                            }
                        case "distLake":
                            {
                                sqlExpression += $" near_lake = 1";
                                break;
                            }
                        case "distCoast":
                            {
                                sqlExpression += $" near_coast = 1";
                                break;
                            }
                    }
                    remainArrayLength--;
                }
                return sqlExpression;
            }
        }
    }
}
