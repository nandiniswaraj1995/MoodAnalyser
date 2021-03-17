using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser1;
namespace MoodAnalyserUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void whenMood_IsSad_ShouldReturnSad()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string mood = moodAnalyser.analyseMood("I am in sad Mood");
            Assert.AreEqual("SAD", mood);
        }
        [TestMethod]
        public void whenMood_IsHappy_ShouldReturnHappy()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string mood = moodAnalyser.analyseMood("I am in happy Mood");
            Assert.AreEqual("HAPPY", mood);
        }
        [TestMethod]
        public void Using_Constructor_whenMood_IsSad_ShouldReturnSad()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in sad Mood");
            string mood = moodAnalyser.analyseMood();
            Assert.AreEqual("SAD", mood);
        }
        [TestMethod]
        public void Using_Constructor_whenMood_IsHappy_ShouldReturnHappy()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Happy Mood");
            string mood = moodAnalyser.analyseMood();
            Assert.AreEqual("HAPPY", mood);
        }
      
         [TestMethod]
         public void whenMood_IsNull_ShouldReturnHappy()
         {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string mood = moodAnalyser.analyseMood(null);
            Assert.AreEqual("HAPPY", mood);
        }
       
    }
}
