using CustomListTask;

List<int> arr = new();
arr.Add(1);
arr.Add(2);
arr.Add(3);
arr.Add(4);
arr.Add(5);

arr.Clear();
Console.WriteLine(arr.Capacity);
Console.WriteLine(arr.Count);

CustomList<string> arr1 = new();
Console.WriteLine(arr1.Capacity);
Console.WriteLine(arr1.Count);