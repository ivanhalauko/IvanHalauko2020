using NUnit.Framework;
using AVLTreeLib;
using StudentInformationtRepository;
using StudentInformationClass;

namespace AVLTreeLib.Tests
{
    [TestFixture()]
    public class AVLTreeTests
    {

        
        [Test]
        public void GivenAddWhenTIsIntThenOutIsIntNode()
        {
            //Arrange
            Repository<StudentInfo> rep = new Repository<StudentInfo>();

            Repository<TestsResult> repTestResult = new Repository<TestsResult>();

            rep.AVLTree.Add(new StudentInfo() { Id = 0, StudentName="Vasya" });
            rep.AVLTree.Add(new StudentInfo() { Id = 1, StudentName = "Petya" });
            rep.AVLTree.Add(new StudentInfo() { Id = 2, StudentName = "YaGor" });

            repTestResult.AVLTree.Add(new TestsResult() { Id = 0 });


            var test = rep.ShowAllTree(x => x.StudentName, false);
            var testTrue = rep.ShowAllTree(x => x.StudentName, true);


        }


        [TestCase(30, 19, 40, 67)]
        [TestCase(2, 1, 3, 4)]
        public void GivenAddWhenTIsIntThenOutIsIntNode(int value, int left, int right, int rightRight)
        {
            //Arrange
            AVLTree<int> expectedTree = new AVLTree<int>();
            expectedTree.Head = new AVLTreeNode<int>(value, new AVLTreeNode<int>(left), new AVLTreeNode<int>(right, null, new AVLTreeNode<int>(rightRight)));

            AVLTree<int> actualTree = new AVLTree<int>();

            actualTree.Add(left);
            actualTree.Add(value);
            actualTree.Add(right);
            actualTree.Add(rightRight);

            //Assert
            Assert.AreEqual(expectedTree, actualTree);

        }

        [TestCase("f", "e", "i", "k")]
        [TestCase("b", "a", "c", "d")]
        public void GivenAddWhenTIsStringThenOutIsStringNode(string value, string left, string right, string rightRight)
        {
            //Arrange
            AVLTree<string> expectedTree = new AVLTree<string>();
            expectedTree.Head = new AVLTreeNode<string>(value, new AVLTreeNode<string>(left), new AVLTreeNode<string>(right, null, new AVLTreeNode<string>(rightRight)));

            AVLTree<string> actualTree = new AVLTree<string>();

            actualTree.Add(left);
            actualTree.Add(value);
            actualTree.Add(right);
            actualTree.Add(rightRight);

            //Assert
            Assert.AreEqual(expectedTree, actualTree);
        }





    }
}