using InterviewCode.Device;
using InterviewCode.Filters;
using Xunit;

namespace InterviewCodeUnitTest.Filters;

public class DeviceNameAtLeast1LongFilterTest
{
    [Fact]
    public void Apply_ReturnsDevicesFromSerialNumberAndDeviceNameFilter()
    {
        // Arrange
        var filter = new DeviceNameAtLeast1LongFilter<IDevice>();
        var devices = new List<Device>
        {
            new() { SerialNumber = 1234567890, DeviceName = "Device 1" },
            new() { SerialNumber = 1234567891, DeviceName = "" },
            new() { SerialNumber = 1234567892, DeviceName = null },
            new() { SerialNumber = 1234567893, DeviceName = "Device 2" },
        };

        // Act
        var filteredDevices = filter.Apply(devices).ToList();

        // Assert
        Assert.Equal(2, filteredDevices.Count);
        Assert.Equal(1234567890, filteredDevices[0].SerialNumber);
        Assert.Equal("Device 1", filteredDevices[0].DeviceName);

        Assert.Equal(1234567893, filteredDevices[1].SerialNumber);
        Assert.Equal("Device 2", filteredDevices[1].DeviceName);
    }
}