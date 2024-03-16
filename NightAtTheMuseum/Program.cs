char start = (char)97;
int sum = 0;
string str = Console.ReadLine();
for (int i = 0; i < str.Length; i++)
{

    int helper = Math.Abs(str[i] - start);
    int mn = Math.Min(helper, 26 - helper);
    sum += mn;
    start = (char)str[i];
}
Console.WriteLine(sum);
