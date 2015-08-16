using System;
using System.IO;
using ConsoleTwitter;
using TechTalk.SpecFlow;

namespace AcceptanceTests.Steps
{
    [Binding]
    public class FollowingUsersSteps
    {
        [Given(@"I am on Console Twitter")]
        public void GivenIAmOnConsoleTwitter()
        {           
            Program.Main();
        }

        [When(@"I enter ""(.*)""")]
        public void WhenIEnter(string command)
        {
            var sr = new StringReader(command);
            Console.SetIn(sr);
        }

        [Then(@"""(.*)"" should be added to Alice's timeline")]
        public void ThenShouldBeAddedToAliceSTimeline(string message)
        {
            var sw = new StringWriter();
            Console.SetOut(sw);

            sw.Equals(message);
        }

        [When(@"Charlie follows Alice")]
        public void WhenCharlieFollowsAlice()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Charlie wants to see his wall")]
        public void WhenCharlieWantsToSeeHisWall()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Charlie follows Bob")]
        public void WhenCharlieFollowsBob()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"he should see both his own and Alice's wall\.")]
        public void ThenHeShouldSeeBothHisOwnAndAliceSWall_()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"he should see both his own, Alice'(.*)'s wall\.")]
        public void ThenHeShouldSeeBothHisOwnAliceSWall_(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
