﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18034
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BookShop.AcceptanceTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("US02 - Home Screen", new string[] {
            "automated"}, Description="As a potential customer\nI want to see the books with the best price\nSo that I can" +
        " save money on buying discounted books.", SourceFile="US02_HomeScreen.feature", SourceLine=1)]
    public partial class US02_HomeScreenFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "US02_HomeScreen.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "US02 - Home Screen", "As a potential customer\nI want to see the books with the best price\nSo that I can" +
                    " save money on buying discounted books.", ProgrammingLanguage.CSharp, new string[] {
                        "automated"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
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
#line 7
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Author",
                        "Title",
                        "Price"});
            table1.AddRow(new string[] {
                        "Martin Fowler",
                        "Analysis Patterns",
                        "50.20"});
            table1.AddRow(new string[] {
                        "Eric Evans",
                        "Domain Driven Design",
                        "46.34"});
            table1.AddRow(new string[] {
                        "Ted Pattison",
                        "Inside Windows SharePoint Services",
                        "31.49"});
            table1.AddRow(new string[] {
                        "Gojko Adzic",
                        "Bridging the Communication Gap",
                        "24.75"});
#line 8
 testRunner.Given("the following books", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Cheapest 3 books should be listed on the home screen", SourceLine=14)]
        public virtual void Cheapest3BooksShouldBeListedOnTheHomeScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cheapest 3 books should be listed on the home screen", ((string[])(null)));
#line 15
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 16
 testRunner.When("I enter the shop", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.Then("the home screen should show the book \'Bridging the Communication Gap\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
    testRunner.And("the home screen should show the book \'Inside Windows SharePoint Services\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 19
    testRunner.And("the home screen should show the book \'Domain Driven Design\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Cheapest 3 books should be listed on the home screen (list syntax)", new string[] {
                "alternative_syntax"}, SourceLine=21)]
        public virtual void Cheapest3BooksShouldBeListedOnTheHomeScreenListSyntax()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cheapest 3 books should be listed on the home screen (list syntax)", new string[] {
                        "alternative_syntax"});
#line 22
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 23
 testRunner.When("I enter the shop", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.Then("the home screen should show the books \'Bridging the Communication Gap\', \'Inside W" +
                    "indows SharePoint Services\', \'Domain Driven Design\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Cheapest 3 books should be listed on the home screen (table syntax)", new string[] {
                "alternative_syntax"}, SourceLine=26)]
        public virtual void Cheapest3BooksShouldBeListedOnTheHomeScreenTableSyntax()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cheapest 3 books should be listed on the home screen (table syntax)", new string[] {
                        "alternative_syntax"});
#line 27
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 28
 testRunner.When("I enter the shop", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title"});
            table2.AddRow(new string[] {
                        "Bridging the Communication Gap"});
            table2.AddRow(new string[] {
                        "Inside Windows SharePoint Services"});
            table2.AddRow(new string[] {
                        "Domain Driven Design"});
#line 29
 testRunner.Then("the home screen should show the following books", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
