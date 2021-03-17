using System;

namespace MoodAnalyser1
{
    class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            string mood = moodAnalyser.analyseMood();
           // Assert.AreEqual(mood, "Mood should not be Null");
          }
    }
}
