using System.Collections.Generic;
using System.Linq;

namespace MultipleChoiceTests {

	///<inheritdoc cref="IStudent"/>
	class Student : IStudent {

		/// <summary>
		/// Collection of taken tests and theirs results.
		/// </summary>
		private ICollection<ITestResult> _testTaken;

		///<inheritdoc cref="IStudent.TestsTaken/>
		public string[] TestsTaken {
			get {
				if (!_testTaken.Any()) {
					return new string[] {
						"No tests taken"
					};
				}
				return _testTaken
					.OrderBy(testResult => testResult.Testpaper.Subject)
					.Select(testResult => testResult.GetResult()).ToArray();
			}
		}

		/// <summary>
		/// Default contstructor.
		/// </summary>
		public Student() {
			_testTaken = new List<ITestResult>();
		}

		///<inheritdoc cref="IStudent.TakeTest(ITestpaper, string[])"/>
		public void TakeTest(ITestpaper paper, string[] answers) {
			var score = paper.GetTestResults(answers);
			ITestResult testResult = new TestResult(paper, score);
			_testTaken.Add(testResult);
		}
	}
}
