namespace InterviewCode.Filters.Generics;

public interface IFilter<T>
{
    IEnumerable<T> Apply(IEnumerable<T> source);
}