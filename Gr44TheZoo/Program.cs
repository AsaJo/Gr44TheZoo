using Gr44TheZoo.Models;

namespace Gr44TheZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zebra zebra = new Zebra("White", "Black", "Marcus", 499, 1000, WeightUnit.Kg, HeightUnit.mm);
               
            //zebra.Name = "Marcus";
            //zebra.Weight = 499;
            //zebra.Height = 1000;
            //zebra.WeightUnit = WeightUnit.Kg;
            //zebra.HeightUnit = HeightUnit.mm;

            //Console.WriteLine(zebra.Info());
            //Console.WriteLine(zebra.MakeNoise());


            Elephant elephant = new Elephant(2, "Dumboo", 2, 3, WeightUnit.Tons, HeightUnit.meter);

            //Console.WriteLine(elephant.Info());
            //Console.WriteLine(elephant.MakeNoise());
            Crocodile crocodile = new Crocodile("Big and lots of teeth", "Schnappie", 1, 6, WeightUnit.Tons, HeightUnit.meter);
            Bat bat = new Bat("Bertil", 2, 15, WeightUnit.Grams, HeightUnit.cm);

            Animal[] zooAnimals = new Animal[] { zebra, elephant, crocodile, bat };
            List<IDanger> dangerZone = new List<IDanger>();
            foreach (Animal animal in zooAnimals)
            {
                //Console.WriteLine(animal.Info());
                //if (animal is Zebra)
                //{
                //    Console.WriteLine((animal as Zebra).Info());
                //}
                //else if (animal is Elephant) 
                //{
                //    Console.WriteLine((animal as Elephant).Info());
                //}
                //else if (animal is Crocodile)
                //{
                //    Console.WriteLine((animal as Crocodile).Info());
                //}
                //else if (animal is Bat)
                //{
                //    Console.WriteLine((animal as Bat).Info());
                //}
                //else { Console.WriteLine(animal.Info()); }

                if (animal is IDanger)// 
                {
                    dangerZone.Add((animal as IDanger));
                }
                Console.WriteLine("Danger Zone of the Zoo");
            }
            Console.WriteLine("\nDanger Zone of the Zoo\n");//28  Standard like USB or Powerpluggs
            dangerZone.Add(new Saw());//28
            foreach (IDanger danger in dangerZone)// 27
            {
                Console.WriteLine(danger.GetType().Name);// 29 Organisera DRY// securety/ abstract class will work
                foreach (var item in danger.DangerType())
                {
                    Console.WriteLine(item.Key + " " + item.Value);// 27
                }
            }
        }
    } }