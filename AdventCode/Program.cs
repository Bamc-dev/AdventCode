// See https://aka.ms/new-console-template for more information
using AdventCode;
using AdventCode.Class;

TxtReader inputDayOne = new("D:\\C#\\AdventCode\\AdventCode\\Inputs\\InputDay1.txt");

Console.WriteLine("\n-------------------Day One-------------------\n");

List<Elfes> elfes = new List<Elfes>();
List<string> inputDayOneList = inputDayOne.ReturnInput();
int nbrElfes = 0;
for (int i = 0; i < inputDayOneList.Count-1; i++)
{
    
    //Console.WriteLine("NbrElfes a chaque boucle : "+nbrElfes);

    if (i == 0)
    {
        elfes.Add(new Elfes());
    }
    else
    {
        if (!(inputDayOneList[i].Length == 0))
        {
            elfes[nbrElfes].AjouterCalories(Convert.ToInt32(inputDayOneList[i]));
        }
        else 
        {
            nbrElfes += 1;
            elfes.Add(new Elfes());
        }
    }
}

List<Elfes> SortedList = elfes.OrderByDescending(elfe => elfe.RecupererTotalCalories()).ToList();

Console.WriteLine(SortedList[0].RecupererTotalCalories());


