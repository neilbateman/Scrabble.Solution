using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleValuesModels;

namespace ScrabbleValuesTests
{
  [TestClass]
  public class ScrabbleValueTest
  {
    [TestMethod]
    public void GetScrabbleValue_GetsValue_int()
    {
      //Arrange


      //Act
      var result = ScrabbleValues.ScrabbleScore("a");

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetScrabbleValueIgnoreCase()
    {
      //Arrange


      //Act
      var result = ScrabbleValues.ScrabbleScore("A");

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetScrabbleCharArray()
    {
      //Arrange

      //Act
      var result = ScrabbleValues.ScrabbleScore("cat");

      //Assert
      Assert.AreEqual(5, result);
    }
    //
    // [TestMethod]
    // public void GetScrabbleValue_GetsValue_int()
    // {
    //   //Arrange
    //   string word = "a";
    //   ScrabbleValues newScrabbleValues = new ScrabbleValues();
    //
    //   //Act
    //   int wordValue = 1;
    //   newScrabbleValues.SetScrabbleValues(wordValue);
    //   int result = newScrabbleValues.GetWord();
    //
    //   //Assert
    //   Assert.AreEqual(wordValue, result);
    // }
    //
    // [TestMethod]
    // public void ScrabbleScore_WordToCharArray_array()
    // {
    //   //Arrange
    //   string word = "cat";
    //   ScrabbleScore newScrabbleScore = new ScrabbleScore();
    //
    //   //Act
    //   string wordValue = {"C","A","T"};
    //   newScrabbleScore.SetScrabbleScore(wordValue);
    //   string result = newScrabbleScore.ScrabbleScore();
    //
    //   //Assert
    //   Assert.AreEqual(wordValue, result);
    // }
  }
}
