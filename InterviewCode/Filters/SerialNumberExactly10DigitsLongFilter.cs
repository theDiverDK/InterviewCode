using InterviewCode.Device;
using InterviewCode.Filters.Generics;

namespace InterviewCode.Filters;

public class SerialNumberExactly10DigitsLongFilter<T> : FilterBase<T> where T : IDevice
{
    protected override bool Filter(T device)
    {
        return device.SerialNumber.ToString().Length == 10;
    }
}