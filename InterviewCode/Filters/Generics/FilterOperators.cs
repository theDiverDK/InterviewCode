using InterviewCode.Device;

namespace InterviewCode.Filters.Generics;

public static class FilterOperators
{
    public static IEnumerable<T> ApplyEmptyDeviceNameFilter<T>(this IEnumerable<T> source) where T : IDevice
    {
        return new EmptyDeviceNameFilter<T>().Apply(source);
    }

    public static IEnumerable<T> ApplySerialNumberExactly10DigitLongFilter<T>(this IEnumerable<T> source) where T : IDevice
    {
        return new SerialNumberExactly10DigitsLongFilter<T>().Apply(source);
    }

    public static IEnumerable<T> ApplyDeviceNameAtLeast1LongFilter<T>(this IEnumerable<T> source) where T : IDevice
    {
        return new DeviceNameAtLeast1LongFilter<T>().Apply(source);
    }

    public static IEnumerable<T> ApplySerialNumberStartsWith9Filter<T>(this IEnumerable<T> source) where T : IDevice
    {
        return new SerialNumberStartsWith9Filter<T>().Apply(source);
    }
}