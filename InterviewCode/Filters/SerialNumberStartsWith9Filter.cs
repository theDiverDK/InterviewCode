using InterviewCode.Device;
using InterviewCode.Filters.Generics;

namespace InterviewCode.Filters;

public class SerialNumberStartsWith9Filter<T> : IFilter<T> where T : IDevice
{
    public IEnumerable<T> Apply(IEnumerable<T> items)
    {
        return items.Where(Filter);
    }

    private bool Filter(T device)
    {
        var serialNumber = device.SerialNumber.ToString();
        return serialNumber.StartsWith("9");
    }
}