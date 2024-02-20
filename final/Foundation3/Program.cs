using System;
namespace EventsProject
{
class Program
    {
        static void Main(string[] args)
        {
            //Lectures
            Console.WriteLine("Hello Foundation3 World!");
            Event event1 = new Lecture("Quantum Mechanics Unleashed","Dive into the mysterious world of quantum mechanics as we explore the bizarre behavior of particles and their implications for the future of technology.","12/03/2025","555 South Main Street","Salt Lake City","UT","USA","Dr. Evelyn Perez",2400);
            Event event2 = new Lecture("Space Odyssey, Journey to the Stars","Embark on an astronomical adventure through our galaxy and beyond, unraveling the secrets of distant planets, black holes, and the vastness of the cosmos.","3/26/2025","789 Celestial Street", "Astralville", "StarZone","Mars","Professor Chen",1350);
            //event1
            Console.WriteLine(event1.GetStandardDetails());
            Console.WriteLine(event1.GetFullDetails());
            Console.WriteLine(event1.GetShortDescription());
            //event2
            Console.WriteLine(event2.GetStandardDetails());
            Console.WriteLine(event2.GetFullDetails());
            Console.WriteLine(event2.GetShortDescription());
            //Outdoor Gatherings
            Event event3 = new OutdoorGathering("Robinson Family Reunion","Join us for a memorable Robinson Family Reunion at Summitcrest Gardens in Serenity Springs.","6/3/2025","Mostly sunny skies with a light breeze");
            Event event4 = new OutdoorGathering("Harmony in the Park","Join us for an unforgettable evening of music and fun at the Evergreen Park Pavilion!","8/24/2026","Mostly clear skies with a scattering of fluffy clouds.");

            event3.SetNewAddress("345 Cherry Lane","Highland","UT","USA");
            Console.WriteLine(event3.GetStandardDetails());
            Console.WriteLine(event3.GetFullDetails());
            Console.WriteLine(event3.GetShortDescription());

            event4.SetNewAddress("123 Pineview Terrace","Serenity Springs","CA","USA");
            Console.WriteLine(event4.GetStandardDetails());
            Console.WriteLine(event4.GetFullDetails());
            Console.WriteLine(event4.GetShortDescription());
            //Receptions
            Event event5 = new Reception("Garcia Wedding Reception","Join us for a joyous wedding reception in honor of the newlyweds, Mr. and Mrs. Garcia!","9/12/2016",350);
            Event event6 = new Reception("Huang Wedding Reception","Join us for an enchanted wedding reception celebrating the union of Mr. and Mrs. Huang.","4/06/2026",200);
            event5.SetNewAddress("567 Lovebird Street","Rosewood","FL","USA");
            Console.WriteLine(event5.GetStandardDetails());
            Console.WriteLine(event5.GetFullDetails());
            Console.WriteLine(event5.GetShortDescription());
            event6.SetNewAddress("123 Blossom Lane","Jade Row","NY","USA");
            Console.WriteLine(event6.GetStandardDetails());
            Console.WriteLine(event6.GetFullDetails());
            Console.WriteLine(event6.GetShortDescription());
        }
    }
}