using InterviewCode.Device;
using InterviewCode.Filters;
using Xunit;

namespace InterviewCodeUnitTest.Filters;

public class SerialNumberExactly10DigitsLongFilterTest
{
    [Fact]
    public void Apply_ReturnsDevicesFromSerialNumberAndDeviceNameFilter()
    {
        // Arrange
        var filter = new SerialNumberExactly10DigitsLongFilter<IDevice>();
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
        Assert.Equal(4, filteredDevices.Count);
        Assert.Equal(1234567890, filteredDevices[0].SerialNumber);
        Assert.Equal("Device 1", filteredDevices[0].DeviceName);

        Assert.Equal(1234567891, filteredDevices[1].SerialNumber);
        Assert.Equal("", filteredDevices[1].DeviceName);
        
        Assert.Equal(1234567892, filteredDevices[2].SerialNumber);
        Assert.Null(filteredDevices[2].DeviceName);

        Assert.Equal(1234567893, filteredDevices[3].SerialNumber);
        Assert.Equal("Device 2", filteredDevices[3].DeviceName);

    }
}