

List<int> number = new List<int>(){1,2,3,4,5};
List<int> num =new List<int>(){6,7,8,9,10};
number.AddRange(num);
foreach (var item in number)
{
    System.Console.WriteLine(item);
}

