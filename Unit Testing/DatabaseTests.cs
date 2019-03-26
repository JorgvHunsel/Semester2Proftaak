using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;
using Fontys.PTS2.Prototype.Classes;
using Fontys.PTS2.Prototype.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Testing
{
    [TestClass]
    public class DatabaseTests
    {
        [TestMethod]
        public void GetAllOpenQuestions()
        {
            //Arrange

            //Act
            QuestionContextSQL.GetAllOpenQuestions();

            //Assert
        }

        public void WriteQuestionToDatabase()
        {
            //Arrange
            //Act
            //Assert
        }

        public void GetAllCategories()
        {
            //Arrange
            //Act
            //Assert
        }



    }
}
