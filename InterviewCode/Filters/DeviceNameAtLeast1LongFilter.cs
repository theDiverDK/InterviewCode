using InterviewCode.Device;
using InterviewCode.Filters.Generics;

namespace InterviewCode.Filters;

public class DeviceNameAtLeast1LongFilter<T> : FilterBase<T> where T : IDevice
{
    protected override bool Filter(T device)
    {
        return !string.IsNullOrWhiteSpace(device.DeviceName);
    }
}