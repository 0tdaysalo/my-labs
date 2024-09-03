using System.Collections;


class Shuttle : IComparable<Shuttle>, IEnumerable
{
    private List<Shuttle> shuttles = new List<Shuttle>();

    public void Add(Shuttle shuttle)
    {
        shuttles.Add(shuttle);
    }

    public IEnumerator GetEnumerator()
    {
        foreach (Shuttle shuttle in shuttles)
        {
            yield return shuttle;
        }
    }

    int IComparable<Shuttle>.CompareTo(Shuttle? other)
    {
        throw new NotImplementedException();
    }
}