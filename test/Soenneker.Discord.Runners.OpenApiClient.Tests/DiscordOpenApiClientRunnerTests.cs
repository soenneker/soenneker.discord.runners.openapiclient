using Soenneker.Tests.HostedUnit;

namespace Soenneker.Discord.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class DiscordOpenApiClientRunnerTests : HostedUnitTest
{
    public DiscordOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
