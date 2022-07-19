using System;

namespace ParcelCompany.Models
{
  public class Parcel
  {
    ///getters and setters
    public int Width { get; set; }
    public int Length { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public bool International { get; set; }
    public int FinalCost { get; set; }


    // constructor
    public Parcel (int width, int length, int height, int weight, bool international)
    {
      Width = width;
      Length = length;
      Height = height;
      Weight = weight;
      International = international;

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