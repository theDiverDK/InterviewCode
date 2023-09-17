using InterviewCode.Device;
using InterviewCode.Filters;
using Xunit;

namespace InterviewCodeUnitTest;

public class DevicesListEmpty
{
    [Fact]
    public void Apply_TestDevicesListEmptyTest()
    {
        // Arrange
        var filter = new DeviceNameAtLeast1LongFilter<IDevice>();
        var devices = new List<Device>();

        // Act and Assert
        var filteredDevices = filter.Apply(devices).ToList();

        // Assert
        Assert.Empty(filteredDevices);
    }
}