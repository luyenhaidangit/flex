using Quartz;
using Serilog;

namespace Flex.Api.Jobs
{
    public class DailyBatchJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            Log.Information("Batch job executed at: " + DateTime.Now);

            return Task.CompletedTask;
        }
    }
}
