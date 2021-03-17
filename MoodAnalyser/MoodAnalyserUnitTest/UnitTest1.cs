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
        [TestMethod]
        public void whenMood_IsNull_ShouldReturn_CustomException_WithExceptionType()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            Assert.ThrowsException<MoodAnalyserException>(() => moodAnalyser.analyseMood());
        }
        [TestMethod]
        public void whenMood_IsEmpty_ShouldReturn_CustomException_WithExceptionType()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("");
            Assert.ThrowsException<MoodAnalyserException>(() => moodAnalyser.analyseMood());
        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyserObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyser1.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_Improper_ShouldThrow_NO_SUCH_CLASS_Exception()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            Assert.ThrowsException<MoodAnalyserException>(() => MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyser1.Mood", "MoodAnalyser"));
        }
        [TestMethod]
        public void GivenMoodAnalyseConstructorName_Improper_ShouldThrow_NO_SUCH_METHOD_Exception()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            Assert.ThrowsException<MoodAnalyserException>(() => MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyser1.Mood", "Mood"));

        }






        }
    }
