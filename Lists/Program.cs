

List<string> firstName = new List<string>();

firstName.Add("Tim");
firstName.Add("Sue");
firstName.Add("Bob");
firstName.Add("Jane");

Console.WriteLine(firstName[firstName.Count - 1]);

List<int> age = new List<int>();
age.Add(1);
age.Add(2);
age.Add(3);

string data = "Smith, Jones, Lee";
List<string> lastName = data.Split(',').ToList();

lastName.Add("Koo");