using CrackingCodingInterview;
using Xunit;

namespace Algorithms.Test
{
    public class OneWayTest
    {
        OneWayQuest _oneWayTest = new OneWayQuest();
        //pale, ple =>  true 
        //pales, pale  =>  true 
        //pale, bale  =>  true 
        //pale, bae  =>  false
       
        [Fact]
        public void OneWay()
        {

            bool test1 = _oneWayTest.OneAway("pale", "ple");
            var test2 = _oneWayTest.OneAway("pales", "pale");
            var test3 = _oneWayTest.OneAway("pale", "bale");
            var test4 = _oneWayTest.OneAway("pale", "bae");

            Assert.True(test1);
            Assert.True(test2);
            Assert.True(test3);
            Assert.False(test4);

        }

    }
}
