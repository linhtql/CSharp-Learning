var datetime = new DateTime(2023, 1, 1);
var now = DateTime.Now;
var today = DateTime.Today;

Console.WriteLine(datetime); // 12-0-0 1/1/2023
Console.WriteLine(now);
Console.WriteLine(today); // chi hien thi ngay, con gio la 12:00

var tomorrow = now.AddDays(-1);
var yesterday = now.AddDays(1);

Console.WriteLine("---------");
Console.WriteLine(now.ToLongDateString());
Console.WriteLine(now.ToShortDateString());
Console.WriteLine(now.ToLongTimeString());
Console.WriteLine(now.ToShortTimeString());
Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

Console.WriteLine("-----TimeSpan-----");
var timeSpan = new TimeSpan(1, 2, 3);
Console.WriteLine(timeSpan);

var timeSpan1 = new TimeSpan(1, 0, 0);
var timeSpan2 = TimeSpan.FromHours(1);
Console.WriteLine(timeSpan2);

var start = DateTime.Now;
var end = DateTime.Now.AddMinutes(2);
var duration = end - start;
Console.WriteLine("Duration: " + duration);

// Properties
Console.WriteLine("Minutes: " + timeSpan.Minutes);
Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

// Add
Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
Console.WriteLine("Substract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

// ToString
Console.WriteLine("ToString " + timeSpan.ToString());

// Parse
Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
