using System;

namespace MVCData.Models
{
    public class PersonViewModel
    {
        
            public static List<Person> listOfPeople = new List<Person>();

            public List<Person> tempList = new List<Person>();

            public Person person { get; set; }

            public static void GeneratePeople()
            {
                listOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name = "Jonathan Krall", Age = 34, PhoneNumber = "0737090202" });
                listOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name = "Ann Andersson", Age = 53, PhoneNumber = "45131511" });
                listOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name = "Sven Svensson", Age = 18, PhoneNumber = "8461231" });
            }
     }
 }

