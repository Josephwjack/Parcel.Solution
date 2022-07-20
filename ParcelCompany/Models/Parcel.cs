using System;
using System.Collections.Generic;

namespace ParcelCompany.Models
{
  public class Parcel
  {
    ///getters and setters
    private static List<Parcel> _list = new List<Parcel>(){};
    public string Description { get; set; }
    public int Width { get; set; }
    public int Length { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public bool International { get; set; }
    public int FinalCost { get; set; }
    public int Id { get; }

    // constructor
    public Parcel (string description, int width, int length, int height, int weight, bool international, int finalCost)
    {
      Description = description;
      Width = width;
      Length = length;
      Height = height;
      Weight = weight;
      International = international;
      FinalCost = finalCost;
      _list.Add(this);
      Id = _list.Count;

    }

    public static List<Parcel> GetAll()
    {
      return _list;
    }

    public static Parcel Find(int searchId)
    {
      return _list[searchId-1];
    }

    public double Volume()
    {
      int priceOne = 10;
      int priceTwo = 15;
      int priceThree = 30;
      int fuckOff = 1;


      if ((Width * Length) * Height <= 50)
      {
        return priceOne;
      }
      else if ((Width * Length) * Height <= 100)
      {
        return priceTwo;
      }
      else if ((Width * Length) * Height <= 150)
      {
        return priceThree;
      }
      else
      {
        return fuckOff;
      }
    }

    public double CostToShip()
    {
      double finalCost = 0;
      if(Volume() == 1)
      {
        finalCost = 100000000;
      }
      else if (International)
      {
      finalCost = 20 + Volume();
      }
      
      else 
      {
        finalCost = Volume();
      }
      return finalCost;
    }
  }
}