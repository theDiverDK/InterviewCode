using InterviewCode.Device;
using InterviewCode.Filters;
using Xunit;

namespace InterviewCodeUnitTest.Filters;

public class SerialNumberStartsWith9FilterTests
{
    [Fact]
    public void Apply_ReturnsDevicesWithSerialNumberStartsWith9Filter()
    {
        // Arrange
        var filter = new SerialNumberStartsWith9Filter<IDevice>();
        var devices = new List<Device>
        {
            new() { SerialNumber = 1234567890, DeviceName = null },
            new() { SerialNumber = 9234567891, DeviceName = "Device 1" },
            new() { SerialNumber = 9234567892, DeviceName = null },
            new() { SerialNumber = 1234567893, DeviceName = "Device 2" },
        };

        // Act
        var filteredDevices = filter.Apply(devices).ToList();

        // Assert
        Assert.Equal(2, filteredDevices.Count);
        Assert.Equal(9234567891, filteredDevices[0].SerialNumber);
        Assert.Equal("Device 1", filteredDevices[0].DeviceName);

        Assert.Equal(9234567892, filteredDevices[1].SerialNumber);
        Assert.Null(filteredDevices[1].DeviceName);
    }
}