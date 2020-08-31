namespace MultipleChoiceTests {

	/// <summary>
	/// Main representation of testpaper.
	/// </summary>
	interface ITestpaper {
		/// <summary>
		/// Science or educational field to test.
		/// </summary>
		string Subject {
			get;
		}

		/// <summary>
		/// Right answers for test questions.
		/// </summary>
		string[] MarkScheme {
			get;
		}

		/// <summary>
		/// Minimal mark to pass the test.
		/// </summary>
		string PassMark {
			get;
		}

		/// <summary>
		/// Compare proposed answers with mark sheme and count mark. 
		/// </summary>
		/// <param name="answers">Proposed answers.</param>
		/// <returns>Test mark.</returns>
		string GetTestResults(string[] answers);

		/// <summary>
		/// Compare one's mark to minimal.
		/// </summary>
		/// <param name="result">Previously gotten mark.</param>
		/// <returns>If the test passed.</returns>
		bool GetIsPassed(string result);
	}
}
