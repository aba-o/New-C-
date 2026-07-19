using System;
using System.Collections.Generic;
using System.IO;

public class FileManager
{
    private string _aaoFileName;

    public FileManager(string fileName)
    {
        _aaoFileName = fileName;
    }

    public void SaveToFile(List<Activity> activities)
    {
        using (StreamWriter outputFile = new StreamWriter(_aaoFileName))
        {
            foreach (Activity activity in activities)
            {
                if (activity is Running _aaoRunning)
                {
                    outputFile.WriteLine(
                        $"Running|{_aaoRunning.GetDate()}|{_aaoRunning.GetMinutes()}|{_aaoRunning.GetDistance()}");
                }
                else if (activity is Cycling cycling_aao)
                {
                    outputFile.WriteLine(
                        $"Cycling|{cycling_aao.GetDate()}|{cycling_aao.GetMinutes()}|{cycling_aao.GetSpeed()}");
                }
                else if (activity is Swimming swimming_aao)
                {
                    double laps_aao = swimming_aao.GetDistance() * 1000 / 50;

                    outputFile.WriteLine(
                        $"Swimming|{swimming_aao.GetDate()}|{swimming_aao.GetMinutes()}|{(int)laps_aao}");
                }
            }
        }
    }

    public List<Activity> LoadFromFile()
    {
        List<Activity> activities_aao = new List<Activity>();

        if (!File.Exists(_aaoFileName))
        {
            return activities_aao;
        }

        string[] lines_aao = File.ReadAllLines(_aaoFileName);

        foreach (string line_aao in lines_aao)
        {
            string[] parts_aao = line_aao.Split('|');

            string type_aao = parts_aao[0];
            string date_aao = parts_aao[1];
            int minutes_aao = int.Parse(parts_aao[2]);

            switch (type_aao)
            {
                case "Running":
                    double distance_aao = double.Parse(parts_aao[3]);

                    activities_aao.Add(
                        new Running(date_aao, minutes_aao, distance_aao));
                    break;

                case "Cycling":
                    double speed_aao = double.Parse(parts_aao[3]);

                    activities_aao.Add(
                        new Cycling(date_aao, minutes_aao, speed_aao));
                    break;

                case "Swimming":
                    int laps_aao = int.Parse(parts_aao[3]);

                    activities_aao.Add(
                        new Swimming(date_aao, minutes_aao, laps_aao));
                    break;
            }
        }

        return activities_aao;
    }
}