using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace Web.UI.Controllers
{
    public class TestAsyncController : Controller
    {
        // GET: TestAsync
        public async Task<ActionResult> Index()
        {
            var sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            var result = await GetSampleCandidate();
            
            sw.Stop();
            result.TimeToExecute = sw.Elapsed.TotalSeconds;
            return this.View(result);
        }

        private async Task<Models.Candidate> GetSampleCandidate()
        {
            var cand = new Models.Candidate { FirstName = "Antrel", LastName = "Rolle", IsActive = true, YearsOfExperience = 15 };
            await Task.Delay(6000);
            return cand;
        }
    }
}