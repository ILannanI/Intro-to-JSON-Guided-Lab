﻿public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; } 
    public bool IsStudent { get; set; }

    public Person(string name, int age, string email, bool isStudent)
    {
        Name = name;
        Age = age;
        Email = email;
        IsStudent = isStudent;
    }
}

