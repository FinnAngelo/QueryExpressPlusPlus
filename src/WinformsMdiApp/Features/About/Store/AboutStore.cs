namespace WinformsMdiApp.Features.About.Store;

public record AboutState
{
    public string ProductName { get; init; }
    public Version Version { get; init; }
    public string Copyright { get; init; }
    public string CompanyName { get; init; }
    public string Description { get; init; }
}
