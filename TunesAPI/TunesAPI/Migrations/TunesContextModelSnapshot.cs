﻿// <auto-generated />
using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TunesAPI;

namespace TunesAPI.Migrations
{
    [ExcludeFromCodeCoverage]
    [DbContext(typeof(TunesContext))]
    partial class TunesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TunesAPI.SuggestedTunes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Artist");

                    b.Property<int>("Count");

                    b.Property<string>("Genre");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("SuggestedTunes");

                    b.HasData(
                        new { Id = 1, Artist = "The Beatles", Count = 3, Genre = "Rock", Title = "Hey Jude" },
                        new { Id = 2, Artist = "Black Eyed Peas", Count = 2, Genre = "Pop", Title = "Where is the Love" },
                        new { Id = 3, Artist = "AC/DC", Count = 4, Genre = "Metal", Title = "Thunderstruck" },
                        new { Id = 4, Artist = "Jay-Z", Count = 2, Genre = "Hip-Hop", Title = "99 Problems" },
                        new { Id = 5, Artist = "Nathan Carter", Count = 1, Genre = "Country", Title = "Wagon Wheel" }
                    );
                });

            modelBuilder.Entity("TunesAPI.Tunes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Album");

                    b.Property<string>("AlbumCoverLink");

                    b.Property<string>("Artist");

                    b.Property<string>("BuyLink");

                    b.Property<string>("Duration");

                    b.Property<string>("Genre");

                    b.Property<int>("IrishChart");

                    b.Property<double>("Price");

                    b.Property<DateTime>("Realsed");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Tunes");

                    b.HasData(
                        new { Id = 1, Album = "Thriller", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/5/55/Michael_Jackson_-_Thriller.png/220px-Michael_Jackson_-_Thriller.png", Artist = "Michael Jackson", BuyLink = "https://www.amazon.com/Thriller-Michael-Jackson/dp/B00VSHH9GC/ref=tmm_acd_swatch_0?_encoding=UTF8&qid=1552692547&sr=8-1", Duration = "5.58", Genre = "Pop", IrishChart = 1, Price = 9.16, Realsed = new DateTime(1982, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Thriller" },
                        new { Id = 2, Album = "Like a Prayer", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/0/08/Madonna_-_Like_a_Prayer_album.png/220px-Madonna_-_Like_a_Prayer_album.png", Artist = "Madonna", BuyLink = "https://www.amazon.com/Like-Prayer-Madonna/dp/B000002LGQ/ref=tmm_acd_swatch_0?_encoding=UTF8&qid=1552693261&sr=8-2", Duration = "5.41", Genre = "Pop", IrishChart = 2, Price = 10.03, Realsed = new DateTime(1989, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Like a Prayer" },
                        new { Id = 3, Album = "Led Zepplin IV", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/2/26/Led_Zeppelin_-_Led_Zeppelin_IV.jpg/220px-Led_Zeppelin_-_Led_Zeppelin_IV.jpg", Artist = "Led Zepplin", BuyLink = "https://www.amazon.com/Led-Zeppelin-IV-Deluxe-CD/dp/B00M30SPMU/ref=sr_1_1?crid=38NA70ZQWMMCM&keywords=led+zepplin+iv&qid=1552693714&s=gateway&sprefix=led+zepplin+iv%2Caps%2C246&sr=8-1", Duration = "7.58", Genre = "Rock", IrishChart = 3, Price = 12.86, Realsed = new DateTime(1971, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Stairway To Heaven" },
                        new { Id = 4, Album = "A Night at The Opera", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/4/4d/Queen_A_Night_At_The_Opera.png/220px-Queen_A_Night_At_The_Opera.png", Artist = "Queen", BuyLink = "https://www.amazon.com/Night-At-Opera-Remastered/dp/B0052SNOIK/ref=sr_1_1?crid=3TY4Y1M2B51RX&keywords=a+night+at+the+opera+queen+cd&qid=1552694385&s=gateway&sprefix=a+night+a%2Caps%2C267&sr=8-1", Duration = "5.54", Genre = "Rock", IrishChart = 4, Price = 12.85, Realsed = new DateTime(1975, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Bohermian Rhapsody" },
                        new { Id = 5, Album = "I Walk the Line", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/e/ec/JohnnyCashIWalkTheLine.jpg/220px-JohnnyCashIWalkTheLine.jpg", Artist = "Johnny Cash", BuyLink = "https://www.amazon.com/Walk-Line-Very-Best-Johnny/dp/B00000HX5N/ref=sr_1_2?keywords=i+walk+the+line+cd&qid=1552694833&s=gateway&sr=8-2", Duration = "2.35", Genre = "Country", IrishChart = 5, Price = 15.61, Realsed = new DateTime(1694, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "I Walk the Line" },
                        new { Id = 6, Album = "We Can't Be Stopped", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/0/0f/Geto_boys_we_can%27t_be_stopped_cover.jpg/220px-Geto_boys_we_can%27t_be_stopped_cover.jpg", Artist = "Geto Boys", BuyLink = "https://www.amazon.com/We-CanT-Stopped-Geto-Boys/dp/B000000W7U/ref=sr_1_fkmrnull_1?keywords=we+cant+be+stopped+cd&qid=1552695483&s=gateway&sr=8-1-fkmrnull", Duration = "5.09", Genre = "Hip-Hop", IrishChart = 6, Price = 11.93, Realsed = new DateTime(1991, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Mind Playing Tricks on Me" },
                        new { Id = 7, Album = "Street Songs", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a1/Rick_James_-_Street_Songs.jpg/220px-Rick_James_-_Street_Songs.jpg", Artist = "Rick James", BuyLink = "https://www.amazon.com/Street-Songs-Motown-Classic-Albums/dp/B000078JLI/ref=sr_1_1?crid=UE2GAATQI64T&keywords=street+songs+cd&qid=1552695764&s=gateway&sprefix=street+songs%2Caps%2C262&sr=8-1", Duration = "3.25", Genre = "Disco", IrishChart = 7, Price = 12.85, Realsed = new DateTime(1981, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Super Freak" },
                        new { Id = 8, Album = "1999", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/c/cb/1999_cover.jpg/220px-1999_cover.jpg", Artist = "Prince", BuyLink = "https://www.amazon.com/1999-Prince/dp/B000002KY8/ref=sr_1_1?crid=2EGJI52JGCGLK&keywords=1999+cd+prince&qid=1552696164&s=gateway&sprefix=1999+cd%2Caps%2C276&sr=8-1", Duration = "6.19", Genre = "Disco", IrishChart = 8, Price = 10.101, Realsed = new DateTime(1982, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "1999" },
                        new { Id = 9, Album = "Purple Rain", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9c/Princepurplerain.jpg/220px-Princepurplerain.jpg", Artist = "Prince", BuyLink = "https://www.amazon.com/Purple-Rain-Deluxe-2CD-Prince/dp/B071DQNJVF/ref=sr_1_2?crid=3AMUZHTN2VCGL&keywords=prince+purple+rain+cd&qid=1552696205&s=gateway&sprefix=Purple+cd+prince%2Caps%2C288&sr=8-2", Duration = "5.53", Genre = "Pop", IrishChart = 9, Price = 13.67, Realsed = new DateTime(1984, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "When Doves Cry" },
                        new { Id = 10, Album = "King of the Electric Blues", AlbumCoverLink = "https://images-na.ssl-images-amazon.com/images/I/51j8kfF3rfL._SY355_.jpg", Artist = "Muddy Waters", BuyLink = "https://www.amazon.com/King-Electric-Blues-Muddy-Waters/dp/B0060ANLU0/ref=sr_1_1?keywords=king+of+electric+blues+cd&qid=1552696634&s=gateway&sr=8-1", Duration = "3.59", Genre = "Blues", IrishChart = 10, Price = 5.5, Realsed = new DateTime(1977, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Hoochie Coochie Man" },
                        new { Id = 11, Album = "Kind of Blue", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9c/MilesDavisKindofBlue.jpg/220px-MilesDavisKindofBlue.jpg", Artist = "Miles Davis", BuyLink = "https://www.amazon.com/Kind-Blue-Miles-Davis/dp/B000002ADT/ref=sr_1_1?crid=1J17552KUPNQ4&keywords=miles+davis+kind+of+blue+cd&qid=1552696828&s=gateway&sprefix=kind+of+cd%2Caps%2C262&sr=8-1", Duration = "9.53", Genre = "Jazz", IrishChart = 11, Price = 7.31, Realsed = new DateTime(1959, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "So What" },
                        new { Id = 12, Album = "Appetite for Destruction", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/6/60/GunsnRosesAppetiteforDestructionalbumcover.jpg/220px-GunsnRosesAppetiteforDestructionalbumcover.jpg", Artist = "Guns N' Roses", BuyLink = "https://www.amazon.com/Appetite-Destruction-Guns-N-Roses/dp/B000000OQF/ref=sr_1_2?crid=1ZOYTVIFDIL9Z&keywords=appetite+for+destruction+cd&qid=1552697299&s=gateway&sprefix=appetite++cd%2Caps%2C255&sr=8-2", Duration = "4.33", Genre = "Metal", IrishChart = 12, Price = 9.06, Realsed = new DateTime(1987, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Welcome to the Jungle" },
                        new { Id = 13, Album = "Born Slippy (Nuxx)", AlbumCoverLink = "http://www.treblezine.com/wp-content/uploads/2014/10/underworld-born-slippy.jpg", Artist = "Underworld", BuyLink = "https://www.amazon.com/Born-Slippy-Underworld/dp/B000003RJJ/ref=sr_1_1?keywords=born+slippy+cd&qid=1552697668&s=gateway&sr=8-1", Duration = "4.24", Genre = "Dance", IrishChart = 13, Price = 20.47, Realsed = new DateTime(1995, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Born Slippy" },
                        new { Id = 14, Album = "Bridge Over Troubled Water", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/4/41/Simon_and_Garfunkel%2C_Bridge_over_Troubled_Water_%281970%29.png/220px-Simon_and_Garfunkel%2C_Bridge_over_Troubled_Water_%281970%29.png", Artist = "Simon and Garfunkle", BuyLink = "https://www.amazon.com/Bridge-Troubled-Water-Simon-Garfunkel/dp/B00005NKKZ/ref=sr_1_1?crid=10EZ9FP1AVHYF&keywords=bridge+over+troubled+water+cd&qid=1552698124&s=gateway&sprefix=bridge+over+cd%2Caps%2C276&sr=8-1", Duration = "4.53", Genre = "Folk", IrishChart = 14, Price = 15.29, Realsed = new DateTime(1970, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Bridge Over Troubled Water" },
                        new { Id = 15, Album = "The Ultimate Hits", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a1/GarthBrooksUltimate.jpg/220px-GarthBrooksUltimate.jpg", Artist = "Garth Brooks", BuyLink = "https://www.amazon.com/Garth-Brooks-Ultimate-Hits/dp/B01JUMUPGW/ref=sr_1_1?crid=TDZ7FYM14NX0&keywords=friends+in+low+places+cd&qid=1552698307&s=gateway&sprefix=friends+in+low++cd%2Caps%2C273&sr=8-1", Duration = "4.33", Genre = "Country", IrishChart = 15, Price = 5.92, Realsed = new DateTime(1985, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Friends in Low PLaces" },
                        new { Id = 16, Album = "Whitney", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a9/Whitney_Houston_-_Whitney_%28album%29.jpg/220px-Whitney_Houston_-_Whitney_%28album%29.jpg", Artist = "Whitney Houston", BuyLink = "https://www.amazon.com/Whitney-Houston/dp/B000002VEB/ref=sr_1_2?keywords=whitney+cd&qid=1552698584&s=gateway&sr=8-2", Duration = "4.51", Genre = "Pop", IrishChart = 16, Price = 8.2, Realsed = new DateTime(1987, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "I Wana Dance With Somebody" },
                        new { Id = 17, Album = "Pronounced 'Lĕh-'nérd 'Skin-'nérd", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/b/b0/Lynyrdskynyrd.jpg/220px-Lynyrdskynyrd.jpg", Artist = "Lynyrd Skynyrd", BuyLink = "https://www.amazon.com/Pronounced-L%C4%95h-n%C3%A9rd-Skin-n%C3%A9rd-Lynyrd-Skynyrd/dp/B00005RIKI/ref=sr_1_3?keywords=lynyrd+skynyrd+cd&qid=1552698795&s=gateway&sr=8-3", Duration = "9.19", Genre = "Rock", IrishChart = 17, Price = 6.29, Realsed = new DateTime(1973, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Free Bird" },
                        new { Id = 18, Album = "Machine Head", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/0/00/Machine_Head_album_cover.jpg/220px-Machine_Head_album_cover.jpg", Artist = "Deep Purple", BuyLink = "https://www.amazon.com/Machine-Head-DEEP-PURPLE/dp/B0144RDSDU/ref=sr_1_2?crid=1KB4EPIOPTP4J&keywords=machine+head+cd+deep+purple&qid=1552699092&s=gateway&sprefix=machine+head++cd%2Caps%2C301&sr=8-2", Duration = "5.41", Genre = "Rock", IrishChart = 18, Price = 11.5, Realsed = new DateTime(1972, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Smoke on the Water" },
                        new { Id = 19, Album = "The Chronic", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/1/19/Dr.DreTheChronic.jpg/220px-Dr.DreTheChronic.jpg", Artist = "Dr. Dre", BuyLink = "https://www.amazon.com/Chronic-Explicit-Version-Dr-Dre/dp/B00005AQEQ/ref=sr_1_1?crid=IOD3EKIZ1XII&keywords=dr+dre+the+chronic+cd&qid=1552699273&s=gateway&sprefix=The+Chronic+cd+%2Caps%2C312&sr=8-1", Duration = "4.11", Genre = "Hip-Hop", IrishChart = 19, Price = 11.44, Realsed = new DateTime(1992, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Nuthin' But a 'G' Thang " },
                        new { Id = 20, Album = "Fear of a Black Planet", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/6/6c/Fear_of_a_Black_Planet.jpg/220px-Fear_of_a_Black_Planet.jpg", Artist = "Public Enemy", BuyLink = "https://www.amazon.com/Fear-Black-Planet-Public-Enemy/dp/B0000024IE/ref=sr_1_1?keywords=Fear+of+a+Black+Planet+cd&qid=1552699485&s=gateway&sr=8-1", Duration = "3.59", Genre = "Hip-Hop", IrishChart = 20, Price = 14.36, Realsed = new DateTime(1990, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Fight the Power" },
                        new { Id = 21, Album = "Car Wash", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/b/b6/RoseRoyceCarWash.jpg/220px-RoseRoyceCarWash.jpg", Artist = "Rose Royce", BuyLink = "https://www.amazon.com/Best-Rose-Royce/dp/B000002QU8/ref=sr_1_1?crid=1P015DIPBM0VM&keywords=rose+royce+car+wash+cd&qid=1552699695&s=gateway&sprefix=Car+wash++cd%2Caps%2C302&sr=8-1", Duration = "5.08", Genre = "Disco", IrishChart = 21, Price = 8.37, Realsed = new DateTime(1976, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Car Wash" },
                        new { Id = 22, Album = "Discovery", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/a/ae/Daft_Punk_-_Discovery.jpg/220px-Daft_Punk_-_Discovery.jpg", Artist = "Daft Punk", BuyLink = "https://www.amazon.com/Discovery-Daft-Punk/dp/B000059MEK/ref=sr_1_1?keywords=discovery+cd&qid=1552699920&s=gateway&sr=8-1", Duration = "3.45", Genre = "Dance", IrishChart = 22, Price = 11.03, Realsed = new DateTime(2001, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Harder Better Faster Stronger" },
                        new { Id = 23, Album = "Completely Well", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/B.B._King_Completely_Well.jpg", Artist = "B.B. King", BuyLink = "https://www.amazon.com/Completely-Well-B-B-King/dp/B0000062Y4/ref=sr_1_1?keywords=Completely+Well+cd&qid=1552700086&s=gateway&sr=8-1", Duration = "5.25", Genre = "Blues", IrishChart = 23, Price = 11.01, Realsed = new DateTime(1969, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "The Thrill is Gone" },
                        new { Id = 24, Album = "Back in Black", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/5/5c/ACDC_Back_in_Black_Single_Cover.jpg/220px-ACDC_Back_in_Black_Single_Cover.jpg", Artist = "AC/DC", BuyLink = "https://www.amazon.com/Back-Black-AC-DC/dp/B000089RV6/ref=sr_1_1?crid=406K3392OUQ2&keywords=acdc+back+in+black+cd&qid=1552700415&s=gateway&sprefix=back+in+cd%2Caps%2C257&sr=8-1", Duration = "4.15", Genre = "Metal", IrishChart = 24, Price = 9.17, Realsed = new DateTime(1980, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Back in Black" },
                        new { Id = 25, Album = "My Favorite Things", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/9/9b/My_Favorite_Things.jpg", Artist = "John Coltrane", BuyLink = "https://www.amazon.com/My-Favorite-Things-John-Coltrane/dp/B000002I53/ref=sr_1_1?keywords=My+Favorite+Things+cd&qid=1552700563&s=gateway&sr=8-1", Duration = "13.44", Genre = "Jazz", IrishChart = 25, Price = 9.16, Realsed = new DateTime(1961, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "My Favorite Things" },
                        new { Id = 26, Album = "Blonde on Blonde", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/3/38/Bob_Dylan_-_Blonde_on_Blonde.jpg/220px-Bob_Dylan_-_Blonde_on_Blonde.jpg", Artist = "Bob Dylan", BuyLink = "https://www.amazon.com/Blonde-Dylan-Original-recording-remastered/dp/B00G2JRK3I/ref=sr_1_2?crid=1MAM2FBL7IULA&keywords=blonde+on+blonde+cd+bob+dylan&qid=1552700734&s=gateway&sprefix=Blonde+on+Blonde+cd%2Caps%2C-1&sr=8-2", Duration = "7.13", Genre = "Folk", IrishChart = 26, Price = 26.7, Realsed = new DateTime(1966, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Visions of Johanna" },
                        new { Id = 27, Album = "...Baby One More Time", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9a/..._Baby_One_More_Time_%28album%29.png/220px-..._Baby_One_More_Time_%28album%29.png", Artist = "Britney Spears", BuyLink = "https://www.amazon.com/Baby-More-Time-Britney-Spears/dp/B009AVFRUS/ref=sr_1_1?keywords=Baby+One+More+Time+cd&qid=1552703256&s=gateway&sr=8-1", Duration = "3.31", Genre = "Pop", IrishChart = 27, Price = 6.32, Realsed = new DateTime(1999, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "...Baby One More Time" },
                        new { Id = 28, Album = "The Wall", AlbumCoverLink = "https://t2.genius.com/unsafe/220x220/https%3A%2F%2Fimages.genius.com%2F155a3e08b009e97f099100cc738beb46.325x325x1.jpg", Artist = "Pink Floyd", BuyLink = "https://www.amazon.com/WALL-PINK-FLOYD/dp/B00EMKV91S/ref=sr_1_1?crid=2VO6SJFMX3GR5&keywords=the+wall+cd&qid=1552703490&s=gateway&sprefix=the+wall+cd%2Caps%2C276&sr=8-1", Duration = "6.22", Genre = "Rock", IrishChart = 28, Price = 15.96, Realsed = new DateTime(1976, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Comfortably Numb" },
                        new { Id = 29, Album = "No Strings Attached", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a1/Nsync_-_No_Strings_Attached.png/220px-Nsync_-_No_Strings_Attached.png", Artist = "N Sync", BuyLink = "https://www.amazon.com/No-Strings-Attached-NSYNC/dp/B008DVJOWI/ref=sr_1_2?crid=18HLMIJ6PK408&keywords=no+strings+attached+cd&qid=1552703683&s=gateway&sprefix=no+strin%2Caps%2C270&sr=8-2", Duration = "3.11", Genre = "Pop", IrishChart = 29, Price = 4.39, Realsed = new DateTime(2000, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "It’s Gonna Be Me" },
                        new { Id = 30, Album = "Ready to Die", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/9/97/Ready_To_Die.jpg/220px-Ready_To_Die.jpg", Artist = "Notorious B.I.G", BuyLink = "https://www.amazon.com/Ready-Die-NOTORIOUS-B-I-G/dp/B014Q2980U/ref=sr_1_1?keywords=Ready+to+Die+cd&qid=1552703835&s=gateway&sr=8-1", Duration = "5.03", Genre = "Hip-Hop", IrishChart = 30, Price = 19.47, Realsed = new DateTime(1994, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Juicy" },
                        new { Id = 31, Album = "Highway 61 Revisited", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/9/95/Bob_Dylan_-_Highway_61_Revisited.jpg/220px-Bob_Dylan_-_Highway_61_Revisited.jpg", Artist = "Bob Dylan", BuyLink = "https://www.amazon.com/Highway-61-Revisited-Bob-Dylan/dp/B00026WU82/ref=sr_1_1?keywords=Highway+61+Revisited+cd&qid=1552704023&s=gateway&sr=8-1", Duration = "6.10", Genre = "Folk", IrishChart = 31, Price = 6.7, Realsed = new DateTime(1965, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Like a Rolling Stone" },
                        new { Id = 32, Album = "The Singles Plus", AlbumCoverLink = "https://img.discogs.com/QzCHNmYVCAPSN0a14wM967-2HQA=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-4664328-1371509778-4615.jpeg.jpg", Artist = "The Animals", BuyLink = "https://www.amazon.com/Singles-Plus-ANIMALS/dp/B00000K44Q/ref=sr_1_2?keywords=the+singles+plus+cd&qid=1552704292&s=gateway&sr=8-2", Duration = "4.30", Genre = "Folk", IrishChart = 32, Price = 26.1, Realsed = new DateTime(1967, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "House of the Rising Sun" },
                        new { Id = 33, Album = "18 Months", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/d/df/Calvin_Harris_-_18_Months.png/220px-Calvin_Harris_-_18_Months.png", Artist = "Calvin Harris", BuyLink = "https://www.amazon.com/18-Months-Calvin-Harris/dp/B0052SF6CM/ref=sr_1_1?keywords=18+months+cd&qid=1552704571&s=gateway&sr=8-1", Duration = "3.33", Genre = "Dance", IrishChart = 33, Price = 6.5, Realsed = new DateTime(2012, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Sweet Nothing" },
                        new { Id = 34, Album = "Dianna Ross", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/0/0b/Diana_Ross_%281976_album_-_cover_art%29.jpg", Artist = "Dianna Ross", BuyLink = "https://www.amazon.com/Diana-Ross-Definitive-Collection/dp/B000GDI27E/ref=sr_1_fkmrnull_1?keywords=Dianna+Ross+cd&qid=1552704771&s=gateway&sr=8-1-fkmrnull", Duration = "7.49", Genre = "Disco", IrishChart = 34, Price = 6.99, Realsed = new DateTime(1976, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Love Hangover" },
                        new { Id = 35, Album = "Time Out", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/e/e5/Time_out_album_cover.jpg/220px-Time_out_album_cover.jpg", Artist = "Dave Brubeck", BuyLink = "https://www.amazon.com/Time-Out-Dave-Brubeck-Quartet/dp/B000002AGN/ref=sr_1_1?keywords=Time+out+cd&qid=1552704943&s=gateway&sr=8-1", Duration = "5.22", Genre = "Jazz", IrishChart = 35, Price = 7.33, Realsed = new DateTime(1957, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Take Five" },
                        new { Id = 36, Album = "Straight Outta Compton", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/8/84/StraightOuttaComptonN.W.A..jpg/220px-StraightOuttaComptonN.W.A..jpg", Artist = "N.W.A.", BuyLink = "https://www.amazon.com/Straight-Outta-Compton-20th-Anniversary/dp/B000X9ZERW/ref=sr_1_1?keywords=Straight+Outta+Compton+cd&qid=1552706226&s=gateway&sr=8-1", Duration = "4.19", Genre = "Hip-Hop", IrishChart = 36, Price = 8.98, Realsed = new DateTime(1988, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Straight Outta Compton" },
                        new { Id = 37, Album = "The Complete Chess Studio Recording", AlbumCoverLink = "http://i31.fastpic.ru/big/2011/1001/55/98d5a06da1c95b9937a8ddcb8d423155.jpg", Artist = "Buddy Guy", BuyLink = "https://www.amazon.com/Complete-Chess-Studio-Recordings/dp/B003EMPZK6/ref=sr_1_fkmrnull_1?keywords=The+Complete+Chess+Studio+Recording+cd&qid=1552706483&s=gateway&sr=8-1-fkmrnull", Duration = "7.11", Genre = "Blues", IrishChart = 37, Price = 19.99, Realsed = new DateTime(1992, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Stone Crazy" },
                        new { Id = 38, Album = "Cold Hard Truth", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/7/71/Jones_Cold_Hard_Truth.jpg", Artist = "George Jones", BuyLink = "https://www.amazon.com/Cold-Hard-Truth-George-Jones/dp/B001OGTOQA/ref=sr_1_1?keywords=cold+hard+truth+cd&qid=1552706729&s=gateway&sr=8-1", Duration = "3.26", Genre = "Country", IrishChart = 38, Price = 12.82, Realsed = new DateTime(1999, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Choices" },
                        new { Id = 39, Album = "Paranoid", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/6/64/Black_Sabbath_-_Paranoid.jpg/220px-Black_Sabbath_-_Paranoid.jpg", Artist = "Black Sabbath", BuyLink = "https://www.amazon.com/Paranoid-Deluxe-2CD-Black-Sabbath/dp/B018VEE4QW/ref=sr_1_1?keywords=Paranoid+cd&qid=1552706875&s=gateway&sr=8-1", Duration = "2.47", Genre = "Metal", IrishChart = 39, Price = 12.98, Realsed = new DateTime(1970, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Paranoid" },
                        new { Id = 40, Album = "KC & The Sunshine Band", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c5/KC_and_the_Sunshine_Band_album_cover.jpg/220px-KC_and_the_Sunshine_Band_album_cover.jpg", Artist = "KC & The Sunshine Band", BuyLink = "https://www.amazon.com/KC-Sunshine-Band/dp/B0067J76W8/ref=sr_1_5?keywords=kc+%26+the+sunshine+band+cd&qid=1552707021&s=gateway&sr=8-5", Duration = "3.05", Genre = "Disco", IrishChart = 40, Price = 16.5, Realsed = new DateTime(1975, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "That's The Way I Like It" },
                        new { Id = 41, Album = "Break Out", AlbumCoverLink = "https://is5-ssl.mzstatic.com/image/thumb/Music111/v4/c2/58/60/c2586042-f794-94e3-7626-f168e60d0113/886446391632.jpg/268x0w.jpg", Artist = "Pointer Sisters", BuyLink = "https://www.amazon.com/Pointer-Sisters-Break-Planet-Records/dp/B000026KK5/ref=sr_1_1?keywords=break+out+cd+pointer+sisters&qid=1552707265&s=gateway&sr=8-1", Duration = "4.53", Genre = "Disco", IrishChart = 41, Price = 10.93, Realsed = new DateTime(1982, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "I'm So Excited" },
                        new { Id = 42, Album = "My Favorite Things", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/9/9b/My_Favorite_Things.jpg", Artist = "John Coltrane", BuyLink = "https://www.amazon.com/My-Favorite-Things-John-Coltrane/dp/B000002I53/ref=sr_1_1?keywords=My+Favorite+Things+cd&qid=1552700563&s=gateway&sr=8-1", Duration = "9.54", Genre = "Jazz", IrishChart = 42, Price = 9.16, Realsed = new DateTime(1961, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Acknowledgement" },
                        new { Id = 43, Album = "Metallica", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/2/2c/Metallica_-_Metallica_cover.jpg", Artist = "Metallica ", BuyLink = "https://www.amazon.com/Metallica/dp/B00EBDXU4A/ref=sr_1_2?keywords=Metallica+cd&qid=1552707583&s=gateway&sr=8-2", Duration = "5.31", Genre = "Metal", IrishChart = 43, Price = 10.36, Realsed = new DateTime(1991, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Enter Sandman" },
                        new { Id = 44, Album = "Who's Next", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/4/44/Whosnext.jpg/220px-Whosnext.jpg", Artist = "The Who", BuyLink = "https://www.amazon.com/Whos-Next-Who/dp/B000002OX7/ref=sr_1_1?keywords=whos+next+cd&qid=1552707753&s=gateway&sr=8-1", Duration = "6.23", Genre = "Metal", IrishChart = 44, Price = 7.71, Realsed = new DateTime(1971, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Won’t Get Fooled Again" },
                        new { Id = 45, Album = "Kind of Blue", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9c/MilesDavisKindofBlue.jpg/220px-MilesDavisKindofBlue.jpg", Artist = "Miles Davis", BuyLink = "https://www.amazon.com/Kind-Blue-Miles-Davis/dp/B000002ADT/ref=sr_1_1?crid=1J17552KUPNQ4&keywords=miles+davis+kind+of+blue+cd&qid=1552696828&s=gateway&sprefix=kind+of+cd%2Caps%2C262&sr=8-1", Duration = "9.53", Genre = "Jazz", IrishChart = 45, Price = 7.31, Realsed = new DateTime(1959, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Freddie Freeloader" },
                        new { Id = 46, Album = "T-Bone Walker", AlbumCoverLink = "https://img.discogs.com/6iUyv7VTVKEa5Plcg6wLt8hbKj0=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-4201563-1358998116-7704.jpeg.jpg", Artist = "T-Bone Walker", BuyLink = "https://www.amazon.com/Collectors-T-Bone-Walk-T-Bone-Walker/dp/B000FKO0VU/ref=sr_1_fkmrnull_1?keywords=Call+It+Stormy+Monday+cd&qid=1552710404&s=gateway&sr=8-1-fkmrnull", Duration = "3.03", Genre = "Blues", IrishChart = 46, Price = 21.32, Realsed = new DateTime(1965, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Call It Stormy Monday" },
                        new { Id = 47, Album = "Live Like You Were Dying", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/8/89/Tim_McGraw_-_Live_Like_You_Were_Dying.jpg/220px-Tim_McGraw_-_Live_Like_You_Were_Dying.jpg", Artist = "Tim McGraw", BuyLink = "https://www.amazon.com/Live-Like-Were-Dying-McGraw/dp/B01K8QTCBI/ref=sr_1_1?keywords=Live+Like+You+Were+Dying+cd&qid=1552710660&s=gateway&sr=8-1", Duration = "5.00", Genre = "Country", IrishChart = 47, Price = 18.37, Realsed = new DateTime(2004, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Live Like You Were Dying" },
                        new { Id = 48, Album = "Jolene", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/a/ab/Jolene_%28Dolly_Parton_album_-_cover_art%29.jpg/220px-Jolene_%28Dolly_Parton_album_-_cover_art%29.jpg", Artist = "Dolly Parton", BuyLink = "https://www.amazon.com/Jolene-Expanded-Dolly-Parton/dp/B0045DO8K6/ref=sr_1_1?keywords=jolene+cd&qid=1552710781&s=gateway&sr=8-1", Duration = "2.42", Genre = "Country", IrishChart = 48, Price = 6.32, Realsed = new DateTime(1974, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Jolene" },
                        new { Id = 49, Album = "Hooker", AlbumCoverLink = "https://img.discogs.com/4PdIiGmf0amaDH9hxEPWPbGXZmg=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-1135850-1378361961-9892.jpeg.jpg", Artist = "John Lee Hooker", BuyLink = "https://www.amazon.com/John-Lee-Hooker-Collection-1948-1990/dp/B0000032HO/ref=sr_1_9?keywords=Hooker+cd&qid=1552710920&s=gateway&sr=8-9", Duration = "3.10", Genre = "Blues", IrishChart = 49, Price = 20.48, Realsed = new DateTime(1994, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Boogie Chillen’" },
                        new { Id = 50, Album = "Push the Button", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/5/5b/The_Chemical_Brothers_-_Push_the_Button_album_cover.png/220px-The_Chemical_Brothers_-_Push_the_Button_album_cover.png", Artist = "Chemical Brothers", BuyLink = "https://www.amazon.com/Push-Button-CHEMICAL-BROTHERS/dp/B00TG0BRB6/ref=sr_1_1?keywords=push+the+button+cd&qid=1552711065&s=gateway&sr=8-1", Duration = "4.23", Genre = "Dance", IrishChart = 50, Price = 20.99, Realsed = new DateTime(2005, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Hold Tight London" },
                        new { Id = 51, Album = "Every Time We Touch", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/8/8c/Everytime_we_touch_cover.jpg/220px-Everytime_we_touch_cover.jpg", Artist = "Cascada", BuyLink = "https://www.amazon.com/Everytime-We-Touch-Cascada/dp/B000E6EJ2A/ref=sr_1_2?keywords=everytime+we+touch+cd&qid=1552711225&s=gateway&sr=8-2", Duration = "3.19", Genre = "Dance", IrishChart = 51, Price = 11.92, Realsed = new DateTime(2006, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Every Time We Touch" },
                        new { Id = 52, Album = "Both Sides Now", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c4/Joni_Mitchell-Both_Sides_Now.jpg/220px-Joni_Mitchell-Both_Sides_Now.jpg", Artist = "Joni Mitchell", BuyLink = "https://www.amazon.com/Both-Sides-Now-JONI-MITCHELL/dp/B000040OVH/ref=sr_1_1?keywords=Both+Sides+Now+cd&qid=1552711381&s=gateway&sr=8-1", Duration = "5.45", Genre = "Folk", IrishChart = 52, Price = 9.53, Realsed = new DateTime(2000, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Both Sides Now" },
                        new { Id = 53, Album = "Fire and Water", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c6/Fireandwater_albumcover.jpg/220px-Fireandwater_albumcover.jpg", Artist = "Free ", BuyLink = "https://www.amazon.com/Fire-Water-Free/dp/B000002G9S/ref=sr_1_1?keywords=Fire+and+Water+cd&qid=1552711483&s=gateway&sr=8-1", Duration = "5.13", Genre = "Rock", IrishChart = 53, Price = 7.37, Realsed = new DateTime(1970, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "All Right Now" },
                        new { Id = 54, Album = "The Best of Don McLean", AlbumCoverLink = "https://images-na.ssl-images-amazon.com/images/I/71jkBEfXvhL._SX355_.jpg", Artist = "Don McLean", BuyLink = "https://www.amazon.com/Best-Don-McLean/dp/B000002UUF/ref=sr_1_1?keywords=The+Best+of+Don+McLean+cd&qid=1552711639&s=gateway&sr=8-1", Duration = "8.36", Genre = "Folk", IrishChart = 54, Price = 11.68, Realsed = new DateTime(1988, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "American Pie" },
                        new { Id = 55, Album = "Moanin' in the Moonlight", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/4/42/Howlin%27_Wolf_Moanin%27_in_the_Moonlight.jpg/220px-Howlin%27_Wolf_Moanin%27_in_the_Moonlight.jpg", Artist = "Howlin’ Wolf", BuyLink = "https://www.amazon.com/Moanin-Moonlight-Howlin-Wolf/dp/B01LD3F0GQ/ref=sr_1_2?keywords=Moanin%27+in+the+Moonlight+cd&qid=1552711873&s=gateway&sr=8-2", Duration = "3.08", Genre = "Blues", IrishChart = 55, Price = 11.02, Realsed = new DateTime(1958, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Smokestack Lightning" },
                        new { Id = 56, Album = "Nevermind", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/b/b7/NirvanaNevermindalbumcover.jpg/220px-NirvanaNevermindalbumcover.jpg", Artist = "Nirvana ", BuyLink = "https://www.amazon.com/Nevermind-Nirvana/dp/B000003TA4/ref=sr_1_1?keywords=Nevermind+cd&qid=1552711986&s=gateway&sr=8-1", Duration = "5.12", Genre = "Metal", IrishChart = 56, Price = 11.02, Realsed = new DateTime(1991, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Smells Like Teen Spirit" },
                        new { Id = 57, Album = "My Favorite Things", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/9/9b/My_Favorite_Things.jpg", Artist = "John Coltrane", BuyLink = "https://www.amazon.com/My-Favorite-Things-John-Coltrane/dp/B000002I53/ref=sr_1_1?keywords=My+Favorite+Things+cd&qid=1552700563&s=gateway&sr=8-1", Duration = "8.54", Genre = "Jazz", IrishChart = 57, Price = 9.16, Realsed = new DateTime(1961, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Psalm" },
                        new { Id = 58, Album = "Enter the Wu-Tang (36 Chambers)", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/5/53/Wu-TangClanEntertheWu-Tangalbumcover.jpg/220px-Wu-TangClanEntertheWu-Tangalbumcover.jpg", Artist = "Wu-Tang Clan", BuyLink = "https://www.amazon.com/Enter-Wu-Tang-36-Chambers-Clan/dp/B000002WPI/ref=sr_1_1?keywords=enter+the+wu+tang+cd&qid=1552712200&s=gateway&sr=8-1", Duration = "4.12", Genre = "Hip-Hop", IrishChart = 58, Price = 6.88, Realsed = new DateTime(1993, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "C.R.E.A.M" },
                        new { Id = 59, Album = "Showcase", AlbumCoverLink = "https://images-na.ssl-images-amazon.com/images/I/513FJ48mNNL._SY300_QL70_.jpg", Artist = "Patsy Cline", BuyLink = "https://www.amazon.com/Patsy-Cline-Showcase/dp/B000002NW2/ref=sr_1_3?keywords=showcase+cd&qid=1552712374&s=gateway&sr=8-3", Duration = "2.01", Genre = "Country", IrishChart = 59, Price = 7.35, Realsed = new DateTime(1961, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Walkin’ After Midnight" },
                        new { Id = 60, Album = "Kernkraft 400", AlbumCoverLink = "https://images-na.ssl-images-amazon.com/images/I/51xMrOlu70L._SY355_.jpg", Artist = "Zombie Nation", BuyLink = "https://www.amazon.com/Kernkraft-400-Zombie-Nation/dp/B00004TWJS/ref=sr_1_1?keywords=kernkraft+400+cd&qid=1552712477&s=gateway&sr=8-1", Duration = "4.45", Genre = "Dance", IrishChart = 60, Price = 5.05, Realsed = new DateTime(1999, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Kernkraft 400" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
