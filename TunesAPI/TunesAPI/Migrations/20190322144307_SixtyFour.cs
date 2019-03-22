using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace TunesAPI.Migrations
{
    public partial class SixtyFour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tunes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IrishChart = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Artist = table.Column<string>(nullable: true),
                    Album = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    AlbumCoverLink = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    BuyLink = table.Column<string>(nullable: true),
                    Realsed = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tunes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tunes",
                columns: new[] { "Id", "Album", "AlbumCoverLink", "Artist", "BuyLink", "Duration", "Genre", "IrishChart", "Price", "Realsed", "Title" },
                values: new object[,]
                {
                    { 1, "Thriller", "https://upload.wikimedia.org/wikipedia/en/thumb/5/55/Michael_Jackson_-_Thriller.png/220px-Michael_Jackson_-_Thriller.png", "Michael Jackson", "https://www.amazon.com/Thriller-Michael-Jackson/dp/B00VSHH9GC/ref=tmm_acd_swatch_0?_encoding=UTF8&qid=1552692547&sr=8-1", "5.58", "Pop", 1, 9.16, new DateTime(1982, 11, 30), "Thriller" },
                    { 2, "Like a Prayer", "https://upload.wikimedia.org/wikipedia/en/thumb/0/08/Madonna_-_Like_a_Prayer_album.png/220px-Madonna_-_Like_a_Prayer_album.png", "Madonna", "https://www.amazon.com/Like-Prayer-Madonna/dp/B000002LGQ/ref=tmm_acd_swatch_0?_encoding=UTF8&qid=1552693261&sr=8-2", "5.41", "Pop",2, 10.03, new DateTime(1989, 3, 17), "Like a Prayer" },
                    { 33, "18 Months", "https://upload.wikimedia.org/wikipedia/en/thumb/d/df/Calvin_Harris_-_18_Months.png/220px-Calvin_Harris_-_18_Months.png", "Calvin Harris", "https://www.amazon.com/18-Months-Calvin-Harris/dp/B0052SF6CM/ref=sr_1_1?keywords=18+months+cd&qid=1552704571&s=gateway&sr=8-1", "3.33", "Dance",33, 6.5, new DateTime(2012, 6, 24), "Sweet Nothing" },
                    { 34, "Dianna Ross", "https://upload.wikimedia.org/wikipedia/en/0/0b/Diana_Ross_%281976_album_-_cover_art%29.jpg", "Dianna Ross", "https://www.amazon.com/Diana-Ross-Definitive-Collection/dp/B000GDI27E/ref=sr_1_fkmrnull_1?keywords=Dianna+Ross+cd&qid=1552704771&s=gateway&sr=8-1-fkmrnull", "7.49", "Disco",34, 6.99, new DateTime(1976, 7, 21), "Love Hangover" },
                    { 35, "Time Out", "https://upload.wikimedia.org/wikipedia/en/thumb/e/e5/Time_out_album_cover.jpg/220px-Time_out_album_cover.jpg", "Dave Brubeck", "https://www.amazon.com/Time-Out-Dave-Brubeck-Quartet/dp/B000002AGN/ref=sr_1_1?keywords=Time+out+cd&qid=1552704943&s=gateway&sr=8-1", "5.22", "Jazz",35, 7.33, new DateTime(1957, 8, 29), "Take Five" },
                    { 36, "Straight Outta Compton", "https://upload.wikimedia.org/wikipedia/en/thumb/8/84/StraightOuttaComptonN.W.A..jpg/220px-StraightOuttaComptonN.W.A..jpg", "N.W.A.", "https://www.amazon.com/Straight-Outta-Compton-20th-Anniversary/dp/B000X9ZERW/ref=sr_1_1?keywords=Straight+Outta+Compton+cd&qid=1552706226&s=gateway&sr=8-1", "4.19", "Hip-Hop",36, 8.98, new DateTime(1988, 2, 15), "Straight Outta Compton" },
                    { 37, "The Complete Chess Studio Recording", "http://i31.fastpic.ru/big/2011/1001/55/98d5a06da1c95b9937a8ddcb8d423155.jpg", "Buddy Guy", "https://www.amazon.com/Complete-Chess-Studio-Recordings/dp/B003EMPZK6/ref=sr_1_fkmrnull_1?keywords=The+Complete+Chess+Studio+Recording+cd&qid=1552706483&s=gateway&sr=8-1-fkmrnull", "7.11", "Blues",37, 19.99, new DateTime(1992, 6, 23), "Stone Crazy" },
                    { 38, "Cold Hard Truth", "https://upload.wikimedia.org/wikipedia/en/7/71/Jones_Cold_Hard_Truth.jpg", "George Jones", "https://www.amazon.com/Cold-Hard-Truth-George-Jones/dp/B001OGTOQA/ref=sr_1_1?keywords=cold+hard+truth+cd&qid=1552706729&s=gateway&sr=8-1", "3.26", "Country",38, 12.82, new DateTime(1999, 6, 29), "Choices" },
                    { 39, "Paranoid", "https://upload.wikimedia.org/wikipedia/en/thumb/6/64/Black_Sabbath_-_Paranoid.jpg/220px-Black_Sabbath_-_Paranoid.jpg", "Black Sabbath", "https://www.amazon.com/Paranoid-Deluxe-2CD-Black-Sabbath/dp/B018VEE4QW/ref=sr_1_1?keywords=Paranoid+cd&qid=1552706875&s=gateway&sr=8-1", "2.47", "Metal",39, 12.98, new DateTime(1970, 5, 11), "Paranoid" },
                    { 40, "KC & The Sunshine Band", "https://upload.wikimedia.org/wikipedia/en/thumb/c/c5/KC_and_the_Sunshine_Band_album_cover.jpg/220px-KC_and_the_Sunshine_Band_album_cover.jpg", "KC & The Sunshine Band", "https://www.amazon.com/KC-Sunshine-Band/dp/B0067J76W8/ref=sr_1_5?keywords=kc+%26+the+sunshine+band+cd&qid=1552707021&s=gateway&sr=8-5", "3.05", "Disco",40, 16.5, new DateTime(1975, 9, 27), "That's The Way I Like It" },
                    { 41, "Break Out", "https://is5-ssl.mzstatic.com/image/thumb/Music111/v4/c2/58/60/c2586042-f794-94e3-7626-f168e60d0113/886446391632.jpg/268x0w.jpg", "Pointer Sisters", "https://www.amazon.com/Pointer-Sisters-Break-Planet-Records/dp/B000026KK5/ref=sr_1_1?keywords=break+out+cd+pointer+sisters&qid=1552707265&s=gateway&sr=8-1", "4.53", "Disco",41, 10.93, new DateTime(1982, 10, 23), "I'm So Excited" },
                    { 42, "My Favorite Things", "https://upload.wikimedia.org/wikipedia/en/9/9b/My_Favorite_Things.jpg", "John Coltrane", "https://www.amazon.com/My-Favorite-Things-John-Coltrane/dp/B000002I53/ref=sr_1_1?keywords=My+Favorite+Things+cd&qid=1552700563&s=gateway&sr=8-1", "9.54", "Jazz",42, 9.16, new DateTime(1961, 6, 26), "Acknowledgement" },
                    { 43, "Metallica", "https://upload.wikimedia.org/wikipedia/en/2/2c/Metallica_-_Metallica_cover.jpg", "Metallica ", "https://www.amazon.com/Metallica/dp/B00EBDXU4A/ref=sr_1_2?keywords=Metallica+cd&qid=1552707583&s=gateway&sr=8-2", "5.31", "Metal",43, 10.36, new DateTime(1991, 11, 22), "Enter Sandman" },
                    { 44, "Who's Next", "https://upload.wikimedia.org/wikipedia/en/thumb/4/44/Whosnext.jpg/220px-Whosnext.jpg", "The Who", "https://www.amazon.com/Whos-Next-Who/dp/B000002OX7/ref=sr_1_1?keywords=whos+next+cd&qid=1552707753&s=gateway&sr=8-1", "6.23", "Metal",44, 7.71, new DateTime(1971, 12, 1), "Won’t Get Fooled Again" },
                    { 32, "The Singles Plus", "https://img.discogs.com/QzCHNmYVCAPSN0a14wM967-2HQA=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-4664328-1371509778-4615.jpeg.jpg", "The Animals", "https://www.amazon.com/Singles-Plus-ANIMALS/dp/B00000K44Q/ref=sr_1_2?keywords=the+singles+plus+cd&qid=1552704292&s=gateway&sr=8-2", "4.30", "Folk",32, 26.1, new DateTime(1967, 7, 18), "House of the Rising Sun" },
                    { 45, "Kind of Blue", "https://upload.wikimedia.org/wikipedia/en/thumb/9/9c/MilesDavisKindofBlue.jpg/220px-MilesDavisKindofBlue.jpg", "Miles Davis", "https://www.amazon.com/Kind-Blue-Miles-Davis/dp/B000002ADT/ref=sr_1_1?crid=1J17552KUPNQ4&keywords=miles+davis+kind+of+blue+cd&qid=1552696828&s=gateway&sprefix=kind+of+cd%2Caps%2C262&sr=8-1", "9.53", "Jazz",45, 7.31, new DateTime(1959, 2, 21), "Freddie Freeloader" },
                    { 47, "Live Like You Were Dying", "https://upload.wikimedia.org/wikipedia/en/thumb/8/89/Tim_McGraw_-_Live_Like_You_Were_Dying.jpg/220px-Tim_McGraw_-_Live_Like_You_Were_Dying.jpg", "Tim McGraw", "https://www.amazon.com/Live-Like-Were-Dying-McGraw/dp/B01K8QTCBI/ref=sr_1_1?keywords=Live+Like+You+Were+Dying+cd&qid=1552710660&s=gateway&sr=8-1", "5.00", "Country",47, 18.37, new DateTime(2004, 9, 9), "Live Like You Were Dying" },
                    { 48, "Jolene", "https://upload.wikimedia.org/wikipedia/en/thumb/a/ab/Jolene_%28Dolly_Parton_album_-_cover_art%29.jpg/220px-Jolene_%28Dolly_Parton_album_-_cover_art%29.jpg", "Dolly Parton", "https://www.amazon.com/Jolene-Expanded-Dolly-Parton/dp/B0045DO8K6/ref=sr_1_1?keywords=jolene+cd&qid=1552710781&s=gateway&sr=8-1", "2.42", "Country",48, 6.32, new DateTime(1974, 10, 24), "Jolene" },
                    { 49, "Hooker", "https://img.discogs.com/4PdIiGmf0amaDH9hxEPWPbGXZmg=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-1135850-1378361961-9892.jpeg.jpg", "John Lee Hooker", "https://www.amazon.com/John-Lee-Hooker-Collection-1948-1990/dp/B0000032HO/ref=sr_1_9?keywords=Hooker+cd&qid=1552710920&s=gateway&sr=8-9", "3.10", "Blues",49, 20.48, new DateTime(1994, 5, 3), "Boogie Chillen’" },
                    { 50, "Push the Button", "https://upload.wikimedia.org/wikipedia/en/thumb/5/5b/The_Chemical_Brothers_-_Push_the_Button_album_cover.png/220px-The_Chemical_Brothers_-_Push_the_Button_album_cover.png", "Chemical Brothers", "https://www.amazon.com/Push-Button-CHEMICAL-BROTHERS/dp/B00TG0BRB6/ref=sr_1_1?keywords=push+the+button+cd&qid=1552711065&s=gateway&sr=8-1", "4.23", "Dance",50, 20.99, new DateTime(2005, 9, 30), "Hold Tight London" },
                    { 51, "Every Time We Touch", "https://upload.wikimedia.org/wikipedia/en/thumb/8/8c/Everytime_we_touch_cover.jpg/220px-Everytime_we_touch_cover.jpg", "Cascada", "https://www.amazon.com/Everytime-We-Touch-Cascada/dp/B000E6EJ2A/ref=sr_1_2?keywords=everytime+we+touch+cd&qid=1552711225&s=gateway&sr=8-2", "3.19", "Dance",51, 11.92, new DateTime(2006, 3, 15), "Every Time We Touch" },
                    { 52, "Both Sides Now", "https://upload.wikimedia.org/wikipedia/en/thumb/c/c4/Joni_Mitchell-Both_Sides_Now.jpg/220px-Joni_Mitchell-Both_Sides_Now.jpg", "Joni Mitchell", "https://www.amazon.com/Both-Sides-Now-JONI-MITCHELL/dp/B000040OVH/ref=sr_1_1?keywords=Both+Sides+Now+cd&qid=1552711381&s=gateway&sr=8-1", "5.45", "Folk",52, 9.53, new DateTime(2000, 12, 15), "Both Sides Now" },
                    { 53, "Fire and Water", "https://upload.wikimedia.org/wikipedia/en/thumb/c/c6/Fireandwater_albumcover.jpg/220px-Fireandwater_albumcover.jpg", "Free ", "https://www.amazon.com/Fire-Water-Free/dp/B000002G9S/ref=sr_1_1?keywords=Fire+and+Water+cd&qid=1552711483&s=gateway&sr=8-1", "5.13", "Rock",53, 7.37, new DateTime(1970, 6, 14), "All Right Now" },
                    { 54, "The Best of Don McLean", "https://images-na.ssl-images-amazon.com/images/I/71jkBEfXvhL._SX355_.jpg", "Don McLean", "https://www.amazon.com/Best-Don-McLean/dp/B000002UUF/ref=sr_1_1?keywords=The+Best+of+Don+McLean+cd&qid=1552711639&s=gateway&sr=8-1", "8.36", "Folk",54, 11.68, new DateTime(1988, 10, 23), "American Pie" },
                    { 55, "Moanin' in the Moonlight", "https://upload.wikimedia.org/wikipedia/en/thumb/4/42/Howlin%27_Wolf_Moanin%27_in_the_Moonlight.jpg/220px-Howlin%27_Wolf_Moanin%27_in_the_Moonlight.jpg", "Howlin’ Wolf", "https://www.amazon.com/Moanin-Moonlight-Howlin-Wolf/dp/B01LD3F0GQ/ref=sr_1_2?keywords=Moanin%27+in+the+Moonlight+cd&qid=1552711873&s=gateway&sr=8-2", "3.08", "Blues",55, 11.02, new DateTime(1958, 12, 14), "Smokestack Lightning" },
                    { 56, "Nevermind", "https://upload.wikimedia.org/wikipedia/en/thumb/b/b7/NirvanaNevermindalbumcover.jpg/220px-NirvanaNevermindalbumcover.jpg", "Nirvana ", "https://www.amazon.com/Nevermind-Nirvana/dp/B000003TA4/ref=sr_1_1?keywords=Nevermind+cd&qid=1552711986&s=gateway&sr=8-1", "5.12", "Metal",56, 11.02, new DateTime(1991, 3, 31), "Smells Like Teen Spirit" },
                    { 57, "My Favorite Things", "https://upload.wikimedia.org/wikipedia/en/9/9b/My_Favorite_Things.jpg", "John Coltrane", "https://www.amazon.com/My-Favorite-Things-John-Coltrane/dp/B000002I53/ref=sr_1_1?keywords=My+Favorite+Things+cd&qid=1552700563&s=gateway&sr=8-1", "8.54", "Jazz",57, 9.16, new DateTime(1961, 6, 26), "Psalm" },
                    { 58, "Enter the Wu-Tang (36 Chambers)", "https://upload.wikimedia.org/wikipedia/en/thumb/5/53/Wu-TangClanEntertheWu-Tangalbumcover.jpg/220px-Wu-TangClanEntertheWu-Tangalbumcover.jpg", "Wu-Tang Clan", "https://www.amazon.com/Enter-Wu-Tang-36-Chambers-Clan/dp/B000002WPI/ref=sr_1_1?keywords=enter+the+wu+tang+cd&qid=1552712200&s=gateway&sr=8-1", "4.12", "Hip-Hop",58, 6.88, new DateTime(1993, 7, 27), "C.R.E.A.M" },
                    { 46, "T-Bone Walker", "https://img.discogs.com/6iUyv7VTVKEa5Plcg6wLt8hbKj0=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-4201563-1358998116-7704.jpeg.jpg", "T-Bone Walker", "https://www.amazon.com/Collectors-T-Bone-Walk-T-Bone-Walker/dp/B000FKO0VU/ref=sr_1_fkmrnull_1?keywords=Call+It+Stormy+Monday+cd&qid=1552710404&s=gateway&sr=8-1-fkmrnull", "3.03", "Blues",46, 21.32, new DateTime(1965, 4, 9), "Call It Stormy Monday" },
                    { 59, "Showcase", "https://images-na.ssl-images-amazon.com/images/I/513FJ48mNNL._SY300_QL70_.jpg", "Patsy Cline", "https://www.amazon.com/Patsy-Cline-Showcase/dp/B000002NW2/ref=sr_1_3?keywords=showcase+cd&qid=1552712374&s=gateway&sr=8-3", "2.01", "Country",59, 7.35, new DateTime(1961, 12, 29), "Walkin’ After Midnight" },
                    { 31, "Highway 61 Revisited", "https://upload.wikimedia.org/wikipedia/en/thumb/9/95/Bob_Dylan_-_Highway_61_Revisited.jpg/220px-Bob_Dylan_-_Highway_61_Revisited.jpg", "Bob Dylan", "https://www.amazon.com/Highway-61-Revisited-Bob-Dylan/dp/B00026WU82/ref=sr_1_1?keywords=Highway+61+Revisited+cd&qid=1552704023&s=gateway&sr=8-1", "6.10", "Folk",31, 6.7, new DateTime(1965, 7, 3), "Like a Rolling Stone" },
                    { 29, "No Strings Attached", "https://upload.wikimedia.org/wikipedia/en/thumb/a/a1/Nsync_-_No_Strings_Attached.png/220px-Nsync_-_No_Strings_Attached.png", "N Sync", "https://www.amazon.com/No-Strings-Attached-NSYNC/dp/B008DVJOWI/ref=sr_1_2?crid=18HLMIJ6PK408&keywords=no+strings+attached+cd&qid=1552703683&s=gateway&sprefix=no+strin%2Caps%2C270&sr=8-2", "3.11", "Pop",29, 4.39, new DateTime(2000, 4, 4), "It’s Gonna Be Me" },
                    { 3, "Led Zepplin IV", "https://upload.wikimedia.org/wikipedia/en/thumb/2/26/Led_Zeppelin_-_Led_Zeppelin_IV.jpg/220px-Led_Zeppelin_-_Led_Zeppelin_IV.jpg", "Led Zepplin", "https://www.amazon.com/Led-Zeppelin-IV-Deluxe-CD/dp/B00M30SPMU/ref=sr_1_1?crid=38NA70ZQWMMCM&keywords=led+zepplin+iv&qid=1552693714&s=gateway&sprefix=led+zepplin+iv%2Caps%2C246&sr=8-1", "7.58", "Rock",3, 12.86, new DateTime(1971, 10, 27), "Stairway To Heaven" },
                    { 4, "A Night at The Opera", "https://upload.wikimedia.org/wikipedia/en/thumb/4/4d/Queen_A_Night_At_The_Opera.png/220px-Queen_A_Night_At_The_Opera.png", "Queen", "https://www.amazon.com/Night-At-Opera-Remastered/dp/B0052SNOIK/ref=sr_1_1?crid=3TY4Y1M2B51RX&keywords=a+night+at+the+opera+queen+cd&qid=1552694385&s=gateway&sprefix=a+night+a%2Caps%2C267&sr=8-1", "5.54", "Rock",4, 12.85, new DateTime(1975, 7, 26), "Bohermian Rhapsody" },
                    { 5, "I Walk the Line", "https://upload.wikimedia.org/wikipedia/en/thumb/e/ec/JohnnyCashIWalkTheLine.jpg/220px-JohnnyCashIWalkTheLine.jpg", "Johnny Cash", "https://www.amazon.com/Walk-Line-Very-Best-Johnny/dp/B00000HX5N/ref=sr_1_2?keywords=i+walk+the+line+cd&qid=1552694833&s=gateway&sr=8-2", "2.35", "Country",5, 15.61, new DateTime(1694, 2, 2), "I Walk the Line" },
                    { 6, "We Can't Be Stopped", "https://upload.wikimedia.org/wikipedia/en/thumb/0/0f/Geto_boys_we_can%27t_be_stopped_cover.jpg/220px-Geto_boys_we_can%27t_be_stopped_cover.jpg", "Geto Boys", "https://www.amazon.com/We-CanT-Stopped-Geto-Boys/dp/B000000W7U/ref=sr_1_fkmrnull_1?keywords=we+cant+be+stopped+cd&qid=1552695483&s=gateway&sr=8-1-fkmrnull", "5.09", "Hip-Hop",6, 11.93, new DateTime(1991, 3, 16), "Mind Playing Tricks on Me" },
                    { 7, "Street Songs", "https://upload.wikimedia.org/wikipedia/en/thumb/a/a1/Rick_James_-_Street_Songs.jpg/220px-Rick_James_-_Street_Songs.jpg", "Rick James", "https://www.amazon.com/Street-Songs-Motown-Classic-Albums/dp/B000078JLI/ref=sr_1_1?crid=UE2GAATQI64T&keywords=street+songs+cd&qid=1552695764&s=gateway&sprefix=street+songs%2Caps%2C262&sr=8-1", "3.25", "Disco",7, 12.85, new DateTime(1981, 11, 11), "Super Freak" },
                    { 8, "1999", "https://upload.wikimedia.org/wikipedia/en/thumb/c/cb/1999_cover.jpg/220px-1999_cover.jpg", "Prince", "https://www.amazon.com/1999-Prince/dp/B000002KY8/ref=sr_1_1?crid=2EGJI52JGCGLK&keywords=1999+cd+prince&qid=1552696164&s=gateway&sprefix=1999+cd%2Caps%2C276&sr=8-1", "6.19", "Disco",8, 10.101, new DateTime(1982, 10, 15), "1999" },
                    { 9, "Purple Rain", "https://upload.wikimedia.org/wikipedia/en/thumb/9/9c/Princepurplerain.jpg/220px-Princepurplerain.jpg", "Prince", "https://www.amazon.com/Purple-Rain-Deluxe-2CD-Prince/dp/B071DQNJVF/ref=sr_1_2?crid=3AMUZHTN2VCGL&keywords=prince+purple+rain+cd&qid=1552696205&s=gateway&sprefix=Purple+cd+prince%2Caps%2C288&sr=8-2", "5.53", "Pop",9, 13.67, new DateTime(1984, 9, 23), "When Doves Cry" },
                    { 10, "King of the Electric Blues", "https://images-na.ssl-images-amazon.com/images/I/51j8kfF3rfL._SY355_.jpg", "Muddy Waters", "https://www.amazon.com/King-Electric-Blues-Muddy-Waters/dp/B0060ANLU0/ref=sr_1_1?keywords=king+of+electric+blues+cd&qid=1552696634&s=gateway&sr=8-1", "3.59", "Blues",10, 5.5, new DateTime(1977, 4, 7), "Hoochie Coochie Man" },
                    { 11, "Kind of Blue", "https://upload.wikimedia.org/wikipedia/en/thumb/9/9c/MilesDavisKindofBlue.jpg/220px-MilesDavisKindofBlue.jpg", "Miles Davis", "https://www.amazon.com/Kind-Blue-Miles-Davis/dp/B000002ADT/ref=sr_1_1?crid=1J17552KUPNQ4&keywords=miles+davis+kind+of+blue+cd&qid=1552696828&s=gateway&sprefix=kind+of+cd%2Caps%2C262&sr=8-1", "9.53", "Jazz",11, 7.31, new DateTime(1959, 2, 21), "So What" },
                    { 12, "Appetite for Destruction", "https://upload.wikimedia.org/wikipedia/en/thumb/6/60/GunsnRosesAppetiteforDestructionalbumcover.jpg/220px-GunsnRosesAppetiteforDestructionalbumcover.jpg", "Guns N' Roses", "https://www.amazon.com/Appetite-Destruction-Guns-N-Roses/dp/B000000OQF/ref=sr_1_2?crid=1ZOYTVIFDIL9Z&keywords=appetite+for+destruction+cd&qid=1552697299&s=gateway&sprefix=appetite++cd%2Caps%2C255&sr=8-2", "4.33", "Metal",12, 9.06, new DateTime(1987, 3, 31), "Welcome to the Jungle" },
                    { 13, "Born Slippy (Nuxx)", "http://www.treblezine.com/wp-content/uploads/2014/10/underworld-born-slippy.jpg", "Underworld", "https://www.amazon.com/Born-Slippy-Underworld/dp/B000003RJJ/ref=sr_1_1?keywords=born+slippy+cd&qid=1552697668&s=gateway&sr=8-1", "4.24", "Dance",13, 20.47, new DateTime(1995, 1, 4), "Born Slippy" },
                    { 14, "Bridge Over Troubled Water", "https://upload.wikimedia.org/wikipedia/en/thumb/4/41/Simon_and_Garfunkel%2C_Bridge_over_Troubled_Water_%281970%29.png/220px-Simon_and_Garfunkel%2C_Bridge_over_Troubled_Water_%281970%29.png", "Simon and Garfunkle", "https://www.amazon.com/Bridge-Troubled-Water-Simon-Garfunkel/dp/B00005NKKZ/ref=sr_1_1?crid=10EZ9FP1AVHYF&keywords=bridge+over+troubled+water+cd&qid=1552698124&s=gateway&sprefix=bridge+over+cd%2Caps%2C276&sr=8-1", "4.53", "Folk",14, 15.29, new DateTime(1970, 11, 27), "Bridge Over Troubled Water" },
                    { 30, "Ready to Die", "https://upload.wikimedia.org/wikipedia/en/thumb/9/97/Ready_To_Die.jpg/220px-Ready_To_Die.jpg", "Notorious B.I.G", "https://www.amazon.com/Ready-Die-NOTORIOUS-B-I-G/dp/B014Q2980U/ref=sr_1_1?keywords=Ready+to+Die+cd&qid=1552703835&s=gateway&sr=8-1", "5.03", "Hip-Hop",30, 19.47, new DateTime(1994, 6, 3), "Juicy" },
                    { 15, "The Ultimate Hits", "https://upload.wikimedia.org/wikipedia/en/thumb/a/a1/GarthBrooksUltimate.jpg/220px-GarthBrooksUltimate.jpg", "Garth Brooks", "https://www.amazon.com/Garth-Brooks-Ultimate-Hits/dp/B01JUMUPGW/ref=sr_1_1?crid=TDZ7FYM14NX0&keywords=friends+in+low+places+cd&qid=1552698307&s=gateway&sprefix=friends+in+low++cd%2Caps%2C273&sr=8-1", "4.33", "Country",15, 5.92, new DateTime(1985, 8, 16), "Friends in Low PLaces" },
                    { 17, "Pronounced 'Lĕh-'nérd 'Skin-'nérd", "https://upload.wikimedia.org/wikipedia/en/thumb/b/b0/Lynyrdskynyrd.jpg/220px-Lynyrdskynyrd.jpg", "Lynyrd Skynyrd", "https://www.amazon.com/Pronounced-L%C4%95h-n%C3%A9rd-Skin-n%C3%A9rd-Lynyrd-Skynyrd/dp/B00005RIKI/ref=sr_1_3?keywords=lynyrd+skynyrd+cd&qid=1552698795&s=gateway&sr=8-3", "9.19", "Rock",17, 6.29, new DateTime(1973, 5, 21), "Free Bird" },
                    { 18, "Machine Head", "https://upload.wikimedia.org/wikipedia/en/thumb/0/00/Machine_Head_album_cover.jpg/220px-Machine_Head_album_cover.jpg", "Deep Purple", "https://www.amazon.com/Machine-Head-DEEP-PURPLE/dp/B0144RDSDU/ref=sr_1_2?crid=1KB4EPIOPTP4J&keywords=machine+head+cd+deep+purple&qid=1552699092&s=gateway&sprefix=machine+head++cd%2Caps%2C301&sr=8-2", "5.41", "Rock",18, 11.5, new DateTime(1972, 10, 30), "Smoke on the Water" },
                    { 19, "The Chronic", "https://upload.wikimedia.org/wikipedia/en/thumb/1/19/Dr.DreTheChronic.jpg/220px-Dr.DreTheChronic.jpg", "Dr. Dre", "https://www.amazon.com/Chronic-Explicit-Version-Dr-Dre/dp/B00005AQEQ/ref=sr_1_1?crid=IOD3EKIZ1XII&keywords=dr+dre+the+chronic+cd&qid=1552699273&s=gateway&sprefix=The+Chronic+cd+%2Caps%2C312&sr=8-1", "4.11", "Hip-Hop",19, 11.44, new DateTime(1992, 1, 17), "Nuthin' But a 'G' Thang " },
                    { 20, "Fear of a Black Planet", "https://upload.wikimedia.org/wikipedia/en/thumb/6/6c/Fear_of_a_Black_Planet.jpg/220px-Fear_of_a_Black_Planet.jpg", "Public Enemy", "https://www.amazon.com/Fear-Black-Planet-Public-Enemy/dp/B0000024IE/ref=sr_1_1?keywords=Fear+of+a+Black+Planet+cd&qid=1552699485&s=gateway&sr=8-1", "3.59", "Hip-Hop",20, 14.36, new DateTime(1990, 5, 13), "Fight the Power" },
                    { 21, "Car Wash", "https://upload.wikimedia.org/wikipedia/en/thumb/b/b6/RoseRoyceCarWash.jpg/220px-RoseRoyceCarWash.jpg", "Rose Royce", "https://www.amazon.com/Best-Rose-Royce/dp/B000002QU8/ref=sr_1_1?crid=1P015DIPBM0VM&keywords=rose+royce+car+wash+cd&qid=1552699695&s=gateway&sprefix=Car+wash++cd%2Caps%2C302&sr=8-1", "5.08", "Disco",21, 8.37, new DateTime(1976, 6, 15), "Car Wash" },
                    { 22, "Discovery", "https://upload.wikimedia.org/wikipedia/en/thumb/a/ae/Daft_Punk_-_Discovery.jpg/220px-Daft_Punk_-_Discovery.jpg", "Daft Punk", "https://www.amazon.com/Discovery-Daft-Punk/dp/B000059MEK/ref=sr_1_1?keywords=discovery+cd&qid=1552699920&s=gateway&sr=8-1", "3.45", "Dance",22, 11.03, new DateTime(2001, 9, 25), "Harder Better Faster Stronger" },
                    { 23, "Completely Well", "https://upload.wikimedia.org/wikipedia/en/b/bd/B.B._King_Completely_Well.jpg", "B.B. King", "https://www.amazon.com/Completely-Well-B-B-King/dp/B0000062Y4/ref=sr_1_1?keywords=Completely+Well+cd&qid=1552700086&s=gateway&sr=8-1", "5.25", "Blues",23, 11.01, new DateTime(1969, 9, 30), "The Thrill is Gone" },
                    { 24, "Back in Black", "https://upload.wikimedia.org/wikipedia/en/thumb/5/5c/ACDC_Back_in_Black_Single_Cover.jpg/220px-ACDC_Back_in_Black_Single_Cover.jpg", "AC/DC", "https://www.amazon.com/Back-Black-AC-DC/dp/B000089RV6/ref=sr_1_1?crid=406K3392OUQ2&keywords=acdc+back+in+black+cd&qid=1552700415&s=gateway&sprefix=back+in+cd%2Caps%2C257&sr=8-1", "4.15", "Metal",24, 9.17, new DateTime(1980, 10, 10), "Back in Black" },
                    { 25, "My Favorite Things", "https://upload.wikimedia.org/wikipedia/en/9/9b/My_Favorite_Things.jpg", "John Coltrane", "https://www.amazon.com/My-Favorite-Things-John-Coltrane/dp/B000002I53/ref=sr_1_1?keywords=My+Favorite+Things+cd&qid=1552700563&s=gateway&sr=8-1", "13.44", "Jazz",25, 9.16, new DateTime(1961, 6, 26), "My Favorite Things" },
                    { 26, "Blonde on Blonde", "https://upload.wikimedia.org/wikipedia/en/thumb/3/38/Bob_Dylan_-_Blonde_on_Blonde.jpg/220px-Bob_Dylan_-_Blonde_on_Blonde.jpg", "Bob Dylan", "https://www.amazon.com/Blonde-Dylan-Original-recording-remastered/dp/B00G2JRK3I/ref=sr_1_2?crid=1MAM2FBL7IULA&keywords=blonde+on+blonde+cd+bob+dylan&qid=1552700734&s=gateway&sprefix=Blonde+on+Blonde+cd%2Caps%2C-1&sr=8-2", "7.13", "Folk",26, 26.7, new DateTime(1966, 5, 18), "Visions of Johanna" },
                    { 27, "...Baby One More Time", "https://upload.wikimedia.org/wikipedia/en/thumb/9/9a/..._Baby_One_More_Time_%28album%29.png/220px-..._Baby_One_More_Time_%28album%29.png", "Britney Spears", "https://www.amazon.com/Baby-More-Time-Britney-Spears/dp/B009AVFRUS/ref=sr_1_1?keywords=Baby+One+More+Time+cd&qid=1552703256&s=gateway&sr=8-1", "3.31", "Pop",27, 6.32, new DateTime(1999, 4, 21), "...Baby One More Time" },
                    { 28, "The Wall", "https://t2.genius.com/unsafe/220x220/https%3A%2F%2Fimages.genius.com%2F155a3e08b009e97f099100cc738beb46.325x325x1.jpg", "Pink Floyd", "https://www.amazon.com/WALL-PINK-FLOYD/dp/B00EMKV91S/ref=sr_1_1?crid=2VO6SJFMX3GR5&keywords=the+wall+cd&qid=1552703490&s=gateway&sprefix=the+wall+cd%2Caps%2C276&sr=8-1", "6.22", "Rock",28, 15.96, new DateTime(1976, 3, 12), "Comfortably Numb" },
                    { 16, "Whitney", "https://upload.wikimedia.org/wikipedia/en/thumb/a/a9/Whitney_Houston_-_Whitney_%28album%29.jpg/220px-Whitney_Houston_-_Whitney_%28album%29.jpg", "Whitney Houston", "https://www.amazon.com/Whitney-Houston/dp/B000002VEB/ref=sr_1_2?keywords=whitney+cd&qid=1552698584&s=gateway&sr=8-2", "4.51", "Pop",16, 8.2, new DateTime(1987, 11, 5), "I Wana Dance With Somebody" },
                    { 60, "Kernkraft 400", "https://images-na.ssl-images-amazon.com/images/I/51xMrOlu70L._SY355_.jpg", "Zombie Nation", "https://www.amazon.com/Kernkraft-400-Zombie-Nation/dp/B00004TWJS/ref=sr_1_1?keywords=kernkraft+400+cd&qid=1552712477&s=gateway&sr=8-1", "4.45", "Dance",60, 5.05, new DateTime(1999, 5, 12), "Kernkraft 400" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Tunes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DropTable(
                name: "Tunes");
        }
    
    }
}
