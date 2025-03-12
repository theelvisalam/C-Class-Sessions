int unitOfMeasurement;
double weightPound;
double heightFeet;
// double heightInch = heightFeet * 12;
double heightInch;
// double weightKilo = weightPounds * 0.453592;
double weightKilograms;
// double heightCentimeter = heightFeet * 30.48;
double heightCentimeter;
double heightMeters;
double BMI;

Console.WriteLine("Enter 1 for 'Imperial' or Enter 2 for 'Metric");
unitOfMeasurement = int.Parse(Console.ReadLine());

if (unitOfMeasurement == 1)
{
    Console.WriteLine("Enter Weight in Pounds");
    weightPound = double.Parse(Console.ReadLine());

    Console.WriteLine("Enter Height in Feet");
    heightFeet = double.Parse(Console.ReadLine());

    Console.WriteLine("Enter Height in Inches");
    heightInch = double.Parse(Console.ReadLine());

    weightKilograms = weightPound / 2.20462;

    heightMeters = 0.0254 * (12 * heightFeet + heightInch);


}
else if (unitOfMeasurement == 2)
{

    Console.WriteLine("Enter Weight in Kilograms");
    weightKilograms = double.Parse(Console.ReadLine());

    Console.WriteLine("Enter Height in Centimeters");
    heightCentimeter = double.Parse(Console.ReadLine());

    heightMeters = 0.01 * heightCentimeter;
}
else
{
    Console.Error.WriteLine("Invalid input");
    return;
}

BMI = weightKilograms / (heightMeters * heightMeters);

if (BMI < 18.5)
{
    Console.WriteLine("Underweight");
}
else if (BMI < 24.999 && BMI > 18.5)
{
    Console.WriteLine("Normal Weight");
}
else if (BMI < 29.999 && BMI > 25)
{
    Console.WriteLine("Overweight");
}
else if (BMI >= 30)
{
    Console.WriteLine("Obese");
}
//  NEED TO PUT INSIDE IF STATEMENTS
// weightKilograms = weightPound / 2.20462; done
// heightMeters = 0.0254 * (12 * heightFeet + heightInch); done
// BMI = weightKilometers / (heightMeters * heightMeters);
