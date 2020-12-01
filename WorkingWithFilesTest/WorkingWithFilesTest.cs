using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

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
            var expected = 6;

            var actual = WorkingWithFiles.WorkingWithFiles.WordCount("WordCounter.txt");

            actual.Should().Be(expected, because: "the file contains 6 words");
        }

        [TestMethod]
        public void SingularWord()
        {
            var expected = 1;

            var actual = WorkingWithFiles.WorkingWithFiles.WordCount("SingularLongWord.txt");

            actual.Should().Be(expected, because: "the file contains only one word");
        }

        [TestMethod]
        public void CanTheMethodHandleAnEmptyFile()
        {
            var expected = 0;

            var actual = WorkingWithFiles.WorkingWithFiles.WordCount("EmptyFile.txt");

            actual.Should().Be(expected, because: "the file contains no words");
        }

    }

    [TestClass]
    public class LongestWordTest
    {
        [TestMethod]
        public void LongestWordWorks()
        {
            var expected = "exercise";

            var actual = WorkingWithFiles.WorkingWithFiles.LongestWord("WordCounter.txt");

            actual.Should().Be(expected, because: "the longest words in the file is 'exercise', so that is what should be returned");
        }

        [TestMethod]
        public void SingularWord()
        {
            var expected = "supercalifragilisticexpialidocious";

            var actual = WorkingWithFiles.WorkingWithFiles.LongestWord("SingularLongWord.txt");

            actual.Should().Be(expected, because: "the file contains only one word");
        }

        [TestMethod]
        public void CanTheMethodHandleAnEmptyFile()
        {
            var expected = "File is Empty";

            var actual = WorkingWithFiles.WorkingWithFiles.LongestWord("EmptyFile.txt");

            actual.Should().Be(expected, because: "the file contains no words");
        }

    }

}
