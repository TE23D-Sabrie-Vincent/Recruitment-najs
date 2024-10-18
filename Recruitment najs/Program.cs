// // See https://aka.ms/new-console-template for more information
// // 

// List<string> names = ["Vinny", "Vincent", "Theodor (usch)"];
// names[1] = "Teddy";

// names.Add("Ludvig");
// //använd Add i recruitmen
// names.Add("Simon");
// names.Add("Kevin");

// names.Remove("Theodor (usch)");
// names.RemoveAt(1);
// if (names.Contains("Ludvig") == true)
// {
//     System.Console.WriteLine("Yes, det finns i listan");
// }

// System.Console.WriteLine(string.Join("\n", names));


// // for (int i=0; i < names.Count; i++)
// // {
// // System.Console.WriteLine(names[i]);
// // }




// // string name = Console.ReadLine();
// // if (name == names[1])
// // {
// //     System.Console.WriteLine("Hej dumass");
// // }
// // System.Console.WriteLine(names[1]);

using System.Diagnostics;

List<string> somebois = ["Theodor sked", "Simon ligma", "Greta Grötberg", "Konstantin den lilla", "Lester mod", "Batman", "Patrick Bateman"];

List<string> currentbois = [];

while (currentbois.Count < 4)
{

    System.Console.WriteLine(">>>Alla dina fina Recruits<<<");
    for (int i = 0; i < somebois.Count; i++)
    {
        System.Console.WriteLine($"{i + 1} {somebois[i]}");
    }

    Console.WriteLine("\n-- Current recruits --");
    for (int i = 0; i < currentbois.Count; i++)
    {
        Console.WriteLine($"{currentbois[i]}");
    }

    string BoiNum = Console.ReadLine();
    int BoiChoice;


    // int.TryParse()

    if (int.TryParse(BoiNum, out BoiChoice))
    {
        

        if (BoiChoice > 7 || BoiChoice <= 1)
        {
            System.Console.WriteLine($"Bra val! du tog {somebois[BoiChoice - 1]}! ");
        }
    }

    else
    {
        System.Console.WriteLine("ajabaja");
    }

    Console.ReadLine();
}

