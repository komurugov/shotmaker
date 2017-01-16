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
			foreach (Verification verification in testCase.Verifications)
				tree.Add(TreeFromVerification(verification));
			
			return tree;
		}

		private Tree<IPresenterItem> TreeFromVerification(Verification verification)
		{
			var tree = new Tree<IPresenterItem>();
			tree.Value = new PresenterSimpleItem("Verification " + verification.Number);
			tree.Add(TreeFromListOfData(verification.Data));
			return tree;
		}

		private Tree<IPresenterItem> TreeFromListOfData(List<Data> listOfData)
		{
			var tree = new Tree<IPresenterItem>();
			tree.Value = new PresenterSimpleItem("Data");
			foreach (Data data in listOfData)
				tree.Add(TreeFromData(data));
			return tree;
		}

		private Tree<IPresenterItem> TreeFromData(Data data)
		{
			var tree = new Tree<IPresenterItem>();
			tree.Value = new PresenterSelectableItem(data, View);
			return tree;
		}

		private Tree<IPresenterItem> TreeFromSetups(List<Setup> setups)
		{
			var tree = new Tree<IPresenterItem>();
			tree.Value = new PresenterSimpleItem("Preconditions");
			foreach (Setup setup in setups)
				tree.Add(TreeFromSetup(setup));
			return tree;
		}

		private Tree<IPresenterItem> TreeFromSetup(Setup setup)
		{
			var tree = new Tree<IPresenterItem>();
			tree.Value = new PresenterSelectableItem(setup, View);
			return tree;
		}
	}
}