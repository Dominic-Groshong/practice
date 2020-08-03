using NUnit.Framework;
using Stack;

namespace StackTests
{
    [TestFixture]
    public class StackTest
    {
        [Test]
        public void Create()
        {
            // Initialize
            Stack<int> s = new Stack<int>(3);
            // Setup & Result
            Assert.AreEqual(0, s.Size);
        }

        [Test]
        public void Push_Pop()
        {
            // Initalize
            Stack<int> s = new Stack<int>(3);
            // Setup
            s.Push(3);
            s.Push(2);
            s.Push(1);
            int result = s.Pop();
            // Result
            Assert.AreEqual(1, result);
            Assert.AreEqual(2, s.Size);
        }

        [Test]
        public void EmptyStack_Pop()
        {
            // Initalize 
            Stack<int> s = new Stack<int>(3);
            // Setup & Result
            Assert.Throws<ExpenditureProhibitedException>(() => s.Pop());
        }

        [Test]
        public void FullStack_Push()
        {
            // Initialize
            Stack<int> s = new Stack<int>(3);
            // Setup
            s.Push(1);
            s.Push(2);
            s.Push(3);
            //Result
            Assert.Throws<ExceededSizeException>(() => s.Push(4));
        }

        [Test]
        public void EmptyStack_Peek()
        {
            // Initialize
            Stack<int> s = new Stack<int>(3);
            Assert.Throws<ExpenditureProhibitedException>(() => s.Peek());

        }

        [Test]
        public void Peek()
        {
            // Initialize
            Stack<int> s = new Stack<int>(3);
            // Setup
            s.Push(1);
            s.Push(2);
            int result = s.Peek();

            // Result
            Assert.AreEqual(2, result);
            Assert.AreEqual(2, s.Size);

        }
    }
}
