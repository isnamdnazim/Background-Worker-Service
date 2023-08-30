
using System.Threading;

public class BackgroundWorkerService : BackgroundService
{
    readonly ILogger<BackgroundWorkerService> _logger;

    public BackgroundWorkerService(ILogger<BackgroundWorkerService> logger)
    {
            _logger = logger;
    }
    //public async Task StartAsync(CancellationToken cancellationToken)
    //{
    //    _logger.LogInformation("Service Started");
    //}

    //public Task StopAsync(CancellationToken cancellationToken)
    //{
    //    _logger.LogInformation("Service Stopped");
    //    return Task.CompletedTask;
    //}

    protected async override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker Service Started at: {time}", DateTimeOffset.Now);
            await Task.Delay(1000, stoppingToken);
        }
    }
}