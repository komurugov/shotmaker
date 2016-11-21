using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace shotmaker
{
    class StepAndExpectedResults
    {
        public string Step { get; private set; }
        public List<string> ExpectedResults { get; private set; }
    }

    class Verification
    {
        public List<string> Data { get; private set; }
        public List<StepAndExpectedResults> StepAndExpectedResults { get; private set; }
    }

    class TestCase
    {
        public string ExecutionID { get; private set; }
        public string ExecutionTitle { get; private set; }
        public string ID { get; private set; }
        public string Title { get; private set; }
        public List<string> Preconditions { get; private set; }
        public List<Verification> Verifications { get; private set; }

        static TestCase LoadFromXml(XmlDocument doc) { return null; }
    }

    abstract class Screenshotable
    {
        public 
    }

    class TestCaseResults
    {
        public TestCase TestCase { get; private set; }

        public enum TResult { Passed, Failed }
        public enum TStatus { None, Done, Skipped }

        public bool SetPrecondition(bool shot, int precondition) { return false; }
        public bool SetData(bool shot, int verification, int data) { return false; }
        public bool SetResult(bool shot, int verification, int step, int subStep, TResult result) { return false; }
    }

}
