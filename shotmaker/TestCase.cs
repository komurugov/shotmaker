using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

}
