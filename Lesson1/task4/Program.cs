string? StrToStr(string[] strings)
{
    if (strings[0].Length > strings[1].Length) return string.Concat(strings[0], strings[1]);
    else if (strings[0] == strings[1]) return null;
    return String.Concat<string>(strings[1].Split(strings[0][0]));
}
string[] strings = {
    Console.ReadLine(),
    Console.ReadLine()
};
Console.WriteLine(StrToStr(strings));