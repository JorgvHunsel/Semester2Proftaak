using System;
using System.ComponentModel.DataAnnotations.Schema;
using Fontys.PTS2.Prototype.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAllOpenQuestions()
        {
            Database db = new Database();
            db.GetAllOpenQuestions();
            
        }
    }
}
