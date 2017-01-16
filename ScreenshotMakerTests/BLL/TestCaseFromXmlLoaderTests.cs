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

		private void Dto2TestCaseTest1()
		{
			const string stringID = "ID";
			const string stringTitle = "Title";
			const string stringSetup0 = "- setup item 1 ";
			const string stringSetup1 = "- setup item 2";
			const int indexVerification0 = 1;
			const string stringVerification0Data0 = "v1 data item 1 ";
			const string stringVerification0Data1 = "v1 data item 2";
			const string stringVerification0Step0 = "v1 step 1 ";
			const string stringVerification0Step0Result0 = "result 1 for v1 step 1";
			const string stringVerification0Step1 = "v1 step 2";
			const string stringVerification0Step1Result0 = "result 1 for v1 step 2";
			const int indexVerification1 = 3;
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
											index = indexVerification0,
											data = new rssChannelItemCustomfieldCustomfieldvaluesStepData
											{
												Text = stringVerification0Data0
												+ "<br/>" + stringVerification0Data1
											},
											step = new rssChannelItemCustomfieldCustomfieldvaluesStepStep
											{
												Text = "<p> 1. " + stringVerification0Step0
												+ "<br/> 2. " + stringVerification0Step1 + "</p>"
											},
											result = new rssChannelItemCustomfieldCustomfieldvaluesStepResult
											{
												Text = "<ul><li>Step 1. " + stringVerification0Step0Result0
												+ "</li><li>Step 2. " + stringVerification0Step1Result0 + "</li></ul>"
											}
										},
										new rssChannelItemCustomfieldCustomfieldvaluesStep
										{
											index = indexVerification1,
											data = new rssChannelItemCustomfieldCustomfieldvaluesStepData
											{
												Text = stringVerification1Data0
												+ "<br/>" + stringVerification1Data1
											},
											step = new rssChannelItemCustomfieldCustomfieldvaluesStepStep
											{
												Text = "<p> 1. " + stringVerification1Step0
												+ "<br/> 2. " + stringVerification1Step1 + "</p>"
											},
											result = new rssChannelItemCustomfieldCustomfieldvaluesStepResult
											{
												Text = "<ul><li>Step 1. " + stringVerification1Step0Result0
												+ "</li><li>Step 2. " + stringVerification1Step1Result0 + "</li></ul>"
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
			Assert.IsTrue(testCase.Setups.Count == 2);
			Assert.IsTrue(testCase.Setups[0].Text == stringSetup0);
			Assert.IsTrue(testCase.Setups[1].Text == stringSetup1);
			Assert.IsTrue(testCase.Verifications.Count == 2);
			Assert.IsTrue(testCase.Verifications[0].Number == indexVerification0);
			Assert.IsTrue(testCase.Verifications[0].Data.Count == 2);
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[0].Data[0], stringVerification0Data0));
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[0].Data[1], stringVerification0Data1));
			Assert.IsTrue(testCase.Verifications[0].Steps.Count == 2);
			Assert.IsTrue(testCase.Verifications[0].Steps[0].Text == stringVerification0Step0);
			Assert.IsTrue(testCase.Verifications[0].Steps[0].Results.Count == 1);
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[0].Steps[0].Results[0], stringVerification0Step0Result0));
			Assert.IsTrue(testCase.Verifications[0].Steps[1].Text == stringVerification0Step1);
			Assert.IsTrue(testCase.Verifications[0].Steps[1].Results.Count == 1);
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[0].Steps[1].Results[0], stringVerification0Step1Result0));
			Assert.IsTrue(testCase.Verifications[1].Number == indexVerification1);
			Assert.IsTrue(testCase.Verifications[1].Data.Count == 2);
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[1].Data[0], stringVerification1Data0));
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[1].Data[1], stringVerification1Data1));
			Assert.IsTrue(testCase.Verifications[1].Steps.Count == 2);
			Assert.IsTrue(testCase.Verifications[1].Steps[0].Text == stringVerification1Step0);
			Assert.IsTrue(testCase.Verifications[1].Steps[0].Results.Count == 1);
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[1].Steps[0].Results[0], stringVerification1Step0Result0));
			Assert.IsTrue(testCase.Verifications[1].Steps[1].Text == stringVerification1Step1);
			Assert.IsTrue(testCase.Verifications[1].Steps[1].Results.Count == 1);
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[1].Steps[1].Results[0], stringVerification1Step1Result0));
		}

		private void Dto2TestCaseTest2()
		{
			const string stringID = "ID";
			const string stringTitle = "Title";
			const string stringSetup0 = "&nbsp;- OLSS Workstation 2.2";
			const string stringSetup1 = "";
			const int indexVerification0 = 0;
			const string stringVerification0Data0 = "v1 data item 1 ";
			const string stringVerification0Data1 = "v1 data item 2";
			const string stringVerification0Data2 = "v1 data item 3";
			const string stringVerification0Step0Line0 = "v1 step 1 line 1";
			const string stringVerification0Step0Line1 = "v1 step 1 line 2";
			const string stringVerification0Step0Result0 = "result 1 for v1 step 1";
			const string stringVerification0Step0Result1 = "result 2 for v1 step 1";
			const string stringVerification0Step1 = "v1 step 2";
			const string stringVerification0Step1Result0 = "result 1 for v1 step 2";
			const string stringVerification0Step2 = "v1 step 3";
			const string stringVerification0Step2Result0 = "result 1 for v1 step 3";
			const string stringVerification0Step2Result1 = "result 2 for v1 step 3";
			const string stringVerification0Step2Result2 = "result 3 for v1 step 3";
			const string stringVerification0Step2Result3 = "result 4 for v1 step 3";

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
									customfieldvalue = stringSetup0
									+ "<br/>" + stringSetup1
								}
							},
							new rssChannelItemCustomfield
							{
								customfieldname = "Manual Test Steps",
								customfieldvalues = new rssChannelItemCustomfieldCustomfieldvalues
								{
									steps = new rssChannelItemCustomfieldCustomfieldvaluesStep[1]
									{
										new rssChannelItemCustomfieldCustomfieldvaluesStep
										{
											index = indexVerification0,
											data = new rssChannelItemCustomfieldCustomfieldvaluesStepData
											{
												Text = "<p>" + stringVerification0Data0
												+ "</p><ul type=\"square\" class=\"alternate\"><li>" + stringVerification0Data1
												+ "</li><li>" + stringVerification0Data2 + "</li></ul>"
											},
											step = new rssChannelItemCustomfieldCustomfieldvaluesStepStep
											{
												Text = "<p> 1. " + stringVerification0Step0Line0
												+ "<br/>" + stringVerification0Step0Line1
												+ "<br/> 2. " + stringVerification0Step1
												+ "</p><p>3." + stringVerification0Step2 + "</p>"
											},
											result = new rssChannelItemCustomfieldCustomfieldvaluesStepResult
											{
												Text = "<p>1." 
												+ "</p><p>" + stringVerification0Step0Result0
												+ "</p><p>" + stringVerification0Step0Result1
												+ "</p><p>2 -" + stringVerification0Step1Result0
												+ "</p><ul><li> 3:" + stringVerification0Step2Result0
												+ "</li><li>" + stringVerification0Step2Result1
												+ "</li><br/>" + stringVerification0Step2Result2
												+ "<br/>" + stringVerification0Step2Result3
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
			Assert.IsTrue(testCase.Setups.Count == 1);
			Assert.IsTrue(testCase.Setups[0].Text == stringSetup0);
			Assert.IsTrue(testCase.Verifications.Count == 1);
			Assert.IsTrue(testCase.Verifications[0].Number == indexVerification0);
			Assert.IsTrue(testCase.Verifications[0].Data.Count == 3);
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[0].Data[0], stringVerification0Data0));
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[0].Data[1], stringVerification0Data1));
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[0].Data[2], stringVerification0Data2));
			Assert.IsTrue(testCase.Verifications[0].Steps.Count == 3);
			Assert.IsTrue(testCase.Verifications[0].Steps[0].Text == stringVerification0Step0Line0 + "\n" + stringVerification0Step0Line1);
			Assert.IsTrue(testCase.Verifications[0].Steps[0].Results.Count == 2);
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[0].Steps[0].Results[0], stringVerification0Step0Result0));
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[0].Steps[0].Results[1], stringVerification0Step0Result1));
			Assert.IsTrue(testCase.Verifications[0].Steps[1].Text == stringVerification0Step1);
			Assert.IsTrue(testCase.Verifications[0].Steps[1].Results.Count == 1);
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[0].Steps[1].Results[0], stringVerification0Step1Result0));
			Assert.IsTrue(testCase.Verifications[0].Steps[2].Text == stringVerification0Step2);
			Assert.IsTrue(testCase.Verifications[0].Steps[2].Results.Count == 4);
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[0].Steps[2].Results[0], stringVerification0Step2Result0));
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[0].Steps[2].Results[1], stringVerification0Step2Result1));
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[0].Steps[2].Results[2], stringVerification0Step2Result2));
			Assert.IsTrue(IsNewTestCaseItemCorrect(testCase.Verifications[0].Steps[2].Results[3], stringVerification0Step2Result3));
		}

		[TestMethod()]
		public void Dto2TestCaseTest()
		{
			Dto2TestCaseTest1();
			Dto2TestCaseTest2();
		}
	}
}