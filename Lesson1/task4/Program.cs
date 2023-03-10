string StrToStr(string string1, string string2)
{
    if (string1.Length > string2.Length)
    {
        return string.Concat(string1, string2);
    }
    if (string1 == string2)
    {
        return null;
    }
    return string2.Replace(string1[0].ToString(), "");
    // equal to: String.Concat<string>(strings[1].Split(strings[0][0]));
}
string string1 = Console.ReadLine();
string string2 = Console.ReadLine();

Console.WriteLine(StrToStr(string1, string2));