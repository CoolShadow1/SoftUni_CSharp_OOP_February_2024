﻿namespace _05._Birthday_Celebrations;

public class Pet : IBirthable
{
    public Pet(string name, string birthdate)
    {
        Name = name;
        Birthdate = birthdate;
    }

    public string Name { get; }
    public string Birthdate { get; }
}