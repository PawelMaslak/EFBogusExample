using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PopulateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstLine = table.Column<string>(type: "TEXT", nullable: true),
                    SecondLine = table.Column<string>(type: "TEXT", nullable: true),
                    ZipCode = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Surname = table.Column<string>(type: "TEXT", nullable: true),
                    CompanyName = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    AddressId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "FirstLine", "SecondLine", "State", "ZipCode" },
                values: new object[,]
                {
                    { 101, "Port Jose", "United States", "Viviane Bypass", "710", "Arizona", "08155-1760" },
                    { 102, "Lorainefort", "United States", "Dietrich Island", "90198", "Tennessee", "79778" },
                    { 103, "New Tyriqueshire", "United States", "Lenna Spring", "9798", "Pennsylvania", "84769" },
                    { 104, "West Katherine", "United States", "Brekke Trail", "97411", "Pennsylvania", "85416" },
                    { 105, "Tyshawnhaven", "United States", "Felicita Brooks", "83978", "Wisconsin", "80712" },
                    { 106, "South Russelmouth", "United States", "Schmidt Orchard", "7380", "Massachusetts", "12579" },
                    { 107, "Hannaburgh", "United States", "Willms Brooks", "542", "West Virginia", "13138" },
                    { 108, "North Christ", "United States", "Schinner Forks", "027", "Nevada", "89228-1378" },
                    { 109, "New Bryceville", "United States", "Brandyn Mount", "482", "Alabama", "48409" },
                    { 110, "Lake Bridget", "United States", "Gleason Run", "2606", "Louisiana", "85086" },
                    { 111, "South Jamar", "United States", "Beatty Park", "5130", "Nebraska", "77264" },
                    { 112, "Port Ernesto", "United States", "Javonte Trail", "685", "Washington", "43617" },
                    { 113, "South Brice", "United States", "Harry Freeway", "512", "Oregon", "36920" },
                    { 114, "East Adanland", "United States", "Hermiston Spurs", "378", "Wyoming", "19206" },
                    { 115, "Ramiroland", "United States", "Hessel Shores", "2641", "North Carolina", "91332-3867" },
                    { 116, "East Trentville", "United States", "Merl Lights", "03408", "Utah", "40142" },
                    { 117, "Madilynside", "United States", "Blanda Tunnel", "3187", "Idaho", "09001" },
                    { 118, "Rippinberg", "United States", "Boyer Port", "903", "Wyoming", "22347-3898" },
                    { 119, "Grahamview", "United States", "Kuhlman Rest", "11091", "West Virginia", "36208-1546" },
                    { 120, "Daleton", "United States", "Schmeler Locks", "863", "Idaho", "69489-3863" },
                    { 121, "North Onieborough", "United States", "Kuhlman Forges", "084", "Montana", "94741-3720" },
                    { 122, "Skileschester", "United States", "Melvina Trail", "682", "South Dakota", "03298" },
                    { 123, "Carterview", "United States", "Waelchi Lights", "39170", "Colorado", "81615-8215" },
                    { 124, "Jovanybury", "United States", "Borer Views", "6581", "Nebraska", "78087-9691" },
                    { 125, "Breannamouth", "United States", "Mikayla Dam", "241", "North Carolina", "41324" },
                    { 126, "Lake Brooklyn", "United States", "Charlie Springs", "9700", "Oregon", "35685" },
                    { 127, "Swaniawskiport", "United States", "Jeff Shore", "4083", "Kentucky", "65274-1559" },
                    { 128, "New Lolitamouth", "United States", "Sincere Tunnel", "0902", "Florida", "78777-5815" },
                    { 129, "East Eugeniahaven", "United States", "Boehm Mount", "85053", "Minnesota", "99367-8614" },
                    { 130, "North Fayeside", "United States", "McClure Street", "370", "Montana", "72600-3594" },
                    { 131, "New Edison", "United States", "Kling Trail", "812", "Vermont", "32731" },
                    { 132, "North Maymouth", "United States", "Walsh Dam", "55341", "Maryland", "53738-6898" },
                    { 133, "Theronmouth", "United States", "Orn Plains", "4398", "New Jersey", "13952-6026" },
                    { 134, "Maritzashire", "United States", "Turcotte Field", "0435", "Kansas", "89608-1108" },
                    { 135, "Mooreside", "United States", "Blick Springs", "44232", "Pennsylvania", "48345-1306" },
                    { 136, "Blockfurt", "United States", "Green Manors", "828", "Arkansas", "17708" },
                    { 137, "South Magalifurt", "United States", "Deon Mall", "77012", "Texas", "54389" },
                    { 138, "East Braulio", "United States", "Hudson Circles", "0526", "Montana", "69155" },
                    { 139, "South Ricardostad", "United States", "Murphy Key", "503", "North Dakota", "49147-1101" },
                    { 140, "North Tyree", "United States", "Jast Rue", "00209", "New Jersey", "56890" },
                    { 141, "North Thomasview", "United States", "Boyer Lane", "76652", "Montana", "19050-3949" },
                    { 142, "Dickiton", "United States", "Mae Roads", "767", "Florida", "03943" },
                    { 143, "North Kavonstad", "United States", "Wilhelmine Summit", "454", "Kentucky", "78658-1888" },
                    { 144, "New Brayanland", "United States", "Jones Field", "334", "Oregon", "95171-2860" },
                    { 145, "Lefflerport", "United States", "Lavinia Forks", "2354", "New Hampshire", "45710" },
                    { 146, "West Carletontown", "United States", "Bode Trail", "1289", "New Jersey", "25264" },
                    { 147, "New Brandt", "United States", "Boehm Common", "2362", "New Jersey", "92251" },
                    { 148, "Watsicaview", "United States", "Jerde Causeway", "3222", "Kansas", "19210-4661" },
                    { 149, "Robertsbury", "United States", "Wyman Mission", "07103", "New Jersey", "44782" },
                    { 150, "Noemimouth", "United States", "Kiana Rapid", "099", "Hawaii", "85580-0024" },
                    { 151, "Rogersmouth", "United States", "Margaretta Neck", "535", "Indiana", "36582-4301" },
                    { 152, "West Giuseppe", "United States", "Everett Estate", "880", "North Dakota", "88810-4549" },
                    { 153, "Milesberg", "United States", "Ziemann Views", "59998", "Iowa", "33774-5343" },
                    { 154, "Lake Lorenzaberg", "United States", "Batz Parks", "671", "Minnesota", "27380" },
                    { 155, "Odessaburgh", "United States", "John Summit", "351", "Pennsylvania", "95463" },
                    { 156, "East Wilfridland", "United States", "Tressa Forges", "16495", "Alabama", "54995" },
                    { 157, "Mozellchester", "United States", "Osinski Camp", "0992", "Alaska", "86467-2839" },
                    { 158, "South Isac", "United States", "Kozey Trafficway", "6235", "Colorado", "48611-7238" },
                    { 159, "East Marcellehaven", "United States", "Deontae Forks", "49967", "New Hampshire", "53691-2155" },
                    { 160, "New Troyland", "United States", "Branson Mission", "601", "New Mexico", "48458" },
                    { 161, "West Cydneystad", "United States", "Harris Ville", "53068", "Hawaii", "60240-0790" },
                    { 162, "West Delpha", "United States", "Trudie Lock", "19845", "North Carolina", "51991" },
                    { 163, "South Shaniyaland", "United States", "Russell Lock", "99635", "Maine", "06895-9286" },
                    { 164, "Scotland", "United States", "Tiffany Landing", "87200", "Nevada", "51552-4941" },
                    { 165, "Lake Alexandria", "United States", "Powlowski Estate", "303", "Pennsylvania", "95658" },
                    { 166, "Lake Abbie", "United States", "Kunde Spurs", "4740", "Maryland", "37775" },
                    { 167, "North Presleymouth", "United States", "Lucinda Trace", "062", "New Hampshire", "89374-6539" },
                    { 168, "East Willie", "United States", "Sipes Walks", "38860", "Kentucky", "98403-4665" },
                    { 169, "East Hermanside", "United States", "Emard Crossing", "6621", "Alaska", "82314-7236" },
                    { 170, "Farrellton", "United States", "Bartell Light", "051", "Kansas", "92420" },
                    { 171, "Lindfort", "United States", "Dibbert Walk", "809", "Wisconsin", "28235" },
                    { 172, "East Rogeliochester", "United States", "Hudson Drives", "250", "Pennsylvania", "09940-0476" },
                    { 173, "North Ritabury", "United States", "Jessica Club", "7260", "North Carolina", "03569" },
                    { 174, "Stromanberg", "United States", "Prohaska Estate", "06703", "Wyoming", "93667-7851" },
                    { 175, "West Janie", "United States", "Orn Valleys", "3881", "Delaware", "82080-1213" },
                    { 176, "Wisokyland", "United States", "Stanton Park", "636", "Alaska", "55103-1473" },
                    { 177, "Ellisshire", "United States", "Langworth Ports", "53686", "Kansas", "09614-4643" },
                    { 178, "Schneiderport", "United States", "Hildegard Glens", "876", "Washington", "39619-0934" },
                    { 179, "Port Devontemouth", "United States", "Langworth Flat", "016", "Michigan", "55267" },
                    { 180, "North Albertoport", "United States", "Wyatt Prairie", "5387", "Massachusetts", "19390-0769" },
                    { 181, "East Ursula", "United States", "Shanahan Ford", "51308", "Kansas", "20883-0604" },
                    { 182, "Port Mekhi", "United States", "Brekke Harbor", "16169", "North Dakota", "22569" },
                    { 183, "Feeneyland", "United States", "Clotilde Crescent", "711", "Minnesota", "39330-2924" },
                    { 184, "Lorafort", "United States", "O'Hara Glen", "3057", "Maine", "82745-1979" },
                    { 185, "Millerview", "United States", "Littel Shore", "7381", "Nebraska", "58140" },
                    { 186, "New Madisynchester", "United States", "Crooks Pines", "6250", "Tennessee", "67178" },
                    { 187, "Dietrichbury", "United States", "Harvey Forest", "461", "Oregon", "20036-3085" },
                    { 188, "Howardton", "United States", "Mabelle Flat", "42729", "Iowa", "63318-4346" },
                    { 189, "North Roxane", "United States", "Nichole Islands", "780", "Kansas", "60593-4726" },
                    { 190, "East Major", "United States", "Ova Well", "30222", "West Virginia", "51503-8332" },
                    { 191, "North Arleneshire", "United States", "Dooley Bridge", "71406", "Maine", "38718" },
                    { 192, "Jacobiborough", "United States", "Brant View", "108", "Massachusetts", "95003" },
                    { 193, "Sanfordmouth", "United States", "Marks Corners", "355", "Pennsylvania", "65115" },
                    { 194, "New Lydia", "United States", "Stehr Fort", "16266", "Florida", "33901" },
                    { 195, "New Mozellefort", "United States", "Bethany Brooks", "3735", "Idaho", "37170" },
                    { 196, "West Reganfurt", "United States", "Ward Street", "73836", "Minnesota", "14828" },
                    { 197, "Rennerville", "United States", "Sauer Club", "09444", "Nevada", "52202-2547" },
                    { 198, "Waelchimouth", "United States", "Nettie Station", "32098", "Pennsylvania", "70883-8831" },
                    { 199, "West Angelitatown", "United States", "Nyasia Turnpike", "935", "New York", "28124" },
                    { 200, "West Furmanville", "United States", "Sipes Inlet", "3735", "New York", "05524-4063" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AddressId", "CompanyName", "Name", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { 101, 101, "Russel, Nienow and Schaefer", "Casey", "(886) 550-0543", "Schultz" },
                    { 102, 102, "Farrell - Mohr", "Meaghan", "(661) 400-4168 x761", "Jenkins" },
                    { 103, 103, "Rogahn - Predovic", "Jackson", "678-563-3006", "Mann" },
                    { 104, 104, "Windler - Ebert", "Dillon", "1-662-689-7962", "Gottlieb" },
                    { 105, 105, "Jacobi - Schamberger", "Leanna", "280.773.9869 x4429", "Volkman" },
                    { 106, 106, "Hilpert - Stiedemann", "Jermaine", "826.478.2499", "Ebert" },
                    { 107, 107, "Keeling LLC", "Maxine", "1-531-358-5852 x776", "Walker" },
                    { 108, 108, "Lindgren and Sons", "Giovanna", "813.681.5877 x97500", "Reichel" },
                    { 109, 109, "Nienow, Bradtke and Bartell", "Marcelle", "(441) 347-9390 x9710", "Wolff" },
                    { 110, 110, "Swaniawski LLC", "Anais", "855-217-6091", "Wisozk" },
                    { 111, 111, "Bechtelar - Wuckert", "Anderson", "968.783.7977 x80675", "Cole" },
                    { 112, 112, "Prohaska, Wilkinson and Stiedemann", "Dell", "1-918-847-6971 x83974", "Nitzsche" },
                    { 113, 113, "Dickens and Sons", "Geoffrey", "554.916.3302 x8397", "Lowe" },
                    { 114, 114, "Raynor, West and Strosin", "Wade", "212-778-5573 x80158", "Grady" },
                    { 115, 115, "Jacobs - Heller", "Carmella", "799.909.5426 x429", "Greenfelder" },
                    { 116, 116, "D'Amore - Huel", "Clementina", "828-802-7201 x55892", "Heller" },
                    { 117, 117, "Schumm Inc", "Eryn", "257-348-2161 x20348", "Runolfsdottir" },
                    { 118, 118, "Borer - Wolf", "Maymie", "1-660-362-7132 x8508", "Gleason" },
                    { 119, 119, "Rippin, Beatty and MacGyver", "Horacio", "1-435-245-4772", "Lebsack" },
                    { 120, 120, "Kutch - Bergstrom", "Javonte", "754-893-9343 x61704", "Tillman" },
                    { 121, 121, "Roberts LLC", "Ciara", "673.336.9209", "Doyle" },
                    { 122, 122, "Schaden - Veum", "Fredy", "(201) 391-1920 x67374", "Quigley" },
                    { 123, 123, "Pagac and Sons", "Berta", "379-713-3238 x67374", "Reichel" },
                    { 124, 124, "Boyle and Sons", "Jamil", "292-483-4014 x29085", "Altenwerth" },
                    { 125, 125, "Cummings Group", "Ona", "(900) 390-0150 x6790", "Reinger" },
                    { 126, 126, "Runolfsson - Rippin", "Dasia", "1-334-373-8989 x46211", "Zulauf" },
                    { 127, 127, "VonRueden Inc", "Stanley", "936-620-8154 x677", "Graham" },
                    { 128, 128, "Padberg - Stark", "Leann", "(326) 269-4893 x8637", "Hickle" },
                    { 129, 129, "Funk - Ratke", "Alexander", "373-258-9474 x137", "Schneider" },
                    { 130, 130, "Berge and Sons", "Melvina", "1-729-886-8303 x2987", "Tillman" },
                    { 131, 131, "Kessler, Emmerich and Harber", "Sterling", "214.915.8161 x5821", "Considine" },
                    { 132, 132, "Witting - Borer", "Trisha", "(615) 853-5878 x0879", "O'Connell" },
                    { 133, 133, "Upton - Collier", "Jensen", "941.361.5634", "Raynor" },
                    { 134, 134, "Hudson and Sons", "Jacinto", "897.600.3817", "Feest" },
                    { 135, 135, "Hand LLC", "Marlon", "373.540.8388 x537", "Smith" },
                    { 136, 136, "Lueilwitz - Grady", "Myah", "1-691-688-6090", "Kilback" },
                    { 137, 137, "Cassin LLC", "Lolita", "887.777.5815", "Legros" },
                    { 138, 138, "Boehm, Lebsack and Deckow", "Rashawn", "(602) 438-4899", "McDermott" },
                    { 139, 139, "Nitzsche - Rogahn", "Sabrina", "558.873.7000", "Predovic" },
                    { 140, 140, "Ullrich - Leannon", "Jewell", "603-259-4848", "Roberts" },
                    { 141, 141, "Steuber, Corwin and Friesen", "Gino", "(932) 273-1591", "Parker" },
                    { 142, 142, "Langosh LLC", "Erna", "377.236.5373", "Kub" },
                    { 143, 143, "Mitchell, Towne and Waters", "Rogelio", "(643) 798-6975 x7139", "Mueller" },
                    { 144, 144, "Greenfelder - Parker", "Adrain", "(925) 904-3556 x9378", "Farrell" },
                    { 145, 145, "Price, Bechtelar and Simonis", "Camylle", "807-724-4232", "Cormier" },
                    { 146, 146, "Moore, Watsica and Romaguera", "Millie", "(451) 530-6434 x98288", "Jenkins" },
                    { 147, 147, "Padberg Inc", "Dereck", "882.224.0770 x1215", "Connelly" },
                    { 148, 148, "Nikolaus - Stamm", "Jeanne", "(494) 840-3052 x642", "McKenzie" },
                    { 149, 149, "Larkin and Sons", "Leon", "1-676-637-5032", "Weber" },
                    { 150, 150, "Simonis - McCullough", "Mallory", "947-311-0154 x700", "Orn" },
                    { 151, 151, "Frami Inc", "Tanner", "925-668-9080", "Homenick" },
                    { 152, 152, "Boyle - Schmidt", "Lempi", "419.345.5190 x503", "Pfeffer" },
                    { 153, 153, "Jaskolski, Von and Douglas", "Mae", "779-610-1003 x94349", "Reichert" },
                    { 154, 154, "Rutherford, Koch and Little", "Hollie", "1-639-678-6581", "Bartell" },
                    { 155, 155, "Spencer, Streich and O'Hara", "Helga", "1-440-461-1789 x5171", "Emard" },
                    { 156, 156, "Schumm LLC", "Andreane", "423.554.7545 x345", "Corwin" },
                    { 157, 157, "Dare, Boehm and Lowe", "Arnaldo", "(389) 313-1050 x252", "Thiel" },
                    { 158, 158, "Kovacek - Yundt", "Arnold", "(462) 436-1509 x225", "Bosco" },
                    { 159, 159, "Padberg and Sons", "Amir", "1-427-394-3719", "Lueilwitz" },
                    { 160, 160, "Dickens Inc", "Jacky", "395-620-7103 x7745", "Murphy" },
                    { 161, 161, "Johnson and Sons", "Myriam", "267-609-9677", "Skiles" },
                    { 162, 162, "Schroeder Group", "Kenton", "202-241-6575 x35787", "Lesch" },
                    { 163, 163, "Mueller and Sons", "Lelah", "(330) 513-3198 x80333", "Mante" },
                    { 164, 164, "McCullough - Schumm", "Simone", "1-254-599-9915", "Tromp" },
                    { 165, 165, "Wintheiser, West and Smitham", "Karen", "433-777-4534", "Raynor" },
                    { 166, 166, "Miller - Batz", "Keon", "(807) 362-4327 x3804", "Ratke" },
                    { 167, 167, "Stanton - West", "Freeda", "627.819.5463", "Legros" },
                    { 168, 168, "Wehner Inc", "Elenora", "550-929-1035 x4995", "Dickens" },
                    { 169, 169, "Osinski - Bauch", "Keaton", "967.470.7864 x67283", "Boyle" },
                    { 170, 170, "Schaefer, Kozey and Swaniawski", "Lance", "(545) 641-6486", "Nolan" },
                    { 171, 171, "Donnelly LLC", "Colleen", "422-449-9671 x16856", "Hand" },
                    { 172, 172, "Heidenreich - O'Reilly", "Sydney", "352-615-9601", "Braun" },
                    { 173, 173, "O'Reilly Group", "Blanca", "1-545-888-3905", "Mosciski" },
                    { 174, 174, "Abshire LLC", "Rowland", "(326) 660-2400", "Becker" },
                    { 175, 175, "Wisoky, Altenwerth and Abshire", "Trudie", "(384) 953-2261", "Kirlin" },
                    { 176, 176, "Denesik - Weimann", "Tamia", "(839) 596-3505", "Daugherty" },
                    { 177, 177, "Conn, Hettinger and White", "Adolfo", "(992) 686-2940 x87200", "O'Keefe" },
                    { 178, 178, "Swift - Cremin", "Keanu", "1-252-649-4186 x183", "Mohr" },
                    { 179, 179, "Jacobi and Sons", "Royce", "256.958.7476 x4740", "Bartell" },
                    { 180, 180, "Schultz Inc", "Georgiana", "775.836.8906", "Adams" },
                    { 181, 181, "Aufderhar Inc", "Presley", "693.874.6539 x789", "Lemke" },
                    { 182, 182, "Jacobi Group", "Rosalyn", "493-399-8403", "Pacocha" },
                    { 183, 183, "Osinski - O'Hara", "Jonatan", "366-521-2149", "Roob" },
                    { 184, 184, "Wiza Group", "Elian", "523.865.0490", "Hoppe" },
                    { 185, 185, "Dibbert - Walter", "Dante", "1-324-920-7198", "Blanda" },
                    { 186, 186, "Aufderhar, Watsica and Simonis", "Kaleb", "482.335.6317 x25021", "Schimmel" },
                    { 187, 187, "Rau, Roob and Veum", "Aliya", "1-504-276-0405 x72601", "Walsh" },
                    { 188, 188, "Skiles and Sons", "Madisen", "(469) 667-1206", "Bernhard" },
                    { 189, 189, "Bayer, Hermann and Schowalter", "Sandrine", "836.967.7851 x66953", "Emard" },
                    { 190, 190, "Thiel, Breitenberg and Koss", "Genesis", "920.880.1213", "Kovacek" },
                    { 191, 191, "Stanton, Maggio and Powlowski", "Maryam", "(810) 955-5103 x1473", "Homenick" },
                    { 192, 192, "Langworth, O'Keefe and Bahringer", "Kathleen", "863-793-8096 x1446", "Jacobi" },
                    { 193, 193, "Hickle - Cartwright", "Hildegard", "1-869-884-9939 x6190", "Greenholt" },
                    { 194, 194, "Gutmann, Klocko and Reynolds", "Jonatan", "1-260-292-7415 x5267", "Fadel" },
                    { 195, 195, "Yost LLC", "Jesus", "800.705.4619", "Kuvalis" },
                    { 196, 196, "Von - Bernhard", "Addie", "(982) 915-1308 x3293", "Sawayn" },
                    { 197, 197, "Feest, Anderson and Smitham", "Shirley", "(748) 213-2161", "Hayes" },
                    { 198, 198, "Yost - Hilpert", "Yvonne", "(425) 369-1116 x7119", "Quigley" },
                    { 199, 199, "Carter and Sons", "Lewis", "402.492.4662 x53057", "Harber" },
                    { 200, 200, "Nader - Schiller", "Gaetano", "(445) 719-7955 x76738", "Renner" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AddressId",
                table: "Customers",
                column: "AddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
