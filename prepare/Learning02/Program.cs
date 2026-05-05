using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job aaojob = new Job();
        aaojob._aaoCompanyTitle = "BYU-I";
        aaojob._aaoJobTitle = "Communications Specialist";
        aaojob._aaoStartYear = 2025;
        aaojob._aaoEndYear = 2026;

        Job aaojob1 = new Job();
        aaojob1._aaoCompanyTitle = "TechNova Solutions";
        aaojob1._aaoJobTitle = "Software Engineering Intern";
        aaojob1._aaoStartYear = 2024;
        aaojob1._aaoEndYear = 2025;

        Resume aaoResume = new Resume();
        aaoResume._aaoName = "Aba Otchere";

        aaoResume._aaoJobList.Add(aaojob);
        aaoResume._aaoJobList.Add(aaojob1);
        aaoResume.Display();
    }
}