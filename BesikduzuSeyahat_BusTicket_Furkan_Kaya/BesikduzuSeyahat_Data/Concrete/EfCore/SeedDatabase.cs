using BesikduzuSeyahat.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BesikduzuSeyahat.Data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new TicketContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Directions.Count() == 0)
                {
                    context.Directions.AddRange(Directions);
                }


                if (context.Tickets.Count() == 0)
                {
                    context.Tickets.AddRange(Tickets);

                }
                if (context.Cities.Count() == 0)
                {
                    context.Cities.AddRange(Cities);

                }

                context.SaveChanges();
            }
        }

        private static Direction[] Directions =
        {
            new Direction(){ DirectionId=1, Start="İstanbul", direction1="Kocaeli", direction2="Kütahya", direction3="Afyon", Finish="Isparta", Date="15.05.2022", Time="18.00", Price=150},

            new Direction(){ DirectionId=2, Start="İstanbul", direction1="Bolu", direction2="Sakarya", direction3="Samsun", Finish="Trabzon", Date="16.05.2022", Time="18.00", Price=250},

            new Direction(){ DirectionId=3, Start="Artvin", direction1="Trabzon", direction2="Ordu", direction3="Samsun", Finish="Ankara", Date="15.05.2022", Time="18.00", Price=200},

            new Direction(){ DirectionId=4, Start="Trabzon", direction1="Samsun", direction2="Sakarya", direction3="Bolu", Finish="İstanbul", Date="17.05.2022", Time="18.00", Price=250},

            new Direction(){ DirectionId=5, Start="Isparta", direction1="Afyon", direction2="Kütahya", direction3="Kocaeli", Finish="İstanbul", Date="18.05.2022", Time="18.00", Price=150},

            new Direction(){ DirectionId=6, Start="Ankara", direction1="Samsun", direction2="Ordu", direction3="Trabzon", Finish="Artvin", Date="19.05.2022", Time="18.00", Price=200}
        };

        private static Ticket[] Tickets =
        {
            new Ticket(){TicketId=1, PassengerName="Ahmet", PassengerSurname="Metin,", PassengerMail="ahmetmetin@gmail.com",PassengerTel="05533656555", Departure="İstanbul", Arrival="Isparta", SeatNo=1, Price=150, DirectionId=1},

            new Ticket(){TicketId=2, PassengerName="Furkan", PassengerSurname="Kaya", PassengerMail="furkan@gmail.com",PassengerTel="05533656555", Departure="İstanbul", Arrival="Trabzon", SeatNo=2, Price=250, DirectionId=2},

            new Ticket(){TicketId=3, PassengerName="Lale", PassengerSurname="Kar", PassengerMail="lale@gmail.com",PassengerTel="05533656555",Departure="Artvin", Arrival="Ankara", SeatNo=3, Price=200, DirectionId=3},

            new Ticket(){TicketId=4, PassengerName="Osman", PassengerSurname="Lale", PassengerMail="osman@gmail.com",PassengerTel="05533656555", Departure="Trabzon", Arrival="İstanbul", SeatNo=4, Price=250, DirectionId=4},

            new Ticket(){TicketId=5, PassengerName="Şerif", PassengerSurname="Boz", PassengerMail="şerif@gmail.com",PassengerTel="05533656555",Departure="Isparta", Arrival="İstanbul", SeatNo=5, Price=150, DirectionId=5},

            new Ticket(){TicketId=6, PassengerName="Meltem", PassengerSurname="Derin", PassengerMail="derin@gmail.com",PassengerTel="05533656555", Departure="Ankara", Arrival="Artvin", SeatNo=6, Price=200, DirectionId=6},

            new Ticket(){TicketId=7, PassengerName="Ali", PassengerSurname="Metin", PassengerMail="metin@gmail.com",PassengerTel="05533656555", Departure="İstanbul", Arrival="Isparta", SeatNo=7, Price=150, DirectionId=1},

            new Ticket(){TicketId=8, PassengerName="Şule", PassengerSurname="Beyaz", PassengerMail="beyaz@gmail.com",PassengerTel="05533656555", Departure="İstanbul", Arrival="Trabzon", SeatNo=8, Price=250, DirectionId=2},

            new Ticket(){TicketId=9, PassengerName="Beyazit", PassengerSurname="Lale", PassengerMail="beyazit@gmail.com",PassengerTel="05533656555", Departure="Artvin", Arrival="Ankara", SeatNo=9, Price=200, DirectionId=3}

        };
        private static City[] Cities =
        {
            new City() { CityName = "İstanbul" },
            new City() { CityName = "Ankara" },
            new City() { CityName = "Kocaeli" },
            new City() { CityName = "Sakarya" },
            new City() { CityName = "Samsun" },
            new City() { CityName = "Trabzon" },
            new City() { CityName = "Ordu" },
            new City() { CityName = "Artvin" },
            new City() { CityName = "Bolu" },
            new City() { CityName = "Kütahya" },
            new City() { CityName = "Afyon" },
            new City() { CityName = "Isparta" }
        };
    }
}
