// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// #error version
// #region Raw interpolated string literals
// var person = new { FirstName = "Alice", Age = 56};

// string json = $$"""
//                 {
//                     "first_name":"{{person.FirstName}}",
//                     "age": {{person.Age}},
//                     "calculation", "{{{ 1 + 2}}}"
//                 }
//                 """;
// Console.WriteLine(json);
// #endregion Raw interpolated string literals

// return;

#region Comparing double and decimal types
Console.WriteLine("Using doubles:");
double a = 0.1;
double b = 0.2;

if (a + b == 0.3){
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else {
    Console.WriteLine($"{a} + {b} does not equal {0.3}");
}

Console.WriteLine("Using decimals:");
decimal a_dec = 0.1M;
decimal b_dec = 0.2M;

if (a_dec + b_dec == 0.3M){
    Console.WriteLine($"{a_dec} + {b_dec} equals {0.3}");
}
else {
    Console.WriteLine($"{a_dec} + {b_dec} does not equal {0.3}");
}
#endregion Comparing double and decimal types