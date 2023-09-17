using InterviewCode.Device;
using InterviewCode.Filters.Generics;

namespace InterviewCode.Filters;

public class DeviceNameAtLeast1LongFilter<T> : FilterBase<T> where T : IDevice
{
    protected override IEnumerable<T> ApplyFilter(IEnumerable<T> items)
    {
        return items.Where(Filter);
    }

    private bool Filter(T device)
    {
        return !string.IsNullOrWhiteSpace(device.DeviceName);
    }
}