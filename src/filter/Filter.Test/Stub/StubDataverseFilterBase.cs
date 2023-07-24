namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

internal sealed record class StubDataverseFilterBase : DataverseFilterBase
{
    private readonly string query;

    internal StubDataverseFilterBase(string query)
        =>
        this.query = query;

    public override string GetQuery()
        =>
        query;

    public override string ToString()
        =>
        base.ToString();
}