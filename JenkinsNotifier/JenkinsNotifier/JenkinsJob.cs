using System;

namespace JenkinsNotifier
{
	public class JenkinsJob
	{
		public string name { get; set; }
		public string color  { get; set; }
		public string url  { get; set; }

		public string toString()
		{
			string broken = color.Equals ("red") ? "BROKEN" : "STABLE";
			return "[" + broken +  "] " + name;
		}
	}
}

