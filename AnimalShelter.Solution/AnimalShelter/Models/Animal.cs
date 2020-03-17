using System;
using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public DateTime DateAdmitted { get; set; }
    public AnimalType AnimalType { get; set; }
    public string Breed { get; set; }
  }

  public enum AnimalType
  {
    Cat,
    Dog,
    Critter,
    Other    
  }
}