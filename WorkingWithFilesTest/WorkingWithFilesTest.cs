using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorkingWithFilesTest
{        
    
    // 1- Write a method that reads a text file and returns the number of words. Ex. The file
    // contains, "The dog ran away from home." The method should return "6" the number of words
    // contained in the file.
    [TestClass]
    public class WordCountTest
    {
        [TestMethod]
        public void WordCountWorks()
        {
            var expected = 258;

            var actual = WorkingWithFiles.WorkingWithFiles.WordCount("Exercise_8_Text_File");

            actual.Should().Be(expected, because: "the file contains 258 words (all the lyrics of 'Never Going To Give You Up')");
        }

        [TestMethod]
        public void SingularWord()
        {
            var expected = 1;

            var actual = WorkingWithFiles.WorkingWithFiles.WordCount(/* long word file */);

            actual.Should().Be(expected, because: "the file contains only one word");
        }

        [TestMethod]
        public void CanTheMethodHandleAnEmptyFile()
        {
            var expected = 0;

            var actual = WorkingWithFiles.WorkingWithFiles.WordCount(/* empty Text File */);

            actual.Should().Be(expected, because: "the file contains no words.");
        }

    }

    [TestClass]
    public class LongestWordTest
    {
        [TestMethod]
        public void LongestWordWorks()
        {
            var expected = "";

            var actual = WorkingWithFiles.WorkingWithFiles.WordCount("Exercise_8_Text_File");

            actual.Should().Be(expected, because: "the file contains 258 words (all the lyrics of 'Never Going To Give You Up')");
        }

        [TestMethod]
        public void SingularWord()
        {
            var expected = 1;

            var actual = WorkingWithFiles.WorkingWithFiles.WordCount(/*singular word Text File */);

            actual.Should().Be(expected, because: "the file contains only one word");
        }

        [TestMethod]
        public void CanTheMethodHandleAnEmptyFile()
        {
            var expected = 0;

            var actual = WorkingWithFiles.WorkingWithFiles.WordCount(/* empty Text File */);

            actual.Should().Be(expected, because: "the file contains no words.");
        }

    }

}
