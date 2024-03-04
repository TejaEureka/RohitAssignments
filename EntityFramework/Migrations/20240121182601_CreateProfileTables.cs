using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class CreateProfileTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "endeavour_test_area");

            migrationBuilder.CreateTable(
                name: "favorite_stocks_Rohith",
                schema: "endeavour_test_area",
                columns: table => new
                {
                    favorite_stock_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '1', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    ticket_symbol = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    user_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FavoriteStocks_pkey_Rohith", x => x.favorite_stock_id);
                },
                comment: "Table that contains the data for a user favorite stocks, i.e. UserId and ticker symbol");

            migrationBuilder.CreateTable(
                name: "users_Rohith",
                schema: "endeavour_test_area",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '1', '500', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    first_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    last_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    city = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Users_pkey_Rohith", x => x.user_id);
                },
                comment: "Table that contains the data for a user profiles, i.e. UserId and FistName, LastName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "favorite_stocks_Rohith",
                schema: "endeavour_test_area");

            migrationBuilder.DropTable(
                name: "users_Rohith",
                schema: "endeavour_test_area");
        }
    }
}
