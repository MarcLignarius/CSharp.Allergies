using System;
using System.Collections.Generic;

namespace Allergies.Models
{
  public class AllergyScores
  {
    private bool Eggs;
    private bool Peanuts;
    private bool Shellfish;
    private bool Strawberries;
    private bool Tomatoes;
    private bool Chocolate;
    private bool Pollen;
    private bool Cats;

    public AllergyScores(int score)
    {
      Eggs = false;
      Peanuts = false;
      Shellfish = false;
      Strawberries = false;
      Tomatoes = false;
      Chocolate = false;
      Pollen = false;
      Cats = false;
      if(score>= 128)
      {
        Cats=true;
        score -= 128;
      }
      if(score>= 64)
      {
        Pollen=true;
        score -= 64 ;
      }
      if(score>= 32)
      {
        Chocolate=true;
        score -= 32 ;
      }
      // if(score>= 16)
      // {
      //   Tomatoes=true;
      //   score -= 16 ;
      // }
      // if(score>= 8)
      // {
      //   Strawberries=true;
      //   score -= 8 ;
      // }
      // if(score>= 4)
      // {
      //   Shellfish=true;
      //   score -= 4 ;
      // }
      // if(score>= 2)
      // {
      //   Peanuts=true;
      //   score -= 2 ;
      // }
      // if(score>= 1)
      // {
      //   Eggs=true;
      //   score -= 1 ;
      // }
    }

    public bool GetCats()
    {
      return Cats;
    }

    public bool GetPollen()
    {
      return Pollen;
    }

    public bool GetChocolate()
    {
      return Chocolate;
    }

    public bool GetTomatoes()
    {
      return Tomatoes;
    }

  }
}


//
// public bool GetStrawberries()
// {
//   return Strawberries;
// }
//
// public bool GetShellfish()
// {
//   return Shellfish;
// }
//
// public bool GetPeanuts()
// {
//   return Peanuts;
// }
//
// public bool GetEggs()
// {
//   return Eggs;
// }
