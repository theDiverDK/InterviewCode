using InterviewCode.Device;
using InterviewCode.Filters.Generics;

namespace InterviewCode.Filters;

public class EmptyDeviceNameFilter<T> : FilterBase<T> where T : IDevice
{
    protected override bool Filter(T device)
    {
        return string.IsNullOrEmpty(device.DeviceName);
    }
}