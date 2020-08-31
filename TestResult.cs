namespace MultipleChoiceTests {

	///<inheritdoc cref="ITestResult"/>
	class TestResult : ITestResult {

		///<inheritdoc cref="ITestResult.Testpaper"/>
		public ITestpaper Testpaper {
			get;
		}

		///<inheritdoc cref="ITestResult.Score"/>
		public string Score {
			get;
		}

		///<inheritdoc cref="ITestResult.IsPassed"/>
		public bool IsPassed {
			get;
		}

		/// <summary>
		/// Initiate test result
		/// </summary>
		/// <param name="testpaper">test that was processed</param>
		/// <param name="score">result recieved while taking test</param>
		public TestResult(ITestpaper testpaper, string score) {
			Testpaper = testpaper;
			Score = score;
			IsPassed = testpaper.GetIsPassed(score);
		}

		///<inheritdoc cref="ITestResult.GetResult"/>
		public string GetResult() {
			string result = IsPassed ? "Passed!" : "Failed";
			return $"{Testpaper.Subject}: {result} ({Score})";
		}
	}
}
