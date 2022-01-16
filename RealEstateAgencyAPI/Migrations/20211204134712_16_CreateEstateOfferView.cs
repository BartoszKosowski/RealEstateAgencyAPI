using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateAgencyAPI.Migrations
{
    public partial class _16_CreateEstateOfferView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE OR REPLACE VIEW estate_offer_view AS
                SELECT o.id_offers, o.agent, o.publishing_date, o.area, o.price, o.details, o.offer_name, o.price_for_meter,
                    o.offer_type, o.has_rent, o.rent_value,
                    t.name, 
                    e.property_area, e.build_date, e.property_status, e.number_of_rooms, e.floors, e.other_details,
                    e.has_balcony, e.furnishings, e.main_photo_url, e.roof_type, e.electricity, e.water_connection, e.basement, e.garage,
                    e.plot, e.fence, e.heating, e.sewers, e.distance_to_forest, e.distance_to_river, e.distance_to_mountains,
                    e.distance_to_highway, e.distance_to_center, e.distance_to_mall, e.distance_to_lake, e.distance_to_coast,
                    a.street, a.estate_number, a.city, a.zip_code, a.google_maps_url
                    FROM offers o
                    LEFT JOIN estates e ON o.estate = e.id_estate 
                    LEFT JOIN addresses a ON e.address = a.id_address 
                    LEFT JOIN trade_info t ON e.property_type = t.id_info
                    WHERE o.is_estate = 1;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW estate_offer_view;");
        }
    }
}
