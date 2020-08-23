using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Student : Person
    {
        public enum GradeLevels
        {
            Freshman,
            Sophmore,
            Junior,
            Senior
        }
        public GradeLevels Gradelevel;

        public override float ComputeGradeAverage()
        {
            return 4.0f;
        }

        public override string SendMessage(string message)
        {
            var original =  base.SendMessage(message);
            var sb = new StringBuilder(original);
            sb.AppendLine("This message is private and confidential");

            return sb.ToString();

        }
    }
}
