using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser1
{
    public class MoodAnalyser 
    {
        private string message;
        public MoodAnalyser()
        {

        }
       public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string analyseMood(string message)
        {
                if (message.Equals("I am in sad Mood"))
                    return "SAD";
                else
                    return "HAPPY";
        }
        public string analyseMood() 
        {
            try
            {
                if (this.message.Equals(null))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MESSAGE, "Mood should not be Null");
                }
                if (message.Equals("I am in sad Mood"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch(NullReferenceException)
            {
                return "HAPPY";
            }
        }



    }
}
