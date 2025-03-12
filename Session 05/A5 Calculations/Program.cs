// GRAVITATIONAL CONSTANT
const double G = 6.6743E-11;

double mass_earth = 5.9722E24;
double mass_moon = 7.3477E22;
double radius = 384.4E6;

double force = G * mass_earth * mass_moon / (radius * radius);

Console.WriteLine("The gravitational force between the earth and the moon is {force} Newtons.");
