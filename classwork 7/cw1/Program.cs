


List<string> frukti1 = new List<string>(){"apple", "banana", "orange"};
System.Console.WriteLine($"{frukti1.Count}");
foreach (var item in frukti1)
{
    System.Console.Write(item + " ");
}
System.Console.WriteLine();
frukti1.Remove("banana");
System.Console.WriteLine(frukti1.Contains("apple"));
frukti1.Clear();
List<string> frukti2 = new List<string>(){"apple", "banana", "orange"};
frukti2.Insert(0,"grape");
//10
bool cnt;
if(frukti2.Count>0){cnt=false;}
else {cnt=true;}
System.Console.WriteLine(cnt);
frukti2.Sort();
frukti2.Reverse();
foreach (var item in frukti2)
{
    System.Console.Write(item+ " " );
}
List<string> frukti3 = new List<string>();
frukti2.AddRange(frukti3);
//15
frukti3.RemoveAll(e=>e.Length>5);
//17frukti3.
