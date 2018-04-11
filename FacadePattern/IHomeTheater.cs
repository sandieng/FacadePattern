namespace FacadePattern
{
    public interface IHomeTheater
    {
        void WatchMovie(string title);
        void EndMovie();
        void PlayMusic(string cd);
        void StopMusic();
    }
}
