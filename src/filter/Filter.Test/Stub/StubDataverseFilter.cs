namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

internal sealed record class StubDataverseFilter : IDataverseFilter
{
    private readonly string query;

    internal StubDataverseFilter(string query)
        =>
        this.query = query;

    public string GetQuery()
        =>
        query;
}