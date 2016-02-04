namespace Client.Contracts
{
     public interface IServiceEnvironment
     {
          bool UseCluster();
          string GetClusterName();
     }
}