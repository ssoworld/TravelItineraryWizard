using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelItineraryWizard
{
   class CarRentalHertz : ICarRentalAgency
   {
      public Dictionary<string, int> _cboxdata;

      public Dictionary<string, int> ComboBoxData => throw new NotImplementedException();

      public CarRentalHertz()
      {
         _cboxdata = new Dictionary<string,int>();
      }

      /// <summary>
      /// Car classes as defined by agency Hertz Car Rental
      /// </summary>
      public enum CarClasses
      {
         [Description(description: "Economy 2/4 Door (A)")]
         CarEconomy,
         [Description(description: "Compact 2/4 Door (B)")]
         CarCompact,
         [Description(description: "Intermediate 2/4 Door (C)")]
         CarIntermediate,
         [Description(description: "Standard 2/4 Door (D)")]
         CarStandard,
         [Description(description: "Standard Sport (D2)")]
         CarStandardSport,
         [Description(description: "Standard Elite 2/4 Door (P4)")]
         CarStandardElite,
         [Description(description: "Fullsize 2/4 Door (F)")]
         CarFullsize,
         [Description(description: "Premium 2/4 Door (G)")]
         CarPremium,
         [Description(description: "Luxury 2/4 Door (I)")]
         CarLuxury,
         [Description(description: "Luxury Sport (G4)")]
         CarLuxurySport,
         [Description(description: "Compact SUV (B4)")]
         SUVCompact,
         [Description(description: "Compact SUV GMMP (Y6)")]
         SUVCompactGMMP,
         [Description(description: "Intermediate SUV (Q4)")]
         SUVIntermediate,
         [Description(description: "Intermediate Elite SUV (H4)")]
         SUVIntermediateElite,
         [Description(description: "Standard SUV (L)")]
         SUVStandard,
         [Description(description: "Standard SUV GMMP (Y7)")]
         SUVStandardGMMP,
         [Description(description: "Standard Elite SUV (T4)")]
         SUVStandardElite,
         [Description(description: "Fullsize SUV (T)")]
         SUVFullsize,
         [Description(description: "Fullsize SUV GMMP (Y8)")]
         SUVFullsizeGMMP,
         [Description(description: "Fullsize SUV (V6)")]
         SUVPremium,
         [Description(description: "Luxury SUV (P6)")]
         SUVLuxuryP6,
         [Description(description: "Luxury SUV (S6)")]
         SUVLuxuryS6,
         [Description(description: "Standard Elite Crossover (Z4)")]
         SUVCrossoverStandardElite,
         [Description(description: "Mini Passenger Van (R)")]
         VanPassMini,
         [Description(description: "Fullsize Passenger Van (M)")]
         VanPassFullsize,
         [Description(description: "Standard Convertible (U)")]
         ConvertibleStandard,
         [Description(description: "Standard Convertible (U4)")]
         ConvertibleEliteStandard,
         [Description(description: "Intermediate Open Air All Terrain (V)")]
         AllTerrainIntermediate,
      }

      /// <summary>
      /// 
      /// </summary>
      public void LoadDictionary()
      {
         foreach(int enumValue in Enum.GetValues(typeof(CarClasses)))
         {
            _cboxdata.Add(Enum.GetName(typeof(CarClasses), enumValue), enumValue);
         }
      }
   }
}
