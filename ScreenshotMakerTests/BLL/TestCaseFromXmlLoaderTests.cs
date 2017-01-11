using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScreenshotMaker.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenshotMaker.DAL;

namespace ScreenshotMaker.BLL.Tests
{
	[TestClass()]
	public class TestCaseFromXmlLoaderTests
	{
		private bool IsNewTestCaseItemCorrect(TestCaseItem item, string correctText)
		{
			return item.Text == correctText && item.Status == Status.None && item.Result == Result.Unknown;
		}

		[TestMethod()]
		public void Dto2TestCaseTest()
		{
			const string stringID = "ID";
			const string stringTitle = "Title";
			const string stringSetup0 = "- setup item 1 ";
			const string stringSetup1 = "- setup item 2";
			const string stringVerification0Data0 = "v1 data item 1 ";
			const string stringVerification0Data1 = "v1 data item 2";
			const string stringVerification0Step0 = "v1 step 1 ";
			const string stringVerification0Step0Result0 = "result 1 for v1 step 1";
			const string stringVerification0Step1 = "v1 step 2";
			const string stringVerification0Step1Result0 = "result 1 for v1 step 2";
			const string stringVerification1Data0 = "v2 data item 1 ";
			const string stringVerification1Data1 = "v2 data item 2";
			const string stringVerification1Step0 = "v2 step 1 ";
			const string stringVerification1Step0Result0 = "result 1 for v2 step 1";
			const string stringVerification1Step1 = "v2 step 2";
			const string stringVerification1Step1Result0 = "result 1 for v2 step 2";

			var dto = new rss
			{
				channel = new rssChannel
				{
					item = new rssChannelItem
					{
						title = "[" + stringID + "] " + stringTitle,
						customfields = new rssChannelItemCustomfield[2]
						{
							new rssChannelItemCustomfield
							{
								customfieldname = "Setup",
								customfieldvalues = new rssChannelItemCustomfieldCustomfieldvalues
								{
									customfieldvalue = stringSetup0 + "<br/>" + stringSetup1
								}
							},
							new rssChannelItemCustomfield
							{
								customfieldname = "Manual Test Steps",
								customfieldvalues = new rssChannelItemCustomfieldCustomfieldvalues
								{
									steps = new rssChannelItemCustomfieldCustomfieldvaluesStep[2]
									{
										new rssChannelItemCustomfieldCustomfieldvaluesStep
										{
											data = new rssChannelItemCustomfieldCustomfieldvaluesStepData
											{
												Text = stringVerification0Data0 + "<br/>" + stringVerification0Data1
											},
											step = new rssChannelItemCustomfieldCustomfieldvaluesStepStep
											{
												Text = "<p> 1. " + stringVerification0Step0 + "<br/> 2. " + stringVerification0Step1 + "</p>"
											},
											result = new rssChannelItemCustomfieldCustomfieldvaluesStepResult
											{
												Text = "<ul><li>Step 1. " + stringVerification0Step0Result0 + "</li><li>Step 2. " + stringVerification0Step1Result0 + "</li></ul>"
											}
										},
										new rssChannelItemCustomfieldCustomfieldvaluesStep
										{
											data = new rssChannelItemCustomfieldCustomfieldvaluesStepData
											{
												Text = stringVerification1Data0 + "<br/>" + stringVerification1Data1
											},
											step = new rssChannelItemCustomfieldCustomfieldvaluesStepStep
											{
												Text = "<p> 1. " + stringVerification1Step0 + "<br/> 2. " + stringVerification1Step1 + "</p>"
											},
											result = new rssChannelItemCustomfieldCustomfieldvaluesStepResult
											{
												Text = "<ul><li>Step 1. " + stringVerification1Step0Result0 + "</li><li>Step 2. " + stringVerification1Step1Result0 + "</li></ul>"
											}
										}
									}
								}
							}
						}
					}
				}
			};

			TestCase testCase = Dto2TestCaseConverter.ConvertDto2TestCase(dto);

			Assert.IsTrue(testCase.IdAndTitle == stringID + "-" + stringTitle);
			Assert.IsTrue(testCase.Setups[0].Text == stringSetup0);
			Assert.IsTrue(testCase.Setups[1].Text == stringSetup1);
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[0].Data[0], stringVerification0Data0));
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[0].Data[1], stringVerification0Data1));
			Assert.IsTrue(testCase.Verifications[0].Steps[0].Text == stringVerification0Step0);
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[0].Steps[0].Results[0], stringVerification0Step0Result0));
			Assert.IsTrue(testCase.Verifications[0].Steps[1].Text == stringVerification0Step1);
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[0].Steps[1].Results[0], stringVerification0Step1Result0));
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[1].Data[0], stringVerification1Data0));
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[1].Data[1], stringVerification1Data1));
			Assert.IsTrue(testCase.Verifications[1].Steps[0].Text == stringVerification1Step0);
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[1].Steps[0].Results[0], stringVerification1Step0Result0));
			Assert.IsTrue(testCase.Verifications[1].Steps[1].Text == stringVerification1Step1);
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[1].Steps[1].Results[0], stringVerification1Step1Result0));
		}
	}
}