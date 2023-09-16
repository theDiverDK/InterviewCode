using InterviewCode.Device;
using InterviewCode.Filters;
using Xunit;

namespace InterviewCodeUnitTest.Filters
{
    public class EmptyDeviceNameFilterTests
    {
        [Fact]
        public void Apply_ReturnsDevicesWithEmptyDeviceName()
        {
            // Arrange
            var filter = new EmptyDeviceNameFilter<IDevice>();
            var devices = new List<Device>
            {
                new() { SerialNumber = 1234567890, DeviceName = null },
                new() { SerialNumber = 1234567891, DeviceName = "" },
                new() { SerialNumber = 1234567892, DeviceName = null },
                new() { SerialNumber = 1234567893, DeviceName = "Device 2" },
            };

            // Act
            var filteredDevices = filter.Apply(devices).ToList();

            // Assert
            Assert.Equal(3, filteredDevices.Count);
            Assert.Equal(1234567890, filteredDevices[0].SerialNumber);
            Assert.Equal(1234567891, filteredDevices[1].SerialNumber);
            Assert.Equal(1234567892, filteredDevices[2].SerialNumber);
        }
    }
}