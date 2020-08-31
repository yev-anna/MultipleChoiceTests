namespace MultipleChoiceTests {

	/// <summary>
	/// Inforamation about processed test
	/// </summary>
	interface ITestResult {
		/// <summary>
		/// Processed test.
		/// </summary>
		ITestpaper Testpaper {
			get;
		}

		/// <summary>
		/// Total result of processed test.
		/// </summary>
		string Score {
			get;
		}

		/// <summary>
		/// Boolean result of processed test.
		/// </summary>
		bool IsPassed {
			get;
		}

		/// <summary>
		/// Format test result.
		/// </summary>
		/// <returns>Serialized result.</returns>
		string GetResult();
	}
}
