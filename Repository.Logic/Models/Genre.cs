namespace Repository.Logic.Models
{
    public enum Genre : int
    {
        NewJazz = 1,
        Pop = 2,
        Rock = 2 * Pop,
        Pop_Punk = 2 * Rock,
        Rap = 2 * Pop_Punk,
        Alternative = 2 * Rap,
    }
}
