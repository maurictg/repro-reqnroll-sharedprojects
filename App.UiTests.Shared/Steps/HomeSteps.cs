using Reqnroll;
using Shouldly;

namespace App.UiTests.Shared.Steps;

[Binding]
public class HomeSteps
{
    private bool _onHomePage;
    
    [Given("the user navigated to the home page")]
    public void GivenUserNavigatedHome()
    {
        _onHomePage = true;
    }

    [Then("the user is on the home page")]
    public void ThenUserIsHome()
    {
        _onHomePage.ShouldBeTrue();
    }
}