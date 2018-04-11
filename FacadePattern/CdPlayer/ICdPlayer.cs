namespace FacadePattern.CdPlayer
{
    public interface ICdPlayer
    {
        void On();
        void Off();
        void Eject();
        void Pause();
        void Play();
        void Stop();
        void SkipNext();
        void SkipPrevious();
    }
}
