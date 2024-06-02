using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** Showing Marketing Messages ***\n\n");
        
        //Showing Lectures Messages
        Address address =new Address ("21 N Street #254", "Big city", "La Florida","USA");
        string title ="Modern History";
        string description ="Reading of most popular writers of modern history";
        string date ="25th september 2024";
        string time ="5:00pm";
        string speaker ="John Brown";
        int capacity = 55;
        Lectures lectures =new Lectures(title, description, date, time, address, capacity, speaker);
        lectures.GetStandard();
        lectures.GetFull();
        lectures.GetShort();

        //Showing  OUTDOOR Messages
        Address address2 =new Address ("calle 10 norte 156", "Renacimiento", "DF","MX");
        title ="Outdoor Fitness";
        description ="Zumba Strong classes with José Caballero";
        date ="30th January 2024";
        time ="5:00pm";
        string weather ="Rainy";
        Outdoor outdoor =new Outdoor(title, description, date, time, address2, weather);
        outdoor.GetStandard();
        outdoor.GetFull();
        outdoor.GetShort();

        //Showing RECEPTIONS Messages
        Address address3 =new Address ("Renacemento #23", "Ingleses", "Florianópolis","BRASIL");
        title ="Museum Night";
        description ="Ancestor's Life";
        date ="July,15";
        time ="3:00pm";
        string email ="receptions@hotmail.com";
        Receptions receptions =new Receptions(title, description, date, time, address3, email);
        receptions.GetStandard();
        receptions.GetFull();
        receptions.GetShort();
      
    }
}