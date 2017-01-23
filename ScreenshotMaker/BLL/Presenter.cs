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
			foreach (Verification verification in testCase.Verifications)
				tree.Add(TreeFromVerification(verification));
			
			return tree;
		}

		private Tree<IPresenterItem> TreeFromVerification(Verification verification)
		{
			var tree = new Tree<IPresenterItem>();
			tree.Value = new PresenterSimpleItem("Verification " + verification.Number);
			tree.Add(TreeFromListOfData(verification.Data));
			tree.Add(TreeFromSteps(verification.Steps));
			return tree;
		}

		private Tree<IPresenterItem> TreeFromSteps(List<Step> steps)
		{
			var tree = new Tree<IPresenterItem>();
			tree.Value = new PresenterSimpleItem("Steps");
			foreach (Step step in steps)
				tree.Add(TreeFromStep(step));
			return tree;
		}

		private Tree<IPresenterItem> TreeFromStep(Step step)
		{
			var tree = new Tree<IPresenterItem>();
			tree.Value = new PresenterSimpleItem(step.Number + ". " + step.Text);
			foreach (StepResult result in step.Results)
				tree.Add(SelectableItemFromTestCaseItem(result));
			return tree;
		}

		private Tree<IPresenterItem> SelectableItemFromTestCaseItem(TestCaseItem testCaseItem)
		{
			var tree = new Tree<IPresenterItem>();
			tree.Value = new PresenterSelectableItem(testCaseItem, View);
			return tree;
		}

		private Tree<IPresenterItem> TreeFromListOfData(List<Data> listOfData)
		{
			var tree = new Tree<IPresenterItem>();
			tree.Value = new PresenterSimpleItem("Data");
			foreach (Data data in listOfData)
				tree.Add(SelectableItemFromTestCaseItem(data));
			return tree;
		}

		private Tree<IPresenterItem> TreeFromSetups(List<Setup> setups)
		{
			var tree = new Tree<IPresenterItem>();
			tree.Value = new PresenterSimpleItem("Preconditions");
			foreach (Setup setup in setups)
				tree.Add(SelectableItemFromTestCaseItem(setup));
			return tree;
		}
	}
}