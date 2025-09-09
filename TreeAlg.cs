using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa2AlgoritimoArvore
{
    public static class TreeAlg
    {
        #region [ PublicMethods ]
       
        public static string GetStringCenarios(StringBuilder sb, int[] numbers)
        {
            sb.Append("ROOT:");      
            sb.Append(GetRoot(numbers).ToString());
            sb.AppendLine();
            sb.Append("LeftBranch:");
            sb.AppendLine();
            sb.Append(ToString(GetLeftBranch(numbers)));
            sb.AppendLine();
            sb.Append("RightBranch:");
            sb.AppendLine();
            sb.Append(ToString(GetRightBranch(numbers)));
            sb.AppendLine();

            return sb.ToString();
        }

        public static int GetRoot(int[] numbers)
        {
            int[] distinctNumberArray = GetValidNumberArray(numbers);
            return distinctNumberArray.Max();
        }

        public static int[] GetLeftBranch(int[] numbers)
        {
            int[] distinctNumbers = GetValidNumberArray(numbers);
            int root = GetRoot(distinctNumbers);

            int rootIndex = GetRootIndexPosition(distinctNumbers, root);
            int[] leftBranch = GetLeftBranchValues(distinctNumbers, root, rootIndex);

            return leftBranch;
        }

        public static int[] GetRightBranch(int[] numbers)
        {
            int[] distinctNumbers = GetValidNumberArray(numbers);
            int root = GetRoot(distinctNumbers);

            int rootIndex = GetRootIndexPosition(distinctNumbers, root);
            int[] rightBranch = GetRightBranchValues(distinctNumbers, root, rootIndex);

            return rightBranch;
        }


        #endregion

        #region [ PrivateMethods ]

        private static int[] GetLeftBranchValues(int[] validNumberArray, int root, int rootIndex)
        {
            return validNumberArray.Take(rootIndex).Where(n => n != root).OrderByDescending(x => x).ToArray();
        }

        private static int[] GetRightBranchValues(int[] validNumberArray, int root, int rootIndex)
        {
            return validNumberArray.Skip(rootIndex).Where(n => n != root).OrderByDescending(x => x).ToArray();
        }


        private static int[] GetValidNumberArray(int[] numbers)
        {
            if (IsNullOrEmptyValidation(numbers))
            {
                throw new ArgumentNullException(nameof(numbers));
            }

            return ToDistinct(numbers);
        }

        private static int GetRootIndexPosition(int[] validNumberArray, int root)
        {
            return Array.IndexOf(validNumberArray, root);
        }

        private static int[] ToDistinct(int[] numbers)
        {
            return numbers.Distinct().ToArray();
        }

        private static bool IsNullOrEmptyValidation (int[] numbers)
        {
            return numbers == null || numbers.Length == 0;
        }

        private static string ToString(int[] numbers)
        {
            if (IsNullOrEmptyValidation(numbers))
            {
                throw new ArgumentNullException(nameof(numbers));
            }

            return string.Join(',', numbers.Select(x => x.ToString()));
        }

        #endregion
    }
}