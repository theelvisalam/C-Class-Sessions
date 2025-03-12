// yesNo variable is also known as a loop-control variable
String yesNo = "";
// while (!(yesNo == "N" || yesNo == "n")) // these conditions are the same
while (yesNo != "N" && yesNo != "n")
{
    Console.WriteLine("Do you want to continue with the iteration?");
    yesNo = Console.ReadLine();
}
