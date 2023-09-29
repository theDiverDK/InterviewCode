using InterviewCode.Device;
using InterviewCode.Filters.Generics;

namespace InterviewCode.Filters;

public class SerialNumberStartsWith9Filter<T> : FilterBase<T> where T : IDevice
{
    protected override bool Filter(T device)
    {
        var serialNumber = device.SerialNumber.ToString();
        return serialNumber.StartsWith("9");
    }
}