using Project_65030096;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestProjectMembersCount()
        {
            Assert.IsTrue(Enum.GetNames(typeof(Project.Members)).Length == 4);
        }
        [TestMethod]
        public void TestProjectMemberIds()
        {
             Assert.IsTrue((int)Project.Members.Kla == 1);
             Assert.IsTrue((int)Project.Members.Phet == 2);
             Assert.IsTrue((int)Project.Members.Mag == 3);
        


        }
    }
}