using StudentService;

namespace TestStudent
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addStudent_Should_Success()
        {
            Student student = new Student();
            double status = student.Score = 10 ;
            Assert.AreEqual(status,10);
            
        }
    }
}