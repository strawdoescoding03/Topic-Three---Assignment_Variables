namespace Topic_Three___Assignment_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sarah T

            // 1)

            string course_name, name, attitude, job;
            double homeland_apple_price, current_apple_price, orange_pant_price;
            int comp_sci_room_number, max_potato;


            //String variables 
            course_name = "Computer Science";
            name = "Sarah the Sasquatch";
            attitude = "Grumpy bum";
            job = "school enthusiast";


            //Double variables           
            homeland_apple_price = 2.99;
            current_apple_price = 8.97;
            orange_pant_price = 213.98;


            //Int Variables
            comp_sci_room_number = 29;
            max_potato = 1898899834; // REAL NUMBER :)

            Console.WriteLine("Good Morning!");
            Console.WriteLine("My name is " + name + ", and I'm feeling like a " + attitude + " today.");
            Console.WriteLine("Currently, I am taking " + course_name + " in room " + comp_sci_room_number + ".");
            Console.WriteLine("One could say I'm a bit of a " + job + ".");
            Console.WriteLine();
            Console.WriteLine("Now that you know about me, let me tell you some fun facts about me!");
            Console.WriteLine("In my home land, the price of apples was only " + homeland_apple_price.ToString("C") + " but here it's crazy!");
            Console.WriteLine("Like who wants to spend " + current_apple_price.ToString("C") + "? Yikes");
            Console.WriteLine("Due to my incredible body, I have to buy custom orange pants, which are unfortunalty " + orange_pant_price.ToString("C") + ":(");
            Console.WriteLine("It's not all bad though because I can fit " + max_potato + " potatoes in my mouth at the same time!");

            Console.WriteLine();
            Console.WriteLine();

            // 2)

            string first_name, last_name;
            int birth_year, grad_age,
                full_years_left,
                current_year,
                age;


            first_name = "Sarah";
            last_name = "Tiffany";

            birth_year = 2008;
            current_year = 2025;
            grad_age = 18;
            age = current_year - birth_year;
            full_years_left = grad_age - age;

            Console.WriteLine("Hello again! I am no longer a Sasquatch! (The curse is gone! Yipeee!)");
            Console.WriteLine("Allow me to properly intoduce myself! I am " + first_name + " " + last_name);
            Console.WriteLine("and I'll graduate in the year " + (birth_year + grad_age) + "!");

            Console.WriteLine("I have " + full_years_left + " full school years left!");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Here are some cool math problems for you!");
            Console.WriteLine();
            // 3) Area of A Circle with a variable radius!

            double radius_circle_one,
                radius_circle_two,
                area_circle_one,
                area_circle_two;

            radius_circle_one = 10.0;
            area_circle_one = (2.0 * Math.PI * radius_circle_one);           
            radius_circle_two = 25.0;
            area_circle_two = (2.0 * Math.PI * radius_circle_two);

            Console.WriteLine("1) What is the area of the circle if it has a radius of 10 cm?");
            Console.WriteLine("The area of the circle is " + Math.Round(area_circle_one, 1, MidpointRounding.AwayFromZero) + " cm^2");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("2) What is the area of the circle if it has a radius of 25 cm?");
            Console.WriteLine("The area of the circle is " + Math.Round(area_circle_two, 1, MidpointRounding.AwayFromZero) + " cm^2");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("3) What is the combined area of the two circles?");
            Console.WriteLine("The combined area of the circles are " + Math.Round(area_circle_one + area_circle_two, 1, MidpointRounding.AwayFromZero) + "cm^2");
            Console.WriteLine();
            Console.WriteLine();
            //4 Own formula (Speed Calculations   (distance over time)


            double car_distance_metres,
                car_distance_km,
                drive_time_seconds,
                drive_time_hours;

            car_distance_metres = 33.15;
            car_distance_km = car_distance_metres / 1000.00;


            drive_time_seconds = 1.00;
            drive_time_hours = drive_time_seconds * 3600.00;

            Console.WriteLine("4) If a car is traveling at 33.15 m/s, how fast is the car travelling in km/h?");
            Console.WriteLine("Therefore, the speed of the car is " + Math.Round(car_distance_km * drive_time_hours, 2, MidpointRounding.AwayFromZero) + " km/h");

            Console.WriteLine();
            

            Console.ReadLine();

        }
    }
}
