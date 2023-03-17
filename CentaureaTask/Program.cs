char[] firstCharsArray = { 'a', 't', 'm', 'h', 'z', 'g', 't', 'z', 'e', 'f' };

char[] secondCharsArray = { 'b', 'q', 'a', 'c', 'h', 'q', 't', '2', 'm', 'z' };

//If I remember correctly, arrays have the same count of elements and that was part of the task
void LogIfArraysHaveSameElements(char[] firstArray, char[] secondArray)
{
    //Here we try to find the biggest char from two arrays
    var maxVal = firstArray[0];

    for (var i = 1; i < firstArray.Length; i++)
        if (firstArray[i] >= secondArray[i] && firstArray[i] > maxVal)
            maxVal = firstArray[i];
        else if (firstArray[i] < secondArray[i] && secondArray[i] > maxVal)
            maxVal = secondArray[i];

    //We create a new array, the size of which will be equal to the maximum element from the arrays
    var occurrences = new int[maxVal + 1];

    foreach (var c in firstArray)
        occurrences[c]++;

    //Here we check if the element was added from the previous array
    foreach (var c in secondArray)
        if (occurrences[c] != 0)
            Console.WriteLine($"They both contain {c}");
}

//This algorithm will have linear growth and complexity of O(3n)
LogIfArraysHaveSameElements(firstCharsArray, secondCharsArray);