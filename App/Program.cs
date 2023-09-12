// See https://aka.ms/new-console-template for more information
Console.WriteLine("Let us Display List of Month");
List<string> listMonth=new List<string>
{
    "Jan","Feb","Mar","April","May","June","July","Aug","Sep","Oct","Nov","Dec"
};

foreach(var month in listMonth)
{
    Console.WriteLine(month);
    Thread.Sleep(2000);
}