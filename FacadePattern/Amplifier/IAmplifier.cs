namespace FacadePattern.Amplifier
{
    public interface IAmplifier
    {
        void On();
        void Off();     
        void SetVolume(int db);
        void SurroundSoundOn();
        void StereoSoundOn();
    }
}
