List<int> nums = new List<int>();

Console.WriteLine("Enter 10 values: ");
for (int i = 0; i < 10; i++)
{
    Console.Write(i + " - ");
    nums.Add(Convert.ToInt32(Console.ReadLine()));
}

Console.Write("Enter dublicate value: ");
int value = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < nums.Count; i++)
{
    Console.WriteLine(nums[i]);
    if (nums[i] == value)
    {
        nums.Insert(i++, value);
        Console.WriteLine(nums[i]);
    }
}