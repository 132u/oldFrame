﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18408
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Spec.Subscription
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Validation")]
    [NUnit.Framework.CategoryAttribute("Validation")]
    public partial class ValidationFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Validation.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Validation", "", ProgrammingLanguage.CSharp, new string[] {
                        "Validation"});
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Email Validation -Invalid values")]
        [NUnit.Framework.CategoryAttribute("hedgefundintelligence.com")]
        [NUnit.Framework.TestCaseAttribute("123first@s.we1p", null)]
        [NUnit.Framework.TestCaseAttribute("123first@s.wepok", null)]
        [NUnit.Framework.TestCaseAttribute("123firstshsdh8989dshsdhdfhdfs.we", null)]
        public virtual void EmailValidation_InvalidValues(string invalidEmailValue, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "hedgefundintelligence.com"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Email Validation -Invalid values", @__tags);
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given(string.Format("I fill \"{0}\" in email field, press Next button", invalidEmailValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.Then("warnings appears", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Email Validation -Empty email")]
        [NUnit.Framework.CategoryAttribute("hedgefundintelligence.com")]
        public virtual void EmailValidation_EmptyEmail()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Email Validation -Empty email", new string[] {
                        "hedgefundintelligence.com"});
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given("I don\'t type value in email field, press Next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.Then("warning message that email and compare email are empty appears", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Textbox Validation -Invalid values")]
        [NUnit.Framework.CategoryAttribute("hedgefundintelligence.com")]
        [NUnit.Framework.TestCaseAttribute("όμικρον№%", "FirstName", null)]
        [NUnit.Framework.TestCaseAttribute("1Test", "FirstName", null)]
        [NUnit.Framework.TestCaseAttribute("\"άλφα", "FirstName", null)]
        [NUnit.Framework.TestCaseAttribute("όμικρον№%", "LastName", null)]
        [NUnit.Framework.TestCaseAttribute("1Test", "LastName", null)]
        [NUnit.Framework.TestCaseAttribute("\"άλφα", "LastName", null)]
        [NUnit.Framework.TestCaseAttribute("-άλφα", "CompanyName", null)]
        public virtual void TextboxValidation_InvalidValues(string invalidValue, string field, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "hedgefundintelligence.com"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Textbox Validation -Invalid values", @__tags);
#line 22
this.ScenarioSetup(scenarioInfo);
#line 23
 testRunner.Given("I\'m on the AU Subscribe page and select 1st package", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
 testRunner.When(string.Format("I fill \"{0}\" in \"{1}\", press Next button", invalidValue, field), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then(string.Format("Warning message for \"{0}\" appears", field), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Textbox Validation -Empty values")]
        [NUnit.Framework.CategoryAttribute("hedgefundintelligence.com")]
        [NUnit.Framework.TestCaseAttribute("FirstName", null)]
        [NUnit.Framework.TestCaseAttribute("LastName", null)]
        [NUnit.Framework.TestCaseAttribute("CompanyName", null)]
        [NUnit.Framework.TestCaseAttribute("Zip", null)]
        [NUnit.Framework.TestCaseAttribute("City", null)]
        public virtual void TextboxValidation_EmptyValues(string field, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "hedgefundintelligence.com"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Textbox Validation -Empty values", @__tags);
#line 37
this.ScenarioSetup(scenarioInfo);
#line 38
 testRunner.Given("I\'m on the AU Subscribe page and select 1st package", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
 testRunner.When(string.Format("I don\'t fill  in \"{0}\", press Next button", field), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.Then(string.Format("Warning message empty value for \"{0}\" appears", field), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
