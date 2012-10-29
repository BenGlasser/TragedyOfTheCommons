/* **Author: Ben Glasser
 *   Date:  3/1/2012
 *   File:  Agent.cs
 *   Purpose:  the Agent Model
 *   Project:  This project attempts to model a phenomemon know as tragedy of the commons 
 *   by allowing heterogeneous agents to buy and sell pollution credits on an open market
 *   as they seek only to satisfy their preference for consumption/pollution.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TragedyOfCommons
{
    class Agent
    {
        static Random rand = new Random();

        //Agent Member Variables-----------------------------------------------------------
        private bool _moved;
        public bool Moved
        {
            get { return _moved; }
            set { _moved = value; }
        }
        private int _moves;
        public int Moves
        {
            get { return _moves; }
            set { _moves = value; }
        }
        private int _income;
        public int Income
        {
            get { return _income; }
            set { _income = value; }
        }
        private Patch _myPatch;
        internal Patch MyPatch
        {
            get { return _myPatch; }
            set { _myPatch = value; }
        }
        //how much vegetation agents grew
        private int _growMax;
        public int GrowMax
        {
            get { return _growMax; }
            set { _growMax = value; }
        }
        //how much total pollution agent contributed
        private int _pollutionMax;
        public int PollutionMax
        {
            get { return _pollutionMax; }
            set { _pollutionMax = value; }
        }
        private int _surplus;
        public int Surplus
        {
            get { return Income - PecIntercept; }
            set { _surplus = value; }
        }
        private int _PEC;
        public int PEC
        {
            get { return _PEC; }
            set { _PEC = value; }
        }
        private int _pecIntercept;
        public int PecIntercept
        {
            get { return _pecIntercept; }
            set { _pecIntercept = value; }
        }
        //---------------------------------------------------------------------------------
        //constructor
        public Agent(Patch patch, int income = 0, int pec = 50)
        {
            Income = income;
            MyPatch = patch;
            PecIntercept = pec;
            patch.IsEmpty = false;
            PEC = Analyze(patch);           
        }
        public void Grow()
        {
            MyPatch.Vegetation += 1;
        }
        //search patchlist and determine which patch to move to
        public bool Move(ArrayList patchList) {
            ArrayList tmpList = new ArrayList(patchList);
            Patch patch;
            // search for an empty patch
            for (int i = 0; i < patchList.Count; i++)
            {
                patch = ((Patch)(tmpList.ToArray()[rand.Next(tmpList.Count)]));
                if (patch.IsEmpty && CanPollute(patch))
                {
                    MyPatch.IsEmpty = true;
                    MyPatch = patch;
                    MyPatch.IsEmpty = false;
                    return true;
                }
                tmpList.Remove(patch);
            }
            return false;
        }
        public int Analyze(Patch patch)
        {
            return PecIntercept + patch.Vegetation;
        }
        public int AnalyzePatch(Patch patch)
        {
            return Income - patch.Pollution;
        }
        //calculate ability to pollute
        public bool CanPollute(Patch patch)
        {
            return (patch.Pollution < (Income - patch.Vegetation)
                && MyPatch.Pollution < Analyze(patch));
        }
        public bool CanGrow(Patch patch)
        {
            return (patch.Vegetation < (Income - patch.Pollution)
                && MyPatch.Pollution < PEC + (MyPatch.Vegetation + 1));
        }
        public void Decide(ArrayList patchList)
        {
            //Decide whether or not Agent can pollute
            if (CanPollute(MyPatch))
            {
                Moved = false;
                MyPatch.Pollute();
                PollutionMax++;
            }
            //Decide whether or not to grow
            else if (CanGrow(MyPatch))
            {
                MyPatch.Grow();
                GrowMax++;
                MyPatch.Pollute();
                PollutionMax++;
                Moved = false;
            }
            else if (Move(patchList))
            {
                MyPatch.Pollute();
                PollutionMax++;
                Moved = true;
                Moves++;
            }
            else Moved = false;
        }
    }
}
