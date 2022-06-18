using TestSamurai.Fundementals;

namespace TestSamurai.UnitTests.Tests
{
    [TestFixture]
    public class StacksTests
    {
        private Stacks<string> _stack;

        [SetUp]
        public void SetUp()
        {
            _stack = new Stacks<string>();
        }


        //---------------PushMethodTests---------------//
        [Test]
        public void Push_GivingNull_ThrowsNullException()
        {
            //Arrange
            //Act
            //Assert
            Assert.That(() => _stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_GivingValidArgs_AddObjectToStack()
        {
            //Act
            _stack.Push("a");
            //Assert
            Assert.That(_stack, Has.Count.EqualTo(1));
        }


        //---------------PopMethodTests---------------//
        [Test]
        public void Pop_PopingEmptyStack_ThrowsInvalidOperationException()
        {
            Assert.That(() => _stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_StackWithAFewObjects_ReturnObjectOnTop()
        {
            //Arrange
            Stacks<string>? stack = new();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            //Act
            string? result = stack.Pop();
            //Assert
            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Pop_StackWithAFewObjects_RemoveObjectOnTop()
        {
            //Arrange
            Stacks<string>? stack = new();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            //Act
            _ = stack.Pop();
            //Assert
            Assert.That(stack.Count, Is.EqualTo(2));
        }



        //---------------PeekMethodTests---------------//
        [Test]
        public void Peek_EmptyStack_ThrowsInvalidException()
        {
            //Assert
            Assert.That(() => _stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackWithObjects_ReturnsThePeekObject()
        {
            //Arrange
            Stacks<string>? stack = new();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            //Act
            string? result = stack.Peek();
            //Assert
            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Peek_StackWithObjects_DoesNotDeleteTheLastObject()
        {
            //Arrange
            Stacks<string>? stack = new();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            //Act
            _ = stack.Peek();
            //Assert
            Assert.That(stack, Has.Count.EqualTo(3));
        }

    }
}
