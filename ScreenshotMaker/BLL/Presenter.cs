using System;
using System.Collections.Generic;
using ScreenshotMaker.PrL;

namespace ScreenshotMaker.BLL
{
	internal class Presenter : IPresenter
	{
		public Presenter()
		{
			Items = new Tree<IPresenterItem>();
		}

		public IView View { private get; set; }

		public Tree<IPresenterItem> Items { get; }

		private TestCase _testCase;

		public void ChangeTestExecution()
		{
			throw new NotImplementedException();
		}

		public void ChangeOutputFolder()
		{
			throw new NotImplementedException();
		}

		public void OpenFile()
		{
			try
			{
				_testCase = TestCaseFromXmlLoader.Load(View.GetInputFileName());
			}
			catch (Exception exception)
			{
				View.ShowMessage("Can't open file: " + exception.Message);
				return;
			}

//			View.ShowMessage("File is successfully opened");

			_testCase.ExecutionIdAndTitle = View.GetTestExecutionName();

			Items.Clear();
			Items.Value = new PresenterSimpleItem("Execution: " + _testCase.ExecutionIdAndTitle);
			Items.Add(TreeFromCase(_testCase));

			View.RefreshTreeStructure();
			View.RefreshData();
		}

		private Tree<IPresenterItem> TreeFromCase(TestCase testCase)
		{
			var tree = new Tree<IPresenterItem>();
			tree.Value = new PresenterSimpleItem("Case: " + testCase.IdAndTitle);
			tree.Add(TreeFromSetups(testCase.Setups));
			for (int i = 0; i < testCase.Verifications.Count; i++)
				tree.Add(TreeFromVerification(testCase.Verifications[i], i));
			
			return tree;
		}

		private Tree<IPresenterItem> TreeFromVerification(Verification verification, int verificationNum)
		{
			var tree = new Tree<IPresenterItem>();
			tree.Value = new PresenterSimpleItem("Verification " + verification.Number);
			tree.Add(TreeFromListOfData(verification.Data, verificationNum));
			tree.Add(TreeFromSteps(verification.Steps, verificationNum));
			return tree;
		}

		private Tree<IPresenterItem> TreeFromSteps(List<Step> steps, int verificationNum)
		{
			var tree = new Tree<IPresenterItem>();
			tree.Value = new PresenterSimpleItem("Steps");
			for (int i = 0; i < steps.Count; i++)
				tree.Add(TreeFromStep(steps[i], verificationNum, i));
			return tree;
		}

		private Tree<IPresenterItem> TreeFromStep(Step step, int verificationNum, int stepNum)
		{
			var tree = new Tree<IPresenterItem>();
			tree.Value = new PresenterSimpleItem(step.Number + ". " + step.Text);
			for (int i = 0; i < step.Results.Count; i++)
				tree.Add(SelectableItemFromTestCaseItem(new TestCase.ItemCoordinates(TestCase.ItemTypes.StepResult, verificationNum, stepNum, i)));
			return tree;
		}

		private Tree<IPresenterItem> SelectableItemFromTestCaseItem(TestCase.ItemCoordinates coordinates)
		{
			var tree = new Tree<IPresenterItem>();
			tree.Value = new PresenterSelectableItem(_testCase, coordinates, View);
			return tree;
		}

		private Tree<IPresenterItem> TreeFromListOfData(List<Data> listOfData, int verificationNum)
		{
			var tree = new Tree<IPresenterItem>();
			tree.Value = new PresenterSimpleItem("Data");
			for (int i = 0; i < listOfData.Count; i++)
				tree.Add(SelectableItemFromTestCaseItem(new TestCase.ItemCoordinates(TestCase.ItemTypes.Data, verificationNum, i)));
			return tree;
		}

		private Tree<IPresenterItem> TreeFromSetups(List<Setup> setups)
		{
			var tree = new Tree<IPresenterItem>();
			tree.Value = new PresenterSimpleItem("Preconditions");
			for (int i = 0; i < setups.Count; i++)
				tree.Add(SelectableItemFromTestCaseItem(new TestCase.ItemCoordinates(TestCase.ItemTypes.Setup, i)));
			return tree;
		}
	}
}