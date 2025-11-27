// Challenge 1: Multiples List Generator

// Console.Write("Enter a number: ");
// string input = Console.ReadLine();
// int number = int.Parse(input);
// Console.Write("Enter a length: ");
// string input2 = Console.ReadLine();
// int length = int.Parse(input2);
// for (int i = 1; i <= length; i++)
// {
//     int result = i*number;
//     Console.WriteLine(number + "x" + i + " = " + result);
// }


// Challenge 2: Remove Consecutive Duplicate Letters

Console.Write("Entre une chaîne : ");
        string input = Console.ReadLine();

        string result = "";
        
        for (int i = 0; i < input.Length; i++)
        {
            // Si c'est le premier caractère OU si le caractère est différent du précédent
            if (i == 0 || input[i] != input[i - 1])
            {
                result += input[i];
            }
        }

        Console.WriteLine("Résultat : " + result);



