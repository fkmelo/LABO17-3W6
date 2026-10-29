namespace ZombieParty.Models
{
    public interface IZombiePartyDbContextSeed
    {
        Task SeedAsync(int retry = 0);
    }
}