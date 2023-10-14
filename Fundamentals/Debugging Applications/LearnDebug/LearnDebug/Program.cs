using System.Collections.Generic;

List<int> numbers = new List<int>{ 1, 2, 3, 4, 5, 6 };
List<int> smallests = GetSmallests(numbers, 3);

foreach(int number in smallests)
{
    Console.WriteLine(number);
}

static List<int> GetSmallests(List<int> list, int count)
{
    List<int> buffer = new List<int>(list);
    List<int> smallests = new List<int>();

    while(smallests.Count < count)
    {
        int min = GetSmallest(buffer);
        smallests.Add(min);
        buffer.Remove(min);
    }

    return smallests;
}

static int GetSmallest(List<int> list)
{
    int min = list[0];

    foreach(int number in list)
    {
        if (number > min)
        {
            min = number;
        }
    }
    return min;
}