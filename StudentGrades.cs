using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        private readonly StudentGrades
            converter = new StudentGrades();

        private readonly int[] StatsMarks = new int[]
        {
            10, 20, 30, 40, 50, 60, 70, 80, 90, 100
        };

        private int[] testMarks;

        [TestMethod]
        public void TestConvert0ToGradeF { }
        {
            //Arrange
            StudentGrades expectedGrade = Grades.F;
            
            //Act
            StudentGrades actualGrade

    }
}
