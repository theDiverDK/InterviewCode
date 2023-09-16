using InterviewCode.Device;
using InterviewCode.Filters.Generics;

namespace InterviewCode.Filters;

public class SerialNumberExactly10DigitsLongFilter<T> : IFilter<T> where T : IDevice
{
    public IEnumerable<T> Apply(IEnumerable<T> items)
    {
        return items.Where(Filter);
    }

    private bool Filter(T device)
    {
        return device.SerialNumber.ToString().Length == 10 &&
               !string.IsNullOrWhiteSpace(device.DeviceName);
    }
}