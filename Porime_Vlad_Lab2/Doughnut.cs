using System;
using System.Collections.Generic;
using System.Text;

namespace Porime_Vlad_Lab2
{
    class Doughnut
    {
        private DoughnutType mFlavor;
        public DoughnutType Flavor
        {
            get
            {
                return mFlavor;
            }
            set
            {
                mFlavor = value;
            }
        }

        private float mPrice = .50F;
        public float Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        private readonly DateTime mTimeOfCreation;
        public DateTime TimeOfCreation
        {
            get
            {
                return mTimeOfCreation;
            }
        }
        public Doughnut(DoughnutType aFlavor)
        {
            mTimeOfCreation = DateTime.Now;
            mFlavor = aFlavor;

        }
    }
}
