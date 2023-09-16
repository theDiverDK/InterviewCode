namespace InterviewCode.Device;

public class Device : IDevice
{
    public long SerialNumber { get; set; }
    public string? DeviceName { get; set; }

    public override string ToString()
    {
        return $"SerialNumber = '{SerialNumber}' with DeviceName = '{DeviceName}'";
    }
}