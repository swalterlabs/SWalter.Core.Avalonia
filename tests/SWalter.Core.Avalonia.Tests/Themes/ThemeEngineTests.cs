using SWalter.Core.Avalonia.Themes;
using SWalter.Testing.Avalonia;

namespace SWalter.Core.Avalonia.Tests.Themes;

public class ThemeEngineTests : AvaloniaTestBase<TestApp>
{
    [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    public void Constructor_HasNullGuards(GuardClauseAssertion assertion)
    {
        assertion.Verify(typeof(ThemeEngine).GetConstructors());
    }

    [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    public void Methods_HaveNullGuards(GuardClauseAssertion assertion)
    {
        assertion.Verify(typeof(ThemeEngine).GetMethods().Where(method => !method.IsAbstract));
    }
}