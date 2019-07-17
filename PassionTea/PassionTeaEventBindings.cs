using PassionTea.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PassionTea
{
    [Binding]
    public class PassionTeaEventBindings
    {
        

        [BeforeTestRun]
        public void BeforeTestRun()
        {
            SeleniumExecutor.Initialize();
            FileHelper.DeleteScreenshotFolder();
        }

        [AfterTestRun]
        public void AfterTestRun()
        {
            SeleniumExecutor.Driver().Close();
        }
        [AfterStep]
        public static void AfterStep()
        {
            if(ScenarioContext.Current.TestError!=null)
            {
                var featureTitle = TestRunnerManager.GetTestRunner().FeatureContext.FeatureInfo.Title;
                var scenarioTitle = TestRunnerManager.GetTestRunner().ScenarioInfo.Title;
                var fileName = $@"{featureTitle}--{scenarioTitle}";
                SeleniumExecutor.TakeScreenshot(fileName);
            }
        }
    }
}
