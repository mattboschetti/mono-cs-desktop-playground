using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using System.Threading.Tasks;

namespace JenkinsNotifier
{
	public class JenkinsJobsRepository
	{
		private List<JenkinsJob> jobs;

		public JenkinsJobsRepository ()
		{
			jobs = new List<JenkinsJob> ();
		}

		public Task loadAsync() 
		{
			return Task.Run (() => {
				jobs = execute<Jenkins> (new RestRequest ("api/json?pretty=false", Method.GET)).jobs;
			});
		}

		public List<JenkinsJob> availableJobs()
		{
			return jobs;
		}

		public List<JenkinsJob> brokenJobs()
		{
			return jobs.Where (job => job.color.Equals ("red")).ToList ();
		}

		private T execute<T>(RestRequest request) where T : new()
		{
			var client = new RestClient ("https://ci.thomsonreuterslifesciences.com/jenkins/");
			var resp = client.Execute<T> (request);
			return resp.Data;
		}
	}
}

