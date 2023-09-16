namespace InterviewCode.Device;

public interface IDevice
{
    long SerialNumber { get; set; }
    string? DeviceName { get; set; }
}