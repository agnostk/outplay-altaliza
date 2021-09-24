using Microsoft.EntityFrameworkCore.Migrations;

namespace Altaliza.DAL.Migrations
{
    public partial class AddedVehicles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Comerciais", "Commercial" },
                    { 2, "Compactos", "Compact" },
                    { 3, "Militares", "Military" },
                    { 4, "Motos", "Motorcycle" },
                    { 5, "Off-Roads", "Off-Road" },
                    { 6, "Sedans", "Sedan" },
                    { 7, "Esportivos", "Sport" },
                    { 8, "Superesportivos", "Super" },
                    { 9, "SUVs", "SUV" },
                    { 10, "Vans", "Van" }
                });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price15Days", "Price1Day", "Price7Days", "Stock" },
                values: new object[,]
                {
                    { 1, 1, "/vehicles/commercial/terrorbyte.png", "Terrorbyte", 76320m, 6880m, 41250m, 3 },
                    { 28, 10, "/vehicles/van/youga-classic-4x4.png", "Youga Classic 4x4", 42890m, 3870m, 23190m, 5 },
                    { 27, 9, "/vehicles/suv/gresley.png", "Gresley", 960m, 90m, 530m, 3 },
                    { 26, 9, "/vehicles/suv/contender.png", "Contender", 8330m, 750m, 4500m, 2 },
                    { 25, 9, "/vehicles/suv/landstalker-xl.png", "Landstalker XL", 40630m, 3660m, 21960m, 5 },
                    { 24, 8, "/vehicles/super/infernus.png", "Infernus", 14660m, 1320m, 7920m, 3 },
                    { 23, 8, "/vehicles/super/osiris.png", "Osiris", 65000m, 5850m, 35100m, 2 },
                    { 22, 8, "/vehicles/super/krieger.png", "Krieger", 95740m, 8630m, 51750m, 5 },
                    { 21, 7, "/vehicles/sport/rapid-gt.png", "Rapid GT", 4400m, 400m, 2380m, 3 },
                    { 20, 7, "/vehicles/sport/neo.png", "Neo", 62440m, 5630m, 33750m, 2 },
                    { 19, 7, "/vehicles/sport/itali-rsx.png", "Itali RSX", 115390m, 10400m, 62370m, 5 },
                    { 18, 6, "/vehicles/sedans/asterope.png", "Asterope", 870m, 78m, 468m, 3 },
                    { 17, 6, "/vehicles/sedans/warrener.png", "Warrener", 4000m, 360m, 2160m, 2 },
                    { 16, 6, "/vehicles/sedans/taligater-s.png", "Taligater S", 49790m, 4490m, 26910m, 5 },
                    { 15, 5, "/vehicles/off-road/verus.png", "Verus", 6400m, 576m, 3460m, 3 },
                    { 14, 5, "/vehicles/off-road/insurgent.png", "Insurgent", 29900m, 2700m, 16160m, 2 },
                    { 13, 5, "/vehicles/off-road/brutus.png", "Brutus", 88800m, 8000m, 48000m, 5 },
                    { 12, 4, "/vehicles/motorcycle/cliffhanger.png", "Cliffhanger", 7500m, 680m, 4050m, 3 },
                    { 11, 4, "/vehicles/motorcycle/vindicator.png", "Vindicator", 20980m, 1890m, 11340m, 2 },
                    { 10, 4, "/vehicles/motorcycle/shotaro.png", "Shotaro", 74100m, 6680m, 40060m, 5 },
                    { 9, 3, "/vehicles/military/vetir.png", "Vetir", 41620m, 3750m, 22500m, 3 },
                    { 8, 3, "/vehicles/military/barrage.png", "Barrage", 70640m, 6370m, 38190m, 2 },
                    { 7, 3, "/vehicles/military/half-track.png", "Half-track", 75070m, 6770m, 40580m, 5 },
                    { 6, 2, "/vehicles/compact/asbo.png", "Asbo", 13590m, 1230m, 7350m, 3 },
                    { 5, 2, "/vehicles/compact/weevil.png", "Weevil", 28980m, 2610m, 15660m, 2 },
                    { 4, 2, "/vehicles/compact/club.png", "Club", 42630m, 3840m, 23040m, 5 },
                    { 3, 1, "/vehicles/commercial/phantom-custom.png", "Phantom Custom", 68000m, 6130m, 36750m, 1 },
                    { 2, 1, "/vehicles/commercial/pounder-custom.png", "Pounder Custom", 17790m, 1610m, 9620m, 2 },
                    { 29, 10, "/vehicles/van/bison.png", "Bison", 1000m, 90m, 540m, 2 },
                    { 30, 10, "/vehicles/van/surfer.png", "Surfer", 370m, 40m, 200m, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
