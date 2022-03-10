/****************************************************************************************************************************
Project:    CountdownTimer
File:       CountdownList.cs
Author:     Leon Ablinger / AblL
Version:    1.0.0.2
Created:    08/03/2022
Updated:    10/03/2022

Copyright (c) 2022 - Leon Ablinger / AblL
****************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdownTimer
{
    public class ListCountdown
    {
        private readonly List<Countdown> _CountdownList = new List<Countdown>();

        public ListCountdown()
        {
            
        }

        public int Count()
        {
            return _CountdownList.Count;
        }

        public List<Countdown> Get()
        {
            return _CountdownList;
        }

        public String[] GetNames()
        {
            String[] Names = new String[this.Count()];
            for (int i = 0; i < this.Count(); i++)
            {
                Names[i] = _CountdownList[i].Name;
            }
            return Names;
        }
        
        public bool Add(Countdown CountdownToAdd)
        {
            try
            {
                _CountdownList.Add(CountdownToAdd);
                if (_CountdownList[_CountdownList.Count - 1] == CountdownToAdd) return true;
                return false;
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }
    }

    public class Countdown
    {
        public String Name;
        public DateTime DateTime;

        public Countdown(String Name, DateTime DateTime)
        {
            this.Name = Name;
            this.DateTime = DateTime;
        }

        public Countdown()
        {

        }
    }
}
