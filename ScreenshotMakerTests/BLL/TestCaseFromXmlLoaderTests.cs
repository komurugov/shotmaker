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
		[TestMethod()]
		public void Dto2TestCaseTest()
		{
			var dto = new rss
			{
				channel = new rssChannel
				{
					item = new rssChannelItem
					{
						title = "[ID] Title",
						customfields = new rssChannelItemCustomfield[2]
						{
							new rssChannelItemCustomfield
							{
								customfieldname = "Setup",
								customfieldvalues = new rssChannelItemCustomfieldCustomfieldvalues
								{
									customfieldvalue = "- setup item 1 <br/> - setup item 2"
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
												Text = "v1 data item 1 <br/> v1 data item 2"
											},
											step = new rssChannelItemCustomfieldCustomfieldvaluesStepStep
											{
												Text = "<p> 1. v1 step 1 <br/> 2. v1 step 2 </p>"
											},
											result = new rssChannelItemCustomfieldCustomfieldvaluesStepResult
											{
												Text = "<ul><li>Step 1. result 1 for v1 step 1</li><li>Step 2. result 1 for v1 step 2</li></ul>"
											}
										},
										new rssChannelItemCustomfieldCustomfieldvaluesStep
										{
											data = new rssChannelItemCustomfieldCustomfieldvaluesStepData
											{
												Text = "v2 data item 1 <br/> v2 data item 2"
											},
											step = new rssChannelItemCustomfieldCustomfieldvaluesStepStep
											{
												Text = "<p> 1. v2 step 1 <br/> 2. v2 step 2 </p>"
											},
											result = new rssChannelItemCustomfieldCustomfieldvaluesStepResult
											{
												Text = "<ul><li>Step 1. result 1 for v2 step 1</li><li>Step 2. result 1 for v2 step 2</li></ul>"
											}
										}
									}
								}
							}
						}
					}
				}
			};

			TestCase testCase = TestCaseFromXmlLoader.Dto2TestCase(dto);

			Assert.IsTrue(testCase.IdAndTitle == "ID-Title");
			Assert.IsTrue(testCase.Setups[0].Text == "- setup item 1 ");
			Assert.IsTrue(testCase.Setups[1].Text == "- setup item 2");
			Assert.IsTrue(testCase.Verifications[0].Data[0].Text == "v1 data item 1 ");
			//Assert.IsTrue(testCase.Verifications[0].Data[0].Status == Status.None);
			//Assert.IsTrue(testCase.Verifications[0].Data[0].Result == Result.Unknown);
			//Assert.IsTrue(testCase.Verifications[0].Steps[0].Text == " 1. v1 step 1 ");
		}
	}
}