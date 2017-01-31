using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack;

namespace SpecFlow
{
    [Binding]
    public class ImplementimiINjeStive_DoPermbajeSteps
    {
        private ClassaStack klasastack = new ClassaStack();
        private int count1;
        private int count2;
        private int count ;
        object[] Stack;
        private int number { get; set; }
        private int elementet { get; set; }
       

        object rez;

        [Given(@"StackSize me madhesi fikse")]
        public void GivenStackSizeMeMadhesiFikse()
        {

            klasastack.MadhesiStive = number;
        }
        
        [Given(@"Stack me pak elemente")]
        public void GivenStackMePakElemente()
        {
            klasastack.ElementStive = elementet;
        }
        
        [Given(@"Stack me elemente")]
        public void GivenStackMeElemente()
        {
            klasastack.ElementStive = elementet;
        }
        
        [When(@"Ti push nje element te ri")]
        public void WhenTiPushNjeElementTeRi(int elementRi)
        {
            int rez;
            rez  = klasastack.Push();
            Assert.AreEqual(rez, elementRi);

        }
        
        [When(@"Ti pop element nga Stack")]
        public void WhenTiPopElementNgaStack(int elementPop)
       {
           int rez1;
           rez1 = klasastack.Pop();
           Assert.AreEqual( rez1, elementPop);
        }
        
        [When(@"Stack me elemente")]
        public void WhenStackMeElemente()
        {
            klasastack.ElementStive = elementet;
        }
        
       [Then(@"Count do te rritet me nje")]
        public void ThenCountDoTeRritetMeNje()
        {
            count1++;
        }
        
       [Then(@"Stack do te behet nje element me shume")]
        public void ThenStackDoTeBehetNjeElementMeShume()
       {
           Stack[++count1] = elementet;
           
       }
       
        [Then(@"Count do te zbritet me nje")]
        public void ThenCountDoTeZbritetMeNje()
        {

            count2 --;
        }

        
        [Then(@"Stack do te behet nje element me pak")]
        public void ThenStackDoTeBehetNjeElementMePak()
        {
            Stack[--count2] = elementet;
       }
        
        [Then(@"Merr keto elemente")]
        public void ThenMerrKetoElemente()
        {
            
            rez = klasastack.Top();
            
        }
        
        [Then(@"Kthe keto elemente")]
       public void ThenKtheKetoElemente()
        {
            count = count1 - count2;
            Assert.AreEqual(Stack[count], rez);
        }
    }
}
