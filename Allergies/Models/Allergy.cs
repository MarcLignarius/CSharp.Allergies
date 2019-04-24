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
    }

    // public ChangeMake(int money)
    // {
    //   Quarters = 0;
    //   Dimes = 0;
    //   Nickels = 0;
    //   Pennies = 0;
    //   while(money >= 25)
    //   {
    //     money -= 25;
    //     Quarters++;
    //   }
    //   while(money >=10)
    //   {
    //     money -= 10;
    //     Dimes++;
    //   }
    //   while(money >=5)
    //   {
    //     money -= 5;
    //     Nickels++;
    //   }
    //   while(money >=1)
    //   {
    //     money -= 1;
    //     Pennies++;
    //   }
    // }
    //
    public bool GetCats()
    {
      return Cats;
    }
    //
    // public int GetDimes()
    // {
    //   return Dimes;
    // }
    //
    // public int GetNickels()
    // {
    //   return Nickels;
    // }
    //
    // public int GetPennies()
    // {
    //   return Pennies;
    // }
    //
    // public string GiveChange()
    // {
    //   return "Quarters: " + Quarters + ", Dimes: " + Dimes + ", Nickels: " + Nickels + ", Pennies: " + Pennies;
    // }

  }
}
