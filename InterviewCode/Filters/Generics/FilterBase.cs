using InterviewCode.Device;

namespace InterviewCode.Filters.Generics;

public abstract class FilterBase<T> : IFilter<T> where T : IDevice
{
    public IEnumerable<T> Apply(IEnumerable<T> items)
    {
        if (items == null)
        {
            throw new ArgumentNullException(nameof(items), "The 'items' parameter cannot be null.");
        }

        return ApplyFilter(items);
    }

    protected abstract IEnumerable<T> ApplyFilter(IEnumerable<T> items);
}