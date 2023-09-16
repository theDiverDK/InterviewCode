using InterviewCode.Device;
using InterviewCode.Filters.Generics;

namespace InterviewCode.Filters;

public class DeviceNameAtLeast1LongFilter<T> : IFilter<T> where T : IDevice
{
    public IEnumerable<T> Apply(IEnumerable<T> items)
    {
        return items.Where(Filter);
    }

    private bool Filter(T device)
    {
        return !string.IsNullOrWhiteSpace(device.DeviceName);
    }
}