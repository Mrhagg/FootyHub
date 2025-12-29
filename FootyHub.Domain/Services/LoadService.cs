using FootyHub.Domain.Entities;

namespace FootyHub.Domain.Services;

public class LoadService
{

    public decimal CalculateTotalLoad(IEnumerable<PlayerMatchPerformance> matches, IEnumerable<TrainingSession> trainings)
    {
        var matchLoad = matches.Sum(m => m.CalcuatedLoad);
        var trainingLoad = trainings.Sum(t => (decimal)t.Duration.TotalMinutes);

        return matchLoad + trainingLoad;
    }
}
