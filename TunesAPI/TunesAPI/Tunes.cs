﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TunesAPI
{

    public class TunesContext : DbContext
    {
        public TunesContext(DbContextOptions<TunesContext> options)
            : base(options)
        { }

        public DbSet<Tunes> Tunes { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Tunes>().HasData(
                new Tunes { Id = 1, IrishChart = 1, Title = "Thriller", Artist = "Michael Jackson", Album = "Thriller", Genre = "Pop", Duration = "5.58", Realsed = new DateTime(1982, 11, 30), Price = 9.16, BuyLink = "https://www.amazon.com/Thriller-Michael-Jackson/dp/B00VSHH9GC/ref=tmm_acd_swatch_0?_encoding=UTF8&qid=1552692547&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/5/55/Michael_Jackson_-_Thriller.png/220px-Michael_Jackson_-_Thriller.png" },
                new Tunes { Id = 2, IrishChart = 2, Title = "Like a Prayer", Artist = "Madonna", Album = "Like a Prayer", Genre = "Pop", Duration = "5.41", Realsed = new DateTime(1989, 03, 17), Price = 10.03, BuyLink = "https://www.amazon.com/Like-Prayer-Madonna/dp/B000002LGQ/ref=tmm_acd_swatch_0?_encoding=UTF8&qid=1552693261&sr=8-2", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/0/08/Madonna_-_Like_a_Prayer_album.png/220px-Madonna_-_Like_a_Prayer_album.png" },
                new Tunes { Id = 3, IrishChart = 3, Title = "Stairway To Heaven", Artist = "Led Zepplin", Album = "Led Zepplin IV", Genre = "Rock", Duration = "7.58", Realsed = new DateTime(1971, 10, 27), Price = 12.86, BuyLink = "https://www.amazon.com/Led-Zeppelin-IV-Deluxe-CD/dp/B00M30SPMU/ref=sr_1_1?crid=38NA70ZQWMMCM&keywords=led+zepplin+iv&qid=1552693714&s=gateway&sprefix=led+zepplin+iv%2Caps%2C246&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/2/26/Led_Zeppelin_-_Led_Zeppelin_IV.jpg/220px-Led_Zeppelin_-_Led_Zeppelin_IV.jpg" },
                new Tunes { Id = 4, IrishChart = 4, Title = "Bohermian Rhapsody", Artist = "Queen", Album = "A Night at The Opera", Genre = "Rock", Duration = "5.54", Realsed = new DateTime(1975, 07, 26), Price = 12.85, BuyLink = "https://www.amazon.com/Night-At-Opera-Remastered/dp/B0052SNOIK/ref=sr_1_1?crid=3TY4Y1M2B51RX&keywords=a+night+at+the+opera+queen+cd&qid=1552694385&s=gateway&sprefix=a+night+a%2Caps%2C267&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/4/4d/Queen_A_Night_At_The_Opera.png/220px-Queen_A_Night_At_The_Opera.png" },
                new Tunes { Id = 5, IrishChart = 5, Title = "I Walk the Line", Artist = "Johnny Cash", Album = "I Walk the Line", Genre = "Country", Duration = "2.35", Realsed = new DateTime(1694, 02, 02), Price = 15.61, BuyLink = "https://www.amazon.com/Walk-Line-Very-Best-Johnny/dp/B00000HX5N/ref=sr_1_2?keywords=i+walk+the+line+cd&qid=1552694833&s=gateway&sr=8-2", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/e/ec/JohnnyCashIWalkTheLine.jpg/220px-JohnnyCashIWalkTheLine.jpg" },
                new Tunes { Id = 6, IrishChart = 6, Title = "Mind Playing Tricks on Me", Artist = "Geto Boys", Album = "We Can't Be Stopped", Genre = "Hip-Hop", Duration = "5.09", Realsed = new DateTime(1991, 03, 16), Price = 11.93, BuyLink = "https://www.amazon.com/We-CanT-Stopped-Geto-Boys/dp/B000000W7U/ref=sr_1_fkmrnull_1?keywords=we+cant+be+stopped+cd&qid=1552695483&s=gateway&sr=8-1-fkmrnull", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/0/0f/Geto_boys_we_can%27t_be_stopped_cover.jpg/220px-Geto_boys_we_can%27t_be_stopped_cover.jpg" },
                new Tunes { Id = 7, IrishChart = 7, Title = "Super Freak", Artist = "Rick James", Album = "Street Songs", Genre = "Disco", Duration = "3.25", Realsed = new DateTime(1981, 11, 11), Price = 12.85, BuyLink = "https://www.amazon.com/Street-Songs-Motown-Classic-Albums/dp/B000078JLI/ref=sr_1_1?crid=UE2GAATQI64T&keywords=street+songs+cd&qid=1552695764&s=gateway&sprefix=street+songs%2Caps%2C262&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a1/Rick_James_-_Street_Songs.jpg/220px-Rick_James_-_Street_Songs.jpg" },
                new Tunes { Id = 8, IrishChart = 8, Title = "1999", Artist = "Prince", Album = "1999", Genre = "Disco", Duration = "6.19", Realsed = new DateTime(1982, 10, 15), Price = 10.101, BuyLink = "https://www.amazon.com/1999-Prince/dp/B000002KY8/ref=sr_1_1?crid=2EGJI52JGCGLK&keywords=1999+cd+prince&qid=1552696164&s=gateway&sprefix=1999+cd%2Caps%2C276&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/c/cb/1999_cover.jpg/220px-1999_cover.jpg" },
                new Tunes { Id = 9, IrishChart = 9, Title = "When Doves Cry", Artist = "Prince", Album = "Purple Rain", Genre = "Pop", Duration = "5.53", Realsed = new DateTime(1984, 9, 23), Price = 13.67, BuyLink = "https://www.amazon.com/Purple-Rain-Deluxe-2CD-Prince/dp/B071DQNJVF/ref=sr_1_2?crid=3AMUZHTN2VCGL&keywords=prince+purple+rain+cd&qid=1552696205&s=gateway&sprefix=Purple+cd+prince%2Caps%2C288&sr=8-2", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9c/Princepurplerain.jpg/220px-Princepurplerain.jpg" },
                new Tunes { Id = 10, IrishChart = 10, Title = "Hoochie Coochie Man", Artist = "Muddy Waters", Album = "King of the Electric Blues", Genre = "Blues", Duration = "3.59", Realsed = new DateTime(1977, 4, 7), Price = 5.50, BuyLink = "https://www.amazon.com/King-Electric-Blues-Muddy-Waters/dp/B0060ANLU0/ref=sr_1_1?keywords=king+of+electric+blues+cd&qid=1552696634&s=gateway&sr=8-1", AlbumCoverLink = "https://images-na.ssl-images-amazon.com/images/I/51j8kfF3rfL._SY355_.jpg" },
                new Tunes { Id = 11, IrishChart = 11, Title = "So What", Artist = "Miles Davis", Album = "Kind of Blue", Genre = "Jazz", Duration = "9.53", Realsed = new DateTime(1959, 2, 21), Price = 7.31, BuyLink = "https://www.amazon.com/Kind-Blue-Miles-Davis/dp/B000002ADT/ref=sr_1_1?crid=1J17552KUPNQ4&keywords=miles+davis+kind+of+blue+cd&qid=1552696828&s=gateway&sprefix=kind+of+cd%2Caps%2C262&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9c/MilesDavisKindofBlue.jpg/220px-MilesDavisKindofBlue.jpg" },
                new Tunes { Id = 12, IrishChart = 12, Title = "Welcome to the Jungle", Artist = "Guns N' Roses", Album = "Appetite for Destruction", Genre = "Metal", Duration = "4.33", Realsed = new DateTime(1987, 3, 31), Price = 9.06, BuyLink = "https://www.amazon.com/Appetite-Destruction-Guns-N-Roses/dp/B000000OQF/ref=sr_1_2?crid=1ZOYTVIFDIL9Z&keywords=appetite+for+destruction+cd&qid=1552697299&s=gateway&sprefix=appetite++cd%2Caps%2C255&sr=8-2", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/6/60/GunsnRosesAppetiteforDestructionalbumcover.jpg/220px-GunsnRosesAppetiteforDestructionalbumcover.jpg" },
                new Tunes { Id = 13, IrishChart = 13, Title = "Born Slippy", Artist = "Underworld", Album = "Born Slippy (Nuxx)", Genre = "Dance", Duration = "4.24", Realsed = new DateTime(1995, 1, 4), Price = 20.47, BuyLink = "https://www.amazon.com/Born-Slippy-Underworld/dp/B000003RJJ/ref=sr_1_1?keywords=born+slippy+cd&qid=1552697668&s=gateway&sr=8-1", AlbumCoverLink = "http://www.treblezine.com/wp-content/uploads/2014/10/underworld-born-slippy.jpg" },
                new Tunes { Id = 14, IrishChart = 14, Title = "Bridge Over Troubled Water", Artist = "Simon and Garfunkle", Album = "Bridge Over Troubled Water", Genre = "Folk", Duration = "4.53", Realsed = new DateTime(1970, 11, 27), Price = 15.29, BuyLink = "https://www.amazon.com/Bridge-Troubled-Water-Simon-Garfunkel/dp/B00005NKKZ/ref=sr_1_1?crid=10EZ9FP1AVHYF&keywords=bridge+over+troubled+water+cd&qid=1552698124&s=gateway&sprefix=bridge+over+cd%2Caps%2C276&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/4/41/Simon_and_Garfunkel%2C_Bridge_over_Troubled_Water_%281970%29.png/220px-Simon_and_Garfunkel%2C_Bridge_over_Troubled_Water_%281970%29.png" },
                new Tunes { Id = 15, IrishChart = 15, Title = "Friends in Low PLaces", Artist = "Garth Brooks", Album = "The Ultimate Hits", Genre = "Country", Duration = "4.33", Realsed = new DateTime(1985, 8, 16), Price = 5.92, BuyLink = "https://www.amazon.com/Garth-Brooks-Ultimate-Hits/dp/B01JUMUPGW/ref=sr_1_1?crid=TDZ7FYM14NX0&keywords=friends+in+low+places+cd&qid=1552698307&s=gateway&sprefix=friends+in+low++cd%2Caps%2C273&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a1/GarthBrooksUltimate.jpg/220px-GarthBrooksUltimate.jpg" },
                new Tunes { Id = 16, IrishChart = 16, Title = "I Wana Dance With Somebody", Artist = "Whitney Houston", Album = "Whitney", Genre = "Pop", Duration = "4.51", Realsed = new DateTime(1987, 11, 5), Price = 8.20, BuyLink = "https://www.amazon.com/Whitney-Houston/dp/B000002VEB/ref=sr_1_2?keywords=whitney+cd&qid=1552698584&s=gateway&sr=8-2", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a9/Whitney_Houston_-_Whitney_%28album%29.jpg/220px-Whitney_Houston_-_Whitney_%28album%29.jpg" },
                new Tunes { Id = 17, IrishChart = 17, Title = "Free Bird", Artist = "Lynyrd Skynyrd", Album = "Pronounced 'Lĕh-'nérd 'Skin-'nérd", Genre = "Rock", Duration = "9.19", Realsed = new DateTime(1973, 5, 21), Price = 6.29, BuyLink = "https://www.amazon.com/Pronounced-L%C4%95h-n%C3%A9rd-Skin-n%C3%A9rd-Lynyrd-Skynyrd/dp/B00005RIKI/ref=sr_1_3?keywords=lynyrd+skynyrd+cd&qid=1552698795&s=gateway&sr=8-3", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/b/b0/Lynyrdskynyrd.jpg/220px-Lynyrdskynyrd.jpg" },
                new Tunes { Id = 18, IrishChart = 18, Title = "Smoke on the Water", Artist = "Deep Purple", Album = "Machine Head", Genre = "Rock", Duration = "5.41", Realsed = new DateTime(1972, 10, 30), Price = 11.50, BuyLink = "https://www.amazon.com/Machine-Head-DEEP-PURPLE/dp/B0144RDSDU/ref=sr_1_2?crid=1KB4EPIOPTP4J&keywords=machine+head+cd+deep+purple&qid=1552699092&s=gateway&sprefix=machine+head++cd%2Caps%2C301&sr=8-2", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/0/00/Machine_Head_album_cover.jpg/220px-Machine_Head_album_cover.jpg" },
                new Tunes { Id = 19, IrishChart = 19, Title = "Nuthin' But a 'G' Thang ", Artist = "Dr. Dre", Album = "The Chronic", Genre = "Hip-Hop", Duration = "4.11", Realsed = new DateTime(1992, 01, 17), Price = 11.44, BuyLink = "https://www.amazon.com/Chronic-Explicit-Version-Dr-Dre/dp/B00005AQEQ/ref=sr_1_1?crid=IOD3EKIZ1XII&keywords=dr+dre+the+chronic+cd&qid=1552699273&s=gateway&sprefix=The+Chronic+cd+%2Caps%2C312&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/1/19/Dr.DreTheChronic.jpg/220px-Dr.DreTheChronic.jpg" },
                new Tunes { Id = 20, IrishChart = 20, Title = "Fight the Power", Artist = "Public Enemy", Album = "Fear of a Black Planet", Genre = "Hip-Hop", Duration = "3.59", Realsed = new DateTime(1990, 05, 13), Price = 14.36, BuyLink = "https://www.amazon.com/Fear-Black-Planet-Public-Enemy/dp/B0000024IE/ref=sr_1_1?keywords=Fear+of+a+Black+Planet+cd&qid=1552699485&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/6/6c/Fear_of_a_Black_Planet.jpg/220px-Fear_of_a_Black_Planet.jpg" },
                new Tunes { Id = 21, IrishChart = 21, Title = "Car Wash", Artist = "Rose Royce", Album = "Car Wash", Genre = "Disco", Duration = "5.08", Realsed = new DateTime(1976, 06, 15), Price = 8.37, BuyLink = "https://www.amazon.com/Best-Rose-Royce/dp/B000002QU8/ref=sr_1_1?crid=1P015DIPBM0VM&keywords=rose+royce+car+wash+cd&qid=1552699695&s=gateway&sprefix=Car+wash++cd%2Caps%2C302&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/b/b6/RoseRoyceCarWash.jpg/220px-RoseRoyceCarWash.jpg" },
                new Tunes { Id = 22, IrishChart = 22, Title = "Harder Better Faster Stronger", Artist = "Daft Punk", Album = "Discovery", Genre = "Dance", Duration = "3.45", Realsed = new DateTime(2001, 9, 25), Price = 11.03, BuyLink = "https://www.amazon.com/Discovery-Daft-Punk/dp/B000059MEK/ref=sr_1_1?keywords=discovery+cd&qid=1552699920&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/a/ae/Daft_Punk_-_Discovery.jpg/220px-Daft_Punk_-_Discovery.jpg" },
                new Tunes { Id = 23, IrishChart = 23, Title = "The Thrill is Gone", Artist = "B.B. King", Album = "Completely Well", Genre = "Blues", Duration = "5.25", Realsed = new DateTime(1969, 9, 30), Price = 11.01, BuyLink = "https://www.amazon.com/Completely-Well-B-B-King/dp/B0000062Y4/ref=sr_1_1?keywords=Completely+Well+cd&qid=1552700086&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/B.B._King_Completely_Well.jpg" },
                new Tunes { Id = 24, IrishChart = 24, Title = "Back in Black", Artist = "AC/DC", Album = "Back in Black", Genre = "Metal", Duration = "4.15", Realsed = new DateTime(1980, 10, 10), Price = 9.17, BuyLink = "https://www.amazon.com/Back-Black-AC-DC/dp/B000089RV6/ref=sr_1_1?crid=406K3392OUQ2&keywords=acdc+back+in+black+cd&qid=1552700415&s=gateway&sprefix=back+in+cd%2Caps%2C257&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/5/5c/ACDC_Back_in_Black_Single_Cover.jpg/220px-ACDC_Back_in_Black_Single_Cover.jpg" },
                new Tunes { Id = 25, IrishChart = 25, Title = "My Favorite Things", Artist = "John Coltrane", Album = "My Favorite Things", Genre = "Jazz", Duration = "13.44", Realsed = new DateTime(1961, 6, 26), Price = 9.16, BuyLink = "https://www.amazon.com/My-Favorite-Things-John-Coltrane/dp/B000002I53/ref=sr_1_1?keywords=My+Favorite+Things+cd&qid=1552700563&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/9/9b/My_Favorite_Things.jpg" },
                new Tunes { Id = 26, IrishChart = 26, Title = "Visions of Johanna", Artist = "Bob Dylan", Album = "Blonde on Blonde", Genre = "Folk", Duration = "7.13", Realsed = new DateTime(1966, 5, 18), Price = 26.70, BuyLink = "https://www.amazon.com/Blonde-Dylan-Original-recording-remastered/dp/B00G2JRK3I/ref=sr_1_2?crid=1MAM2FBL7IULA&keywords=blonde+on+blonde+cd+bob+dylan&qid=1552700734&s=gateway&sprefix=Blonde+on+Blonde+cd%2Caps%2C-1&sr=8-2", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/3/38/Bob_Dylan_-_Blonde_on_Blonde.jpg/220px-Bob_Dylan_-_Blonde_on_Blonde.jpg" },
                new Tunes { Id = 27, IrishChart = 27, Title = "...Baby One More Time", Artist = "Britney Spears", Album = "...Baby One More Time", Genre = "Pop", Duration = "3.31", Realsed = new DateTime(1999, 04, 21), Price = 6.32, BuyLink = "https://www.amazon.com/Baby-More-Time-Britney-Spears/dp/B009AVFRUS/ref=sr_1_1?keywords=Baby+One+More+Time+cd&qid=1552703256&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9a/..._Baby_One_More_Time_%28album%29.png/220px-..._Baby_One_More_Time_%28album%29.png" },
                new Tunes { Id = 28, IrishChart = 28, Title = "Comfortably Numb", Artist = "Pink Floyd", Album = "The Wall", Genre = "Rock", Duration = "6.22", Realsed = new DateTime(1976, 03, 12), Price = 15.96, BuyLink = "https://www.amazon.com/WALL-PINK-FLOYD/dp/B00EMKV91S/ref=sr_1_1?crid=2VO6SJFMX3GR5&keywords=the+wall+cd&qid=1552703490&s=gateway&sprefix=the+wall+cd%2Caps%2C276&sr=8-1", AlbumCoverLink = "https://t2.genius.com/unsafe/220x220/https%3A%2F%2Fimages.genius.com%2F155a3e08b009e97f099100cc738beb46.325x325x1.jpg" },
                new Tunes { Id = 29, IrishChart = 29, Title = "It’s Gonna Be Me", Artist = "N Sync", Album = "No Strings Attached", Genre = "Pop", Duration = "3.11", Realsed = new DateTime(2000, 04, 04), Price = 4.39, BuyLink = "https://www.amazon.com/No-Strings-Attached-NSYNC/dp/B008DVJOWI/ref=sr_1_2?crid=18HLMIJ6PK408&keywords=no+strings+attached+cd&qid=1552703683&s=gateway&sprefix=no+strin%2Caps%2C270&sr=8-2", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a1/Nsync_-_No_Strings_Attached.png/220px-Nsync_-_No_Strings_Attached.png" },
                new Tunes { Id = 30, IrishChart = 30, Title = "Juicy", Artist = "Notorious B.I.G", Album = "Ready to Die", Genre = "Hip-Hop", Duration = "5.03", Realsed = new DateTime(1994, 06, 03), Price = 19.47, BuyLink = "https://www.amazon.com/Ready-Die-NOTORIOUS-B-I-G/dp/B014Q2980U/ref=sr_1_1?keywords=Ready+to+Die+cd&qid=1552703835&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/9/97/Ready_To_Die.jpg/220px-Ready_To_Die.jpg" },
                new Tunes { Id = 31, IrishChart = 31, Title = "Like a Rolling Stone", Artist = "Bob Dylan", Album = "Highway 61 Revisited", Genre = "Folk", Duration = "6.10", Realsed = new DateTime(1965, 07, 03), Price = 6.70, BuyLink = "https://www.amazon.com/Highway-61-Revisited-Bob-Dylan/dp/B00026WU82/ref=sr_1_1?keywords=Highway+61+Revisited+cd&qid=1552704023&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/9/95/Bob_Dylan_-_Highway_61_Revisited.jpg/220px-Bob_Dylan_-_Highway_61_Revisited.jpg" },
                new Tunes { Id = 32, IrishChart = 32, Title = "House of the Rising Sun", Artist = "The Animals", Album = "The Singles Plus", Genre = "Folk", Duration = "4.30", Realsed = new DateTime(1967, 07, 18), Price = 26.10, BuyLink = "https://www.amazon.com/Singles-Plus-ANIMALS/dp/B00000K44Q/ref=sr_1_2?keywords=the+singles+plus+cd&qid=1552704292&s=gateway&sr=8-2", AlbumCoverLink = "https://img.discogs.com/QzCHNmYVCAPSN0a14wM967-2HQA=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-4664328-1371509778-4615.jpeg.jpg" },
                new Tunes { Id = 33, IrishChart = 33, Title = "Sweet Nothing", Artist = "Calvin Harris", Album = "18 Months", Genre = "Dance", Duration = "3.33", Realsed = new DateTime(2012, 06, 24), Price = 6.50, BuyLink = "https://www.amazon.com/18-Months-Calvin-Harris/dp/B0052SF6CM/ref=sr_1_1?keywords=18+months+cd&qid=1552704571&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/d/df/Calvin_Harris_-_18_Months.png/220px-Calvin_Harris_-_18_Months.png" },
                new Tunes { Id = 34, IrishChart = 34, Title = "Love Hangover", Artist = "Dianna Ross", Album = "Dianna Ross", Genre = "Disco", Duration = "7.49", Realsed = new DateTime(1976, 7, 21), Price = 6.99, BuyLink = "https://www.amazon.com/Diana-Ross-Definitive-Collection/dp/B000GDI27E/ref=sr_1_fkmrnull_1?keywords=Dianna+Ross+cd&qid=1552704771&s=gateway&sr=8-1-fkmrnull", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/0/0b/Diana_Ross_%281976_album_-_cover_art%29.jpg" },
                new Tunes { Id = 35, IrishChart = 35, Title = "Take Five", Artist = "Dave Brubeck", Album = "Time Out", Genre = "Jazz", Duration = "5.22", Realsed = new DateTime(1957, 08, 29), Price = 7.33, BuyLink = "https://www.amazon.com/Time-Out-Dave-Brubeck-Quartet/dp/B000002AGN/ref=sr_1_1?keywords=Time+out+cd&qid=1552704943&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/e/e5/Time_out_album_cover.jpg/220px-Time_out_album_cover.jpg" },
                new Tunes { Id = 36, IrishChart = 36, Title = "Straight Outta Compton", Artist = "N.W.A.", Album = "Straight Outta Compton", Genre = "Hip-Hop", Duration = "4.19", Realsed = new DateTime(1988, 02, 15), Price = 8.98, BuyLink = "https://www.amazon.com/Straight-Outta-Compton-20th-Anniversary/dp/B000X9ZERW/ref=sr_1_1?keywords=Straight+Outta+Compton+cd&qid=1552706226&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/8/84/StraightOuttaComptonN.W.A..jpg/220px-StraightOuttaComptonN.W.A..jpg" },
                new Tunes { Id = 37, IrishChart = 37, Title = "Stone Crazy", Artist = "Buddy Guy", Album = "The Complete Chess Studio Recording", Genre = "Blues", Duration = "7.11", Realsed = new DateTime(1992, 06, 23), Price = 19.99, BuyLink = "https://www.amazon.com/Complete-Chess-Studio-Recordings/dp/B003EMPZK6/ref=sr_1_fkmrnull_1?keywords=The+Complete+Chess+Studio+Recording+cd&qid=1552706483&s=gateway&sr=8-1-fkmrnull", AlbumCoverLink = "http://i31.fastpic.ru/big/2011/1001/55/98d5a06da1c95b9937a8ddcb8d423155.jpg" },
                new Tunes { Id = 38, IrishChart = 38, Title = "Choices", Artist = "George Jones", Album = "Cold Hard Truth", Genre = "Country", Duration = "3.26", Realsed = new DateTime(1999, 06, 29), Price = 12.82, BuyLink = "https://www.amazon.com/Cold-Hard-Truth-George-Jones/dp/B001OGTOQA/ref=sr_1_1?keywords=cold+hard+truth+cd&qid=1552706729&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/7/71/Jones_Cold_Hard_Truth.jpg" },
                new Tunes { Id = 39, IrishChart = 39, Title = "Paranoid", Artist = "Black Sabbath", Album = "Paranoid", Genre = "Metal", Duration = "2.47", Realsed = new DateTime(1970, 05, 11), Price = 12.98, BuyLink = "https://www.amazon.com/Paranoid-Deluxe-2CD-Black-Sabbath/dp/B018VEE4QW/ref=sr_1_1?keywords=Paranoid+cd&qid=1552706875&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/6/64/Black_Sabbath_-_Paranoid.jpg/220px-Black_Sabbath_-_Paranoid.jpg" },
                new Tunes { Id = 40, IrishChart = 40, Title = "That's The Way I Like It", Artist = "KC & The Sunshine Band", Album = "KC & The Sunshine Band", Genre = "Disco", Duration = "3.05", Realsed = new DateTime(1975, 9, 27), Price = 16.50, BuyLink = "https://www.amazon.com/KC-Sunshine-Band/dp/B0067J76W8/ref=sr_1_5?keywords=kc+%26+the+sunshine+band+cd&qid=1552707021&s=gateway&sr=8-5", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c5/KC_and_the_Sunshine_Band_album_cover.jpg/220px-KC_and_the_Sunshine_Band_album_cover.jpg" },
                new Tunes { Id = 41, IrishChart = 41, Title = "I'm So Excited", Artist = "Pointer Sisters", Album = "Break Out", Genre = "Disco", Duration = "4.53", Realsed = new DateTime(1982, 10, 23), Price = 10.93, BuyLink = "https://www.amazon.com/Pointer-Sisters-Break-Planet-Records/dp/B000026KK5/ref=sr_1_1?keywords=break+out+cd+pointer+sisters&qid=1552707265&s=gateway&sr=8-1", AlbumCoverLink = "https://is5-ssl.mzstatic.com/image/thumb/Music111/v4/c2/58/60/c2586042-f794-94e3-7626-f168e60d0113/886446391632.jpg/268x0w.jpg" },
                new Tunes { Id = 42, IrishChart = 42, Title = "Acknowledgement", Artist = "John Coltrane", Album = "My Favorite Things", Genre = "Jazz", Duration = "9.54", Realsed = new DateTime(1961, 6, 26), Price = 9.16, BuyLink = "https://www.amazon.com/My-Favorite-Things-John-Coltrane/dp/B000002I53/ref=sr_1_1?keywords=My+Favorite+Things+cd&qid=1552700563&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/9/9b/My_Favorite_Things.jpg" },
                new Tunes { Id = 43, IrishChart = 43, Title = "Enter Sandman", Artist = "Metallica ", Album = "Metallica", Genre = "Metal", Duration = "5.31", Realsed = new DateTime(1991, 11, 22), Price = 10.36, BuyLink = "https://www.amazon.com/Metallica/dp/B00EBDXU4A/ref=sr_1_2?keywords=Metallica+cd&qid=1552707583&s=gateway&sr=8-2", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/2/2c/Metallica_-_Metallica_cover.jpg" },
                new Tunes { Id = 44, IrishChart = 44, Title = "Won’t Get Fooled Again", Artist = "The Who", Album = "", Genre = "Metal", Duration = "Who's Next", Realsed = new DateTime(1971, 12, 01), Price = 7.71, BuyLink = "https://www.amazon.com/Whos-Next-Who/dp/B000002OX7/ref=sr_1_1?keywords=whos+next+cd&qid=1552707753&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/4/44/Whosnext.jpg/220px-Whosnext.jpg" },
                new Tunes { Id = 45, IrishChart = 45, Title = "Freddie Freeloader", Artist = "Miles Davis", Album = "Kind of Blue", Genre = "Jazz", Duration = "9.53", Realsed = new DateTime(1959, 2, 21), Price = 7.31, BuyLink = "https://www.amazon.com/Kind-Blue-Miles-Davis/dp/B000002ADT/ref=sr_1_1?crid=1J17552KUPNQ4&keywords=miles+davis+kind+of+blue+cd&qid=1552696828&s=gateway&sprefix=kind+of+cd%2Caps%2C262&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9c/MilesDavisKindofBlue.jpg/220px-MilesDavisKindofBlue.jpg" },
                new Tunes { Id = 46, IrishChart = 46, Title = "Call It Stormy Monday", Artist = "T-Bone Walker", Album = "T-Bone Walker", Genre = "Blues", Duration = "3.03", Realsed = new DateTime(1965, 04, 9), Price = 21.32, BuyLink = "https://www.amazon.com/Collectors-T-Bone-Walk-T-Bone-Walker/dp/B000FKO0VU/ref=sr_1_fkmrnull_1?keywords=Call+It+Stormy+Monday+cd&qid=1552710404&s=gateway&sr=8-1-fkmrnull", AlbumCoverLink = "https://img.discogs.com/6iUyv7VTVKEa5Plcg6wLt8hbKj0=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-4201563-1358998116-7704.jpeg.jpg" },
                new Tunes { Id = 47, IrishChart = 47, Title = "Live Like You Were Dying", Artist = "Tim McGraw", Album = "Live Like You Were Dying", Genre = "Country", Duration = "5.00", Realsed = new DateTime(2004, 09, 09), Price = 18.37, BuyLink = "https://www.amazon.com/Live-Like-Were-Dying-McGraw/dp/B01K8QTCBI/ref=sr_1_1?keywords=Live+Like+You+Were+Dying+cd&qid=1552710660&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/8/89/Tim_McGraw_-_Live_Like_You_Were_Dying.jpg/220px-Tim_McGraw_-_Live_Like_You_Were_Dying.jpg" },
                new Tunes { Id = 48, IrishChart = 48, Title = "Jolene", Artist = "Dolly Parton", Album = "Jolene", Genre = "Country", Duration = "2.42", Realsed = new DateTime(1974, 10, 24), Price = 6.32, BuyLink = "https://www.amazon.com/Jolene-Expanded-Dolly-Parton/dp/B0045DO8K6/ref=sr_1_1?keywords=jolene+cd&qid=1552710781&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/a/ab/Jolene_%28Dolly_Parton_album_-_cover_art%29.jpg/220px-Jolene_%28Dolly_Parton_album_-_cover_art%29.jpg" },
                new Tunes { Id = 49, IrishChart = 49, Title = "Boogie Chillen’", Artist = "John Lee Hooker", Album = "Hooker", Genre = "Blues", Duration = "3.10", Realsed = new DateTime(1994, 5, 3), Price = 20.48, BuyLink = "https://www.amazon.com/John-Lee-Hooker-Collection-1948-1990/dp/B0000032HO/ref=sr_1_9?keywords=Hooker+cd&qid=1552710920&s=gateway&sr=8-9", AlbumCoverLink = "https://img.discogs.com/4PdIiGmf0amaDH9hxEPWPbGXZmg=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-1135850-1378361961-9892.jpeg.jpg" },
                new Tunes { Id = 50, IrishChart = 50, Title = "Hold Tight London", Artist = "Chemical Brothers", Album = "Push the Button", Genre = "Dance", Duration = "4.23", Realsed = new DateTime(2005, 09, 30), Price = 20.99, BuyLink = "https://www.amazon.com/Push-Button-CHEMICAL-BROTHERS/dp/B00TG0BRB6/ref=sr_1_1?keywords=push+the+button+cd&qid=1552711065&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/5/5b/The_Chemical_Brothers_-_Push_the_Button_album_cover.png/220px-The_Chemical_Brothers_-_Push_the_Button_album_cover.png" },
                new Tunes { Id = 51, IrishChart = 51, Title = "Every Time We Touch", Artist = "Cascada", Album = "Every Time We Touch", Genre = "Dance", Duration = "3.19", Realsed = new DateTime(2006, 03, 15), Price = 11.92, BuyLink = "https://www.amazon.com/Everytime-We-Touch-Cascada/dp/B000E6EJ2A/ref=sr_1_2?keywords=everytime+we+touch+cd&qid=1552711225&s=gateway&sr=8-2", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/8/8c/Everytime_we_touch_cover.jpg/220px-Everytime_we_touch_cover.jpg" },
                new Tunes { Id = 52, IrishChart = 52, Title = "Both Sides Now", Artist = "Joni Mitchell", Album = "Both Sides Now", Genre = "Folk", Duration = "5.45", Realsed = new DateTime(2000, 12, 15), Price = 9.53, BuyLink = "https://www.amazon.com/Both-Sides-Now-JONI-MITCHELL/dp/B000040OVH/ref=sr_1_1?keywords=Both+Sides+Now+cd&qid=1552711381&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c4/Joni_Mitchell-Both_Sides_Now.jpg/220px-Joni_Mitchell-Both_Sides_Now.jpg" },
                new Tunes { Id = 53, IrishChart = 53, Title = "All Right Now", Artist = "Free ", Album = "Fire and Water", Genre = "Rock", Duration = "5.13", Realsed = new DateTime(1970, 06, 14), Price = 7.37, BuyLink = "https://www.amazon.com/Fire-Water-Free/dp/B000002G9S/ref=sr_1_1?keywords=Fire+and+Water+cd&qid=1552711483&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c6/Fireandwater_albumcover.jpg/220px-Fireandwater_albumcover.jpg" },
                new Tunes { Id = 54, IrishChart = 54, Title = "American Pie", Artist = "Don McLean", Album = "The Best of Don McLean", Genre = "Folk", Duration = "8.36", Realsed = new DateTime(1988, 10, 23), Price = 11.68, BuyLink = "https://www.amazon.com/Best-Don-McLean/dp/B000002UUF/ref=sr_1_1?keywords=The+Best+of+Don+McLean+cd&qid=1552711639&s=gateway&sr=8-1", AlbumCoverLink = "https://images-na.ssl-images-amazon.com/images/I/71jkBEfXvhL._SX355_.jpg" },
                new Tunes { Id = 55, IrishChart = 55, Title = "Smokestack Lightning", Artist = "Howlin’ Wolf", Album = "Moanin' in the Moonlight", Genre = "Blues", Duration = "3.08", Realsed = new DateTime(1958, 12, 14), Price = 11.02, BuyLink = "https://www.amazon.com/Moanin-Moonlight-Howlin-Wolf/dp/B01LD3F0GQ/ref=sr_1_2?keywords=Moanin%27+in+the+Moonlight+cd&qid=1552711873&s=gateway&sr=8-2", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/4/42/Howlin%27_Wolf_Moanin%27_in_the_Moonlight.jpg/220px-Howlin%27_Wolf_Moanin%27_in_the_Moonlight.jpg" },
                new Tunes { Id = 56, IrishChart = 56, Title = "Smells Like Teen Spirit", Artist = "Nirvana ", Album = "Nevermind", Genre = "Metal", Duration = "5.12", Realsed = new DateTime(1991, 03, 31), Price = 11.02, BuyLink = "https://www.amazon.com/Nevermind-Nirvana/dp/B000003TA4/ref=sr_1_1?keywords=Nevermind+cd&qid=1552711986&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/b/b7/NirvanaNevermindalbumcover.jpg/220px-NirvanaNevermindalbumcover.jpg" },
                new Tunes { Id = 57, IrishChart = 57, Title = "Psalm", Artist = "John Coltrane", Album = "My Favorite Things", Genre = "Jazz", Duration = "8.54", Realsed = new DateTime(1961, 6, 26), Price = 9.16, BuyLink = "https://www.amazon.com/My-Favorite-Things-John-Coltrane/dp/B000002I53/ref=sr_1_1?keywords=My+Favorite+Things+cd&qid=1552700563&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/9/9b/My_Favorite_Things.jpg" },
                new Tunes { Id = 58, IrishChart = 58, Title = "C.R.E.A.M", Artist = "Wu-Tang Clan", Album = "Enter the Wu-Tang (36 Chambers)", Genre = "Hip-Hop", Duration = "4.12", Realsed = new DateTime(1993, 07, 27), Price = 6.88, BuyLink = "https://www.amazon.com/Enter-Wu-Tang-36-Chambers-Clan/dp/B000002WPI/ref=sr_1_1?keywords=enter+the+wu+tang+cd&qid=1552712200&s=gateway&sr=8-1", AlbumCoverLink = "https://upload.wikimedia.org/wikipedia/en/thumb/5/53/Wu-TangClanEntertheWu-Tangalbumcover.jpg/220px-Wu-TangClanEntertheWu-Tangalbumcover.jpg" },
                new Tunes { Id = 59, IrishChart = 59, Title = "Walkin’ After Midnight", Artist = "Patsy Cline", Album = "Showcase", Genre = "Country", Duration = "2.01", Realsed = new DateTime(1961, 12, 29), Price = 7.35, BuyLink = "https://www.amazon.com/Patsy-Cline-Showcase/dp/B000002NW2/ref=sr_1_3?keywords=showcase+cd&qid=1552712374&s=gateway&sr=8-3", AlbumCoverLink = "https://images-na.ssl-images-amazon.com/images/I/513FJ48mNNL._SY300_QL70_.jpg" },
                new Tunes { Id = 60, IrishChart = 60, Title = "Kernkraft 400", Artist = "Zombie Nation", Album = "Kernkraft 400", Genre = "Dance", Duration = "4.45", Realsed = new DateTime(1999, 5, 12), Price = 5.05, BuyLink = "https://www.amazon.com/Kernkraft-400-Zombie-Nation/dp/B00004TWJS/ref=sr_1_1?keywords=kernkraft+400+cd&qid=1552712477&s=gateway&sr=8-1", AlbumCoverLink = "https://images-na.ssl-images-amazon.com/images/I/51xMrOlu70L._SY355_.jpg" }
            );
        }

    }


    public enum Genre
    {
        Pop, Rock, Blues, Folk, Dance, HipHop, Metal, Jazz, Country, Disco 
    }
    public class Tunes
    {
        //ID autogenerates
        public int Id { get; set; }
        public int IrishChart { get; set; }
        public String Title { get; set; }
        public String Artist { get; set; }
        public String Album { get; set; }
        //public Genre Genre { get; set; }
        public String Genre{ get; set; }
        public String AlbumCoverLink { get; set; }
        public double Price { get; set; }
        public String BuyLink { get; set; }
        public DateTime Realsed { get; set; }
        public String Duration { get; set; }
    }

}
