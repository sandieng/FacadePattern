namespace FacadePattern.DvdPlayer
{
    public interface IDvdPlayer
    {
        void On();
        void Off();
        void Eject();
        void Pause();
        void Play();
        void SkipNext();
        void SkipPrevious();
        void Stop();
    }
}
