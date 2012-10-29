/*   Author: Ben Glasser
 *   Date:  3/1/2012
 *   File:  Patch.cs
 *   Purpose:  The Patch Model
 *   Project:  This project attempts to model a phenomemon know as tragedy of the commons 
 *   by allowing heterogeneous agents to buy and sell pollution credits on an open market
 *   as they seek only to satisfy their preference for consumption/pollution.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TragedyOfCommons
{
    class Patch
    {
        // Patch Member Variables-----------------------------------------------------------
        //level of puolution of the current patch
        private int _pollution;
        public int Pollution
        {
            get { return _pollution; }
            set { _pollution = value; }
        }
        //level of vegitation of the current patch
        private int _vegetation;
        public int Vegetation
        {
            get { return _vegetation; }
            set { _vegetation = value; }
        }

        private Point _location;
        public Point Location
        {
            get { return _location; }
            set { _location = value; }
        }

        private bool _isEmpty;
        public bool IsEmpty
        {
            get { return _isEmpty; }
            set { _isEmpty = value; }
        }

        //---------------------------------------------------------------------------------
        //constructor
        public Patch()
        {
            Location = new Point();
            IsEmpty = true;
            Vegetation = 0;
            Pollution = 0;
        }
        public Patch(Point location = new Point(), 
            bool isEmpty = true,
            int veg  = 0, 
            int pol = 0)
        {
            Location = location;
            IsEmpty = isEmpty;
            Vegetation = veg;
            Pollution = pol;
        }
        public override String ToString()
        {
            return "Empty = " + IsEmpty
                + "\n Pollution = " + Pollution
                + "\n Vegetation = " + Vegetation 
                + Environment.NewLine;
        }
        public void Grow()
        {
            Vegetation++;
        }
        public void Pollute()
        {
            Pollution++;
        }
    }
}