using AC1_M3UF5_Qihang;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CheckPlayer_Available_OnlyCharacters()
        {
            //Arrange
            string player = "John";
            //Act
            bool result = Score.CheckPlayer(player);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckPlayer_Unavailable_OnlyLetters()
        {
            //Arrange
            string player = "123";
            //Act
            bool result = Score.CheckPlayer(player);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckPlayer_Unavailable_CharacterAndNumbers()
        {
            //Arrange
            string player = "John123";
            //Act
            bool result = Score.CheckPlayer(player);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckMission_Available_CorrectFormat()
        {
            //Arrange
            string mission = "Alfa-123";
            //Act
            bool result = Score.CheckMission(mission);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckMission_Unavailable_IncorrectFormat_StyleOne()
        {
            //Arrange
            string mission = "Alfa123";
            //Act
            bool result = Score.CheckMission(mission);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckMission_Unavailable_IncorrectFormat_StyleTwo()
        {
            //Arrange
            string mission = "Alfa13";
            //Act
            bool result = Score.CheckMission(mission);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckMission_Unavailable_IncorrectFormat_StyleThree()
        {
            //Arrange
            string mission = "Holaa13";
            //Act
            bool result = Score.CheckMission(mission);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckMission_Unavailable_NotGreekCharacter()
        {
            //Arrange
            string mission = "Hola-123";
            //Act
            bool result = Score.CheckMission(mission);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckMission_Unavailable_MoreThan3DIgit()
        {
            //Arrange
            string mission = "Delta-122133";
            //Act
            bool result = Score.CheckMission(mission);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckMission_Unavailable_LessThan3DIgit()
        {
            //Arrange
            string mission = "Omega-12";
            //Act
            bool result = Score.CheckMission(mission);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckScoring_Available_InsideTheRange()
        {
            //Arrange
            int scoring = 123;
            //Act
            bool result = Score.CheckScoring(scoring);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckScoring_Unavailable_ExcesTheRange()
        {
            //Arrange
            int scoring = 1000;
            //Act
            bool result = Score.CheckScoring(scoring);
            //Assert
            Assert.IsFalse(result);
        }
    }
}