///
/// Author: Moshe Binieli
/// Author: Dominic Groshong
/// Date: August 3, 2020
/// <summary>I claim none of the code as uniquely my own and I am using this as a referance and a practice project done by following along with the 
/// following tutorial by Moshe Binieli at https://www.freecodecamp.org/news/tdd-explanation-hands-on-practice-with-c-a0124338be44/ </summary>
///


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        }
    }

    public class Stack<T>
    {
        /// <summary>
        /// Generic stack class
        /// </summary>

        #region Variables
        // initialize array and maximum length of array
        private T[] stack;
        private int maxLength;
        #endregion

        #region Functions
        public int Size { get; private set; }
        
        public void Push(T value)
        {
            if (Size == maxLength)
                throw new ExceededSizeException();

            stack[Size++] = value;
        }

        public T Pop()
        {
            if (Size == 0)
                throw new ExpenditureProhibitedException();

            return stack[--Size];
        }

        public T Peek()
        {
            if (Size == 0)
                throw new ExpenditureProhibitedException();

            return stack[Size - 1];
        }
        #endregion
       
        #region Constructor
        public Stack(int length)
        {
            maxLength = length;
            stack = new T[length];
        }
        #endregion
    }


}
