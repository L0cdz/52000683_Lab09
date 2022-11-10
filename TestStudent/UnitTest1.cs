using StudentService;

namespace TestStudent
{
    [TestClass]
    public class UnitTest1
    {
         
        [TestMethod]
        //Testcase1
        public void checkScore_Should_Success()
        {
           
                Student student = new Student();
                double status = student.Score = 10;
                Assert.AreEqual(status,10);
     
        }
        [TestMethod]
        //Testcase2
        public void checkScore_Should_Success_SystemException()
        {
            Student student = new Student();
            student.Score = 10;
            if (student.Score > 10 || student.Score < 0) { throw new SystemException(); }
            
        }
        [TestMethod]
        //Testcase3
        public void checkLetterScore_Should_Success()
        {
            Student student = new Student();
            student.Score = 10;
            char letter = student.getLetterScore();
            Assert.AreEqual(letter,10);


        }
        
    }
}