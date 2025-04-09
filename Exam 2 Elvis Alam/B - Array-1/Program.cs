int[] array1 = new int[10];
int[] array2 = new int[5];
int input;
int count = 0;
int posCount = 0;
int sum = 0;
int posSum = 0;
int neighborElement = 0;
int array2Count = 0;
double avg;
double posAvg;
bool firstTwice = false;



for (int i = 0; i < array1.Length; i++) {
    Console.WriteLine("Enter 10 integers to store into array1[]");
    input = int.Parse(Console.ReadLine());
    sum += input;
    count++;
    array1[i] = input;
}

if (count > 0) {
    avg = (double)sum / count;
    Console.WriteLine($"Average of all values in array1: {avg}");
} 
else {
    Console.WriteLine("ERROR");
}

for (int i = 0; i < array1.Length; i++) {
    if (array1[i] > 0) {
        posSum += array1[i];
        posCount++;
    }
}

if (posCount > 0) {
    posAvg = (double)posSum / posCount;
    Console.WriteLine($"Average of all positive values in array1: {posAvg}");
} 
else {
    Console.WriteLine("ERROR");
}

for (int i = 1; i < array1.Length; i++) {
    for (int j = i + 1; j < array1.Length - 1; j++) {
        if (array1[0] == array1[i] && array1[0] == array1[j]) {
            firstTwice = true;
        }
    }
}

Console.WriteLine($"First element appears at least twice: {firstTwice}");


for (int i = 0; i < array1.Length - 1; i++) {
    if (array1[i] == array1[i + 1]) {
        neighborElement++;
    }
}

Console.WriteLine($"Number of times neighboring elements are the same: {neighborElement}");

for (int i = array1.Length - 1; i >= 0; i--) {
    if (array1[i] > 0) {
        array2[array2Count] = array1[i];
        array2Count++;
        if (array2Count == 5) {
            break;
        }
    }
}

for (int i = 0; i < array2.Length; i++) {
    Console.WriteLine($"Final array2: [{array2[4]}, {array2[3]}, {array2[2]}, {array2[1]}, {array2[0]}]");
}

for (int i = 0; i < array2.Length; i++) {
    array1[i] += array2[i];
}

for (int i = 0; i < array1.Length; i++) {
    Console.WriteLine($"array1 after incrementing (8): [{array1[0]}, {array1[1]}, {array1[2]}, {array1[3]}, {array1[4]}, {array1[5]}, {array1[6]}, {array1[7]}, {array1[8]}, {array1[9]}]");
}
