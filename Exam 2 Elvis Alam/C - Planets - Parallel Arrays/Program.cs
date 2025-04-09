using System.Globalization;

string[] planet = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
double[] radius = { 2440, 6052, 6371, 3390, 69911, 58232, 25362, 24622 };
double[] mass = { 0.33, 4.87, 5.97, 0.642, 1898, 568, 86.8, 102 };
double[] distance = { 0.39, 0.72, 1, 1.52, 5.2, 9.58, 19.18, 30.1 };
double[] moons = { 0, 0, 1, 2, 95, 146, 28, 16 };
double[] density = new double[mass.Length];
double[] volume = new double[mass.Length];


for (int i = planet.Length - 1; i >= 7; i--) {
        Console.WriteLine($"Last Planet: {planet[i]}, Number of Moons: {moons[i]}");
}

for (int i = 0; i < planet.Length; i++) {
        radius[i] *= 100000;
        mass[i] *= 10E27;
        volume[i] = (Math.PI) * (4 / 3) * (radius[i] * radius[i] * radius[i]);
        density[i] = mass[i] / volume[i];

        Console.WriteLine($"{planet[i]}: {density[i]} g/cc");
}

for (int i = 0; i < planet.Length; i++) {
        if (distance[i] == 1) {
                Console.WriteLine($"Planet at approximately 1 AU from the Sun: {planet[i]}");
        }
}

Console.WriteLine("Enter a planet name or mean distance (AU) ==> ");
string input = Console.ReadLine();
for (int i = 0; i < planet.Length; i++) {
        if (input == planet[i]) {
                Console.WriteLine($"Planet found by (a) Planet {planet[i]}, radius = {radius[i]} (cm), mass = {mass[i]}E+27 (g), distance = {distance[i]} (AU), moons = {moons[i]}.");
                Console.Write($"Planets with more (a) or same number (b) of moons: ");
        } 
        else {
        }
}


// int min = density[0];
// int max = density[0];
// int index_min = -1;
// int index_max = -1;

// for (int i = 0; i < density.Length; i++) {
//         if (density[i] < min) {
//               min = density[i];
//               index_min = i;  
//         }
//         if (density[i] > max) {
//                 max = density[i];
//                 index_max = i;
//         }
// }

// Console.WriteLine($"a) Least Dense: {planet[index_min]}  b) Densest: {planet[index_max]}  c) Second densest: {planet[index_max - 1]}");



