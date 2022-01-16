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
    public class EstateOfferPreviewsController : ControllerBase
    {
        private readonly estate_agency_dbContext _context;

        public EstateOfferPreviewsController(estate_agency_dbContext context)
        {
            _context = context;
        }

        //GET: api/EstateOfferPreviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstateOfferPreview>>> GetEstateOfferPreviews()
        {
            return await _context.EstateOfferPreviews.ToListAsync();
        }

        [HttpGet("{query}")]
        public async Task<ActionResult<IEnumerable<EstateOfferPreview>>> GetSpecificOfferPreviews(string query)
        {
            var estates = await _context.EstateOffers.FromSqlRaw(GetSqlExpression(query)).ToListAsync();

            var idEstates = estates.Select(a => a.IdOffers).ToList();
            return await _context.EstateOfferPreviews.Where(a => idEstates.Contains(a.IdOffer)).ToListAsync();
        }

        [HttpGet("fuzzy/{query}")]
        public async Task<ActionResult<IEnumerable<EstateOfferPreview>>> GetFuzzyOfferPreviews(string query)
        {
            var estates = await _context.EstateOfferPreviews.ToListAsync();
            
            if (!query.Contains("empty"))
            {
                FuzzyQueryEstates fuzzyQueryEstates = new FuzzyQueryEstates(estates, query.Split("~"));
                return fuzzyQueryEstates.GetRecords();
            }
            else
            {
                return estates;
            }
        }

        private string GetSqlExpression(string query)
        {
            if (query.Contains("empty"))
            {
                return @"SELECT * FROM estate_offer_view";
            }
            else
            {
                var queryParams = query.Split("~");
                string sqlExpression = @"SELECT * FROM estate_offer_view";

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
                        case "propertyType":
                            {
                                sqlExpression += $" name LIKE \"{paramArray[1]}\"";
                                break;
                            }
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
                        case "agents":
                            {
                                sqlExpression += " (";
                                var agentsNumbers = paramArray[1].Split("_");
                                int agentsLength = agentsNumbers.Length;
                                foreach (var agent in agentsNumbers)
                                {
                                    if(agent != string.Empty)
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
                                }
                                sqlExpression += ")";
                                break;
                            }
                        case "state":
                            {
                                sqlExpression += $" property_status LIKE \"{paramArray[1]}\"";
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
