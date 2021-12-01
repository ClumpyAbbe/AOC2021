


List<int> input = new List<int>();
bool isint = true;
int value = 0;
while (isint)
{
    isint = Int32.TryParse(Console.ReadLine(), out value);
    input.Add(value);
}

onestar(input);
twostar_alt(input);
twostar(input);


void onestar(List<int> input)
{
    int count = 0;
    for (int i = 0; i < input.Count-1; i++)
    {
        if(input[i] < input[i+1])
        {
            count++;
        }
    }
    Console.WriteLine(count);
}

void twostar(List<int> input)
{
    int matches = 0;
    int newvalue = 0;
    int oldvalue = 0;
    while (input.Count > 4)
    {
        for (int i = 0; i < 3; i++)
        {
            newvalue += input[i];
        }
        if (newvalue > oldvalue)
        {
            matches++;
        }
        oldvalue = newvalue;
        newvalue = 0;
        input.Remove(input[0]);
    }
    Console.WriteLine(matches);
}

void twostar_alt(List<int> input) //För att den förra var ful som stryk...
{
    int matches = 0;
    for (int i = 0; i < input.Count; i++)
    {
        var oldset = input.Skip(i - 3).Take(3);
        var newset = input.Skip(i - 2).Take(3);
        if (oldset.Sum() < newset.Sum())
        {
            matches++;
        }
    }
    Console.WriteLine(matches);
}