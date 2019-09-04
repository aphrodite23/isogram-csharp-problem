using System;
using Xunit;
using Isogram;

namespace Isogram.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
          Assert.Equal(true,Class1.isIsogram(""));  
        }
         [Fact]
        public void Test2()
        {
             Assert.Equal(true,Class1.isIsogram("isogram"));
        }
         [Fact]
        public void Test3()
        {
             Assert.Equal(false,Class1.isIsogram("eleven"));
        }
         [Fact]
        public void Test4()
        {
             Assert.Equal(true,Class1.isIsogram("subdermatoglyphic"));
        }
         [Fact]
        public void Test5()
        {
             Assert.Equal(true,Class1.isIsogram("Alphabet"));
        }
         [Fact]
        public void Test6()
        {
             Assert.Equal(true,Class1.isIsogram("thumbscrew-japingly"));
        }
         [Fact]
        public void Test7()
        {
             Assert.Equal(true,Class1.isIsogram("six-year-old"));
        }
         [Fact]
        public void Test8()
        {
             Assert.Equal(true,Class1.isIsogram(" "));
        }
    }
}
