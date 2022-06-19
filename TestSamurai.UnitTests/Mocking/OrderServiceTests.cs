using Moq;
using TestSamurai.Mocking;

namespace TestSamurai.UnitTests.Mocking
{
    [TestFixture]
    public class OrderServiceTests
    {
        [Test]
        public void PlaceOrder_WhenCalled_ShouldStoreTheOrder()
        {
            var mockStorage = new Mock<IStorage>();
            var service = new OrderService(mockStorage.Object);

            var order = new Order();
            service.PlaceOrder(order);

            mockStorage.Verify(m => m.Store(order));
        }
    }
}
