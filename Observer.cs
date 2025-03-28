using System;
using System.Collections.Generic;

public class Schedule
{
    private List<IObserver> observers = new List<IObserver>();
    public string ScheduleData { get; private set; }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    
    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(ScheduleData);
        }
    }

   
    public void SetSchedule(string schedule)
    {
        ScheduleData = schedule;
        NotifyObservers();
    }
}

public interface IObserver
{
    void Update(string scheduleData); 
}

public class Person : IObserver
{
    public string Name { get; }

    public Person(string name)
    {
        Name = name;
    }

    //   notifiering
    public void Update(string scheduleData)
    {
        Console.WriteLine($"{Name} har fått en notifiering om schemaändring: {scheduleData}");
    }
}

public class Program
{
    public static void Main()
    {
        var schedule = new Schedule();

        // Skapa observer 
        var staffMember = new Person("John");
        var client = new Person("Jane");

        // Registrera 
        schedule.RegisterObserver(staffMember);
        schedule.RegisterObserver(client);

        // Ändra schema 
        schedule.SetSchedule("Nytt schema för John: 15:00 - 17:00");
    }
}
