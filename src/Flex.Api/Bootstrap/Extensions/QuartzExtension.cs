using Flex.Api.Jobs;
using Quartz;

namespace Flex.Api.Bootstrap.Extensions
{
    public static class QuartzExtension
    {
        public static IServiceCollection AddQuartzApplication(this IServiceCollection services)
        {
            services.AddQuartz(q =>
            {
                q.UseMicrosoftDependencyInjectionJobFactory();

                // base Quartz scheduler, job and trigger configuration
                q.AddJob<DailyBatchJob>(opts =>
                {
                    opts.DisallowConcurrentExecution();
                    opts.WithIdentity(nameof(DailyBatchJob));
                });

                q.AddTrigger(opts =>
                {
                    opts.ForJob(nameof(DailyBatchJob)).WithIdentity($"{nameof(DailyBatchJob)}Trigger")
                        .StartNow().WithCronSchedule("0/5 * * * * ?");
                });
            });

            services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);


            return services;
        }
    }
}
