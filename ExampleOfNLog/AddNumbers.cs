using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOfNLog
{
    class AddNumbers
    {

        Nlog nlog = new Nlog();

        public int Add(int firstNumber , int secondNumber)
        {
            if (firstNumber == 0 || secondNumber == 0)
            {
                nlog.LogDebug("Debug Unsuccessful : Add()");
                nlog.LogError("Values enetered  by user should shouold be greater than zero");
                nlog.LogWarn("First or second number should be greater than zero");
            }
            else
            {
                int sum = firstNumber + secondNumber;
                nlog.LogDebug("Debug Successfull : Add()");
                nlog.LogInfo("Add() : passed");
                return sum;
            }
            return 0;
          
        }
    }
}
