List<int> people = new List<int>();

Console.WriteLine("Enter 10 values: ");
for (int i = 0; i < 10; i++)
{
    Console.Write(i + " - ");
    people.Add(Convert.ToInt32(Console.ReadLine()));
}

Console.Write("Enter dublicate value: ");
int value = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < people.Count; i++)
{
    Console.WriteLine(people[i]);
    if (people[i] == value)
    {
        people.Insert(i++, 3);
        Console.WriteLine(people[i]);
    }
}