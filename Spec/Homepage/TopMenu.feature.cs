﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Spec.Homepage
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TopMenu")]
    [NUnit.Framework.CategoryAttribute("TopMenu")]
    public partial class TopMenuFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TopMenu.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "TopMenu", "I want to be able to access every link on the top menu bar.", ProgrammingLanguage.CSharp, new string[] {
                        "TopMenu"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
#line 6
testRunner.Given("I\'m on the Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display News page")]
        [NUnit.Framework.CategoryAttribute("emergingmarkets.org")]
        [NUnit.Framework.CategoryAttribute("hedgefundintelligence.com")]
        public virtual void TopMenu_ShouldDisplayNewsPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display News page", new string[] {
                        "emergingmarkets.org",
                        "hedgefundintelligence.com"});
#line 9
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 10
testRunner.When("I enter News page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
testRunner.Then("News page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display Sectors page")]
        [NUnit.Framework.CategoryAttribute("globaltelecomsbusiness.com")]
        public virtual void TopMenu_ShouldDisplaySectorsPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display Sectors page", new string[] {
                        "globaltelecomsbusiness.com"});
#line 14
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 15
testRunner.When("I enter Sectors page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
testRunner.Then("Sectors page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display Interviews page")]
        [NUnit.Framework.CategoryAttribute("globaltelecomsbusiness.com")]
        public virtual void TopMenu_ShouldDisplayInterviewsPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display Interviews page", new string[] {
                        "globaltelecomsbusiness.com"});
#line 19
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 20
testRunner.When("I enter Interviews page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
testRunner.Then("Interviews page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display CFOs page")]
        [NUnit.Framework.CategoryAttribute("globaltelecomsbusiness.com")]
        public virtual void TopMenu_ShouldDisplayCFOsPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display CFOs page", new string[] {
                        "globaltelecomsbusiness.com"});
#line 24
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 25
testRunner.When("I enter CFOs page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
testRunner.Then("CFOs page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display CMOs page")]
        [NUnit.Framework.CategoryAttribute("globaltelecomsbusiness.com")]
        public virtual void TopMenu_ShouldDisplayCMOsPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display CMOs page", new string[] {
                        "globaltelecomsbusiness.com"});
#line 29
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 30
testRunner.When("I enter CMOs page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
testRunner.Then("CMOs page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display GTBTV page")]
        [NUnit.Framework.CategoryAttribute("globaltelecomsbusiness.com")]
        public virtual void TopMenu_ShouldDisplayGTBTVPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display GTBTV page", new string[] {
                        "globaltelecomsbusiness.com"});
#line 34
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 35
testRunner.When("I enter GTBTV page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
testRunner.Then("GTBTV page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display AboutUs page")]
        [NUnit.Framework.CategoryAttribute("globaltelecomsbusiness.com")]
        public virtual void TopMenu_ShouldDisplayAboutUsPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display AboutUs page", new string[] {
                        "globaltelecomsbusiness.com"});
#line 39
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 40
testRunner.When("I enter AboutUs page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
testRunner.Then("AboutUs page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display MyAccount page")]
        [NUnit.Framework.CategoryAttribute("globaltelecomsbusiness.com")]
        public virtual void TopMenu_ShouldDisplayMyAccountPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display MyAccount page", new string[] {
                        "globaltelecomsbusiness.com"});
#line 44
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 45
testRunner.When("I enter MyAccount page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
testRunner.Then("MyAccount page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display EM View page")]
        [NUnit.Framework.CategoryAttribute("emergingmarkets.org")]
        public virtual void TopMenu_ShouldDisplayEMViewPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display EM View page", new string[] {
                        "emergingmarkets.org"});
#line 49
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 50
testRunner.When("I enter EM View page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
testRunner.Then("EM View page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display Analysis page")]
        [NUnit.Framework.CategoryAttribute("emergingmarkets.org")]
        public virtual void TopMenu_ShouldDisplayAnalysisPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display Analysis page", new string[] {
                        "emergingmarkets.org"});
#line 55
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 56
testRunner.When("I enter Analysis page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
testRunner.Then("Analysis page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display Comment and Opinion page")]
        [NUnit.Framework.CategoryAttribute("emergingmarkets.org")]
        public virtual void TopMenu_ShouldDisplayCommentAndOpinionPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display Comment and Opinion page", new string[] {
                        "emergingmarkets.org"});
#line 60
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 61
testRunner.When("I enter Comment and Opinion page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
testRunner.Then("Comment And Opinion page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display Features page")]
        [NUnit.Framework.CategoryAttribute("emergingmarkets.org")]
        public virtual void TopMenu_ShouldDisplayFeaturesPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display Features page", new string[] {
                        "emergingmarkets.org"});
#line 65
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 66
testRunner.When("I enter Features page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
testRunner.Then("Features page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display Regions page")]
        [NUnit.Framework.CategoryAttribute("emergingmarkets.org")]
        public virtual void TopMenu_ShouldDisplayRegionsPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display Regions page", new string[] {
                        "emergingmarkets.org"});
#line 71
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 72
testRunner.When("I enter Regions page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
testRunner.Then("Regions page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display Americas page")]
        [NUnit.Framework.CategoryAttribute("emergingmarkets.org")]
        public virtual void TopMenu_ShouldDisplayAmericasPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display Americas page", new string[] {
                        "emergingmarkets.org"});
#line 76
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 77
testRunner.When("I enter Americas page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
testRunner.Then("Americas page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display Asia page")]
        [NUnit.Framework.CategoryAttribute("emergingmarkets.org")]
        public virtual void TopMenu_ShouldDisplayAsiaPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display Asia page", new string[] {
                        "emergingmarkets.org"});
#line 81
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 82
testRunner.When("I enter Asia page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
testRunner.Then("Asia page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display Emerging Europe page")]
        [NUnit.Framework.CategoryAttribute("emergingmarkets.org")]
        public virtual void TopMenu_ShouldDisplayEmergingEuropePage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display Emerging Europe page", new string[] {
                        "emergingmarkets.org"});
#line 86
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 87
testRunner.When("I enter Emerging Europe page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
testRunner.Then("Europe page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display Global page")]
        [NUnit.Framework.CategoryAttribute("emergingmarkets.org")]
        public virtual void TopMenu_ShouldDisplayGlobalPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display Global page", new string[] {
                        "emergingmarkets.org"});
#line 91
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 92
testRunner.When("I enter Global page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
testRunner.Then("Global page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display Middle East & Africa page")]
        [NUnit.Framework.CategoryAttribute("emergingmarkets.org")]
        public virtual void TopMenu_ShouldDisplayMiddleEastAfricaPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display Middle East & Africa page", new string[] {
                        "emergingmarkets.org"});
#line 96
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 97
testRunner.When("I enter Middle East & Africa page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
testRunner.Then("Middle East & Africa page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display Economics and Policy page")]
        [NUnit.Framework.CategoryAttribute("emergingmarkets.org")]
        public virtual void TopMenu_ShouldDisplayEconomicsAndPolicyPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display Economics and Policy page", new string[] {
                        "emergingmarkets.org"});
#line 102
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 103
testRunner.When("I enter Economics and Policy page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
testRunner.Then("Economics and Policy page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display Financial Markets page")]
        [NUnit.Framework.CategoryAttribute("emergingmarkets.org")]
        public virtual void TopMenu_ShouldDisplayFinancialMarketsPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display Financial Markets page", new string[] {
                        "emergingmarkets.org"});
#line 108
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 109
testRunner.When("I enter Financial Markets page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 110
testRunner.Then("Financial Markets page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display Development page")]
        [NUnit.Framework.CategoryAttribute("emergingmarkets.org")]
        public virtual void TopMenu_ShouldDisplayDevelopmentPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display Development page", new string[] {
                        "emergingmarkets.org"});
#line 114
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 115
testRunner.When("I enter Development page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 116
testRunner.Then("Development page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display Polls and Awards page")]
        [NUnit.Framework.CategoryAttribute("emergingmarkets.org")]
        public virtual void TopMenu_ShouldDisplayPollsAndAwardsPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display Polls and Awards page", new string[] {
                        "emergingmarkets.org"});
#line 120
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 121
testRunner.When("I enter Polls and Awards page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 122
testRunner.Then("Polls And Awards page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display Events page")]
        [NUnit.Framework.CategoryAttribute("emergingmarkets.org")]
        [NUnit.Framework.CategoryAttribute("petroleumeconomist.com")]
        [NUnit.Framework.CategoryAttribute("managingip.com")]
        public virtual void TopMenu_ShouldDisplayEventsPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display Events page", new string[] {
                        "emergingmarkets.org",
                        "petroleumeconomist.com",
                        "managingip.com"});
#line 125
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 126
testRunner.When("I enter Events page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 127
testRunner.Then("Events page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Top Menu - Should display Video page")]
        [NUnit.Framework.CategoryAttribute("emergingmarkets.org")]
        public virtual void TopMenu_ShouldDisplayVideoPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Top Menu - Should display Video page", new string[] {
                        "emergingmarkets.org"});
#line 130
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 131
testRunner.When("I enter Video page by top menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 132
testRunner.Then("Video page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
