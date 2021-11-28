using NUnit.Framework;

namespace SortingAlgo.Tests
{
    public class SelectionSortTests
    {
        [Test]
        public void SelectionSort_Should_Sort_In_Numerical_Order()
        {
            // arrange
            var numbers = new int[]
            {
                4, 1, 3, 2
            };

            // act
            var actual = SelectionSort.Sort(numbers);

            // assert
            var expected = new int[]
            {
                1, 2, 3, 4
            };

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void SelectionSort_Should_Sort_In_Numerical_Order_large_volume()
        {
            // arrange
            var numbers = new int[]
            {
                49, 156, 67, 177, 76, 97, 102, 20, 48, 7, 29, 90, 197, 35, 120, 164, 173, 89, 31, 
                60, 99, 81, 102, 73, 123, 161, 150, 153, 172, 161, 89, 53, 63, 126, 198, 117, 126, 
                88, 22, 167, 36, 0, 185, 54, 174, 199, 120, 0, 37, 117, 75, 4, 164, 25, 150, 178, 
                13, 41, 107, 197, 5, 154, 43, 46, 84, 20, 150, 161, 49, 94, 31, 193, 39, 32, 78, 7, 
                11, 22, 28, 123, 154, 54, 149, 190, 63, 58, 167, 43, 43, 85, 191, 11, 112, 161, 140, 
                3, 176, 184, 150, 84, 36, 71, 17, 52, 95, 85, 173, 137, 141, 124, 136, 93, 138, 27, 
                114, 20, 60, 49, 178, 179, 66, 163, 0, 186, 74, 83, 30, 14, 18, 37, 137, 81, 26, 94, 
                1, 189, 43, 25, 199, 194, 138, 119, 48, 130, 115, 1, 198, 54, 84, 197, 179, 150, 193, 
                92, 190, 84, 46, 177, 6, 23, 58, 44, 180, 64, 192, 57, 160, 44, 9, 184, 44, 57, 15, 
                128, 73, 81, 103, 17, 197, 98, 42, 168, 112, 152, 132, 156, 23, 60, 133, 198, 39, 52, 
                133, 154, 27, 0, 193, 111, 73, 122
            };

            // act
            var actual = SelectionSort.Sort(numbers);

            // assert
            var expected = new int[]
            {
                0, 0, 0, 0, 1, 1, 3, 4, 5, 6, 7, 7, 9, 11, 11, 13, 14, 15, 17, 17, 18, 20, 20, 20, 22,
                22, 23, 23, 25, 25, 26, 27, 27, 28, 29, 30, 31, 31, 32, 35, 36, 36, 37, 37, 39, 39, 41,
                42, 43, 43, 43, 43, 44, 44, 44, 46, 46, 48, 48, 49, 49, 49, 52, 52, 53, 54, 54, 54, 57,
                57, 58, 58, 60, 60, 60, 63, 63, 64, 66, 67, 71, 73, 73, 73, 74, 75, 76, 78, 81, 81, 81,
                83, 84, 84, 84, 84, 85, 85, 88, 89, 89, 90, 92, 93, 94, 94, 95, 97, 98, 99, 102, 102, 103,
                107, 111, 112, 112, 114, 115, 117, 117, 119, 120, 120, 122, 123, 123, 124, 126, 126, 128,
                130, 132, 133, 133, 136, 137, 137, 138, 138, 140, 141, 149, 150, 150, 150, 150, 150, 152,
                153, 154, 154, 154, 156, 156, 160, 161, 161, 161, 161, 163, 164, 164, 167, 167, 168, 172,
                173, 173, 174, 176, 177, 177, 178, 178, 179, 179, 180, 184, 184, 185, 186, 189, 190, 190,
                191, 192, 193, 193, 193, 194, 197, 197, 197, 197, 198, 198, 198, 199, 199,
            };

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}