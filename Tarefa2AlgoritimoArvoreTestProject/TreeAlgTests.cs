using Tarefa2AlgoritimoArvore;

namespace Tarefa2AlgoritimoArvoreTestProject
{
    public class TreeAlgTests
    {
        [Fact]
        public void GetRootCenario1Test()
        {
            int[] numbers = [3, 2, 1, 6, 0, 5];
            int expectedRoot = 6;
            int root = TreeAlg.GetRoot(numbers);

            Assert.Equal(expectedRoot, root);
        }

        [Fact]       
        public void GetLeftBranchCenario1Test()
        {
            int[] numbers = [3, 2, 1, 6, 0, 5];
            int[] expectedLeftBranch = [3, 2, 1];
            int[] leftBranch =  TreeAlg.GetLeftBranch(numbers);

            Assert.Equal(expectedLeftBranch, leftBranch);
        }


        [Fact]
        public void GetRightBranchCenario1Test()
        {
            int[] numbers = [3, 2, 1, 6, 0, 5];
            int[] expectedLeftBranch = [5, 0];
            int[] leftBranch = TreeAlg.GetRightBranch(numbers);

            Assert.Equal(expectedLeftBranch, leftBranch);
        }

        [Fact]
        public void GetRootCenario2Test()
        {
            int[] numbers = [7, 5, 13, 9, 1, 6, 4];
            int expectedRoot = 13;
            int root = TreeAlg.GetRoot(numbers);

            Assert.Equal(expectedRoot, root);
        }

        [Fact]
        public void GetLeftBranchCenario2Test()
        {
            int[] numbers = [7, 5, 13, 9, 1, 6, 4];
            int[] expectedLeftBranch = [7, 5];
            int[] leftBranch = TreeAlg.GetLeftBranch(numbers);

            Assert.Equal(expectedLeftBranch, leftBranch);
        }


        [Fact]
        public void GetRightBranchCenario2Test()
        {
            int[] numbers = [7, 5, 13, 9, 1, 6, 4];
            int[] expectedRightBranch = [9,6,4,1];
            int[] leftBranch = TreeAlg.GetRightBranch(numbers);

            Assert.Equal(expectedRightBranch, leftBranch);
        }        
    }
}