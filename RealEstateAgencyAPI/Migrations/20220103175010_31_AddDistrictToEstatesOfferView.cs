using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateAgencyAPI.Migrations
{
    public partial class _31_AddDistrictToEstatesOfferView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE OR REPLACE VIEW estate_offer_view AS
                SELECT o.id_offers, o.agent, o.publishing_date, o.area, o.price, o.details, o.offer_name, o.price_for_meter,
                    o.offer_type, o.has_rent, o.rent_value, o.market,
                    t.name, 
                    e.property_area, e.build_date, e.number_of_rooms, e.floors, e.other_details,
                    e.has_balcony, e.furnishings, e.main_photo_url, e.roof_type, e.electricity, e.water_connection, e.basement, e.garage,
                    e.plot, e.fence, e.heating, e.sewers, e.near_forest, e.near_river, e.near_mountains,
                    e.near_highway, e.near_center, e.near_mall, e.near_lake, e.near_coast, e.gas_installation,
                    a.street, a.estate_number, a.city, a.zip_code, a.google_maps_url, a.district,
                    s.name AS property_status
                    FROM offers o
                    LEFT JOIN estates e ON o.estate = e.id_estate 
                    LEFT JOIN addresses a ON e.address = a.id_address 
                    LEFT JOIN trade_info t ON e.property_type = t.id_info
                    LEFT JOIN statuses s ON e.property_status = s.id_status
                    WHERE o.is_estate = 1;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE OR REPLACE VIEW estate_offer_view AS
                SELECT o.id_offers, o.agent, o.publishing_date, o.area, o.price, o.details, o.offer_name, o.price_for_meter,
                    o.offer_type, o.has_rent, o.rent_value, o.market,
                    t.name, 
                    e.property_area, e.build_date, e.number_of_rooms, e.floors, e.other_details,
                    e.has_balcony, e.furnishings, e.main_photo_url, e.roof_type, e.electricity, e.water_connection, e.basement, e.garage,
                    e.plot, e.fence, e.heating, e.sewers, e.near_forest, e.near_river, e.near_mountains,
                    e.near_highway, e.near_center, e.near_mall, e.near_lake, e.near_coast, e.gas_installation,
                    a.street, a.estate_number, a.city, a.zip_code, a.google_maps_url,
                    s.name AS property_status
                    FROM offers o
                    LEFT JOIN estates e ON o.estate = e.id_estate 
                    LEFT JOIN addresses a ON e.address = a.id_address 
                    LEFT JOIN trade_info t ON e.property_type = t.id_info
                    LEFT JOIN statuses s ON e.property_status = s.id_status
                    WHERE o.is_estate = 1;");
        }
    }
}
