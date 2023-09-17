using InterviewCode.Device;
using InterviewCode.Filters;
using Xunit;

namespace InterviewCodeUnitTest;

public class DevicesListNullTest
{
    [Fact]
    public void Apply_TestDevicesListNullTest()
    {
        // Arrange
        var filter = new DeviceNameAtLeast1LongFilter<IDevice>();
        List<Device> devices = null;

        // Act and Assert
        var exception = Assert.Throws<ArgumentNullException>(() => filter.Apply(devices).ToList());

        // Assert
        Assert.Equal("The 'items' parameter cannot be null. (Parameter 'items')", exception.Message);
    }
}