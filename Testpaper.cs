using System;
using System.Collections.Generic;
using System.Linq;

namespace MultipleChoiceTests {

	///<inheritdoc cref="ITestpaper"/>
	class Testpaper : ITestpaper
    {
		/// <summary cref="MarkScheme">
		/// Representation of MarkScheme in dictionary for quicker access
		/// </summary>
		private Dictionary<int, string> _markScheme;

		///<inheritdoc cref="ITestpaper.Subject"/>
		public string Subject {
			get;
		}

		///<inheritdoc cref="ITestpaper.MarkScheme"/>
		public string[] MarkScheme {
			get;
		}

		///<inheritdoc cref="ITestpaper.PassMark"/>
		public string PassMark {
			get;
		}

		/// <summary>
		/// Base constructor
		/// </summary>
		public Testpaper(string subject, string[] markScheme, string passMark) {
			Subject = subject;
			PassMark = passMark;
			MarkScheme = markScheme;
			_markScheme = new Dictionary<int, string>();
			foreach (string mark in markScheme) {
				int exerisice = Convert.ToInt32(mark.First());
				char answer = mark.Last();
				_markScheme.Add(exerisice, answer.ToString());
			}
		}

		///<inheritdoc cref="ITestpaper.GetTestResults(string[])"/>
		public string GetTestResults(string[] studentAnswers) {
			int correctAnswersCount = 0;
			foreach (string answer in studentAnswers) {
				int exercise = Convert.ToInt32(answer.First());
				var correctAnswer = _markScheme[exercise];
				if (correctAnswer.Equals(answer.Last().ToString(), StringComparison.InvariantCultureIgnoreCase)) {
					correctAnswersCount++;
				}
			}
			return Math.Round((double)correctAnswersCount / MarkScheme.Count()) * 100 + "%";
		}

		///<inheritdoc cref="ITestpaper.GetIsPassed(string)"/>
		public bool GetIsPassed(string result) {
			var passMark = Convert.ToInt32(PassMark.Replace("%", string.Empty));
			var resultMark = Convert.ToInt32(result.Replace("%", string.Empty));
			return resultMark >= passMark;
		}
	}
}
