namespace Infrastructure.Contracts
{
     public interface IServiceEnvironment
     {
          bool UseCluster();
          string GetClusterName();
     }
}