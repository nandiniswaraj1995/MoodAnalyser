using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser1
{
    public class MoodAnalyser 
    {
       
        public string analyseMood(string message)
        {
                if (message.Equals("I am in sad Mood"))
                    return "SAD";
                else
                    return "HAPPY";
        }
           

    }
}
