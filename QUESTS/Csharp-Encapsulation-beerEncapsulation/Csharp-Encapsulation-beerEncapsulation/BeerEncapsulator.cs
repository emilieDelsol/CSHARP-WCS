using System;

namespace Csharp_Encapsulation_beerEncapsulation
{
    partial class Program
    {
        public class BeerEncapsulator
        {

            private double _avalaibleBeerVolume = 0;
            private int _avalaibleBottles = 0;
            private int _avalaibleCapsules = 0;
            public double GetAvalaibleBeerVolume()
            {
                return _avalaibleBeerVolume;
            }
            public void SetAvalaibleBeerVolume(double beer)
            {
                _avalaibleBeerVolume = beer;
            }
            public int GetAvalaibleBottles()
            {
                return _avalaibleBottles;
            }
            public void SetAvalaibleBottles(int bottles)
            {
                _avalaibleBottles = bottles;
            }
            public int GetAvalaibleCapsules()
            {
                return _avalaibleCapsules;
            }
            public void SetAvalaibleCapsules(int capsules)
            {
                _avalaibleCapsules = capsules;
            }
            public void AddBeer()
            {
                _avalaibleBeerVolume = Math.Round((_avalaibleBeerVolume - Math.Abs(0.33)), 2);
            }

            public void Encapsulate()
            {
                _avalaibleBottles--;
                _avalaibleCapsules--;
            }

            public int ProduceEncapsulateBeerBottles(int bottlesNeed)
            {
                if (CanProduce(bottlesNeed))
                {
                    return bottlesNeed;
                }
                else
                {
                    return 0;
                }
            }
            public bool CanProduce(int bottlesNeed)
            {
                if (_avalaibleBottles >= bottlesNeed && _avalaibleCapsules >= bottlesNeed && _avalaibleBeerVolume > 0.33 * bottlesNeed)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
