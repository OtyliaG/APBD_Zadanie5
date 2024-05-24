namespace Zadanie7.Interfaces
{
    public interface ITripsRepository
    {
        Task<IEnumberable<TripDTO>> GetTripsAsync();
    }
}
