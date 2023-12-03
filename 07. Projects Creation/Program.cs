string name = Console.ReadLine();
double projects = double.Parse(Console.ReadLine()); 
double time = 3 *  projects;
Console.WriteLine($"The architect {name} will need {time} hours to complete {projects} project/s.");