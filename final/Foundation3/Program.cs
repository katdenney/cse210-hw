using System;
namespace EventsProject
{
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Foundation3 World!");
            Console.WriteLine("------------------------");

            List<Event> events = new List<Event>();
            //Lecture event1
            var event1 = new Lecture("Quantum Mechanics Unleashed","Dive into the mysterious world of quantum mechanics as we explore the bizarre behavior of particles and their implications for the future of technology.","12/03/2025","555 South Main Street","Salt Lake City","UT","USA","Dr. Evelyn Perez",2400);
            events.Add(event1);
           
            //event2
            Event event2 = new Lecture("Space Odyssey, Journey to the Stars","Embark on an astronomical adventure through our galaxy and beyond, unraveling the secrets of distant planets, black holes, and the vastness of the cosmos.","3/26/2025","789 Celestial Street", "Astralville", "StarZone","Mars","Professor Chen",1350);
            events.Add(event2);
            
            //Outdoor Gathering event 3
            Event event3 = new OutdoorGathering("Robinson Family Reunion","Join us for a memorable Robinson Family Reunion at Summitcrest Gardens in Serenity Springs.","6/3/2025","Mostly sunny skies with a light breeze");
            event3.SetNewAddress("345 Cherry Lane","Highland","UT","USA");
            events.Add(event3);
            
            //event 4
            Event event4 = new OutdoorGathering("Harmony in the Park","Join us for an unforgettable evening of music and fun at the Evergreen Park Pavilion!","8/24/2026","Mostly clear skies with a scattering of fluffy clouds.");
            event4.SetNewAddress("123 Pineview Terrace","Serenity Springs","CA","USA");
            events.Add(event4);
            
            //Receptions event 5
            Event event5 = new Reception("Garcia Wedding Reception","Join us for a joyous wedding reception in honor of the newlyweds, Mr. and Mrs. Garcia!","9/12/2016",350);
            event5.SetNewAddress("567 Lovebird Street","Rosewood","FL","USA");
            events.Add(event5);
            
            //event 6
            Event event6 = new Reception("Huang Wedding Reception","Join us for an enchanted wedding reception celebrating the union of Mr. and Mrs. Huang.","4/06/2026",200);
            event6.SetNewAddress("123 Blossom Lane","Jade Row","NY","USA");
            events.Add(event6);
            
            foreach(Event e in events)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"{e.GetType()}");
                Console.WriteLine(e.GetStandardDetails());
                Console.WriteLine(e.GetFullDetails());
                Console.WriteLine(e.GetShortDescription()); 
                Console.WriteLine();                               
            }
            
        }
    }
}