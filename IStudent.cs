namespace MultipleChoiceTests
{
	/// <summary>
	/// Model for one that can take test
	/// </summary>
    interface IStudent
    {
		/// <summary>
		/// Collection of test results.
		/// </summary>
		string[] TestsTaken {
			get;
		}

		/// <summary>
		/// Process test.
		/// </summary>
		/// <param name="paper">Test, taken by student.</param>
		/// <param name="answers">Proposed answers.</param>
		void TakeTest(ITestpaper paper, string[] answers);

	}
}
