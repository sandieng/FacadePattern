using System;

namespace FacadePattern.Amplifier
{
    public class Amplifier : IAmplifier
    {
        private readonly string _component;     
        private int _volume;
        
        public Amplifier()
        {
            _component = "Amplifier";        
            _volume = 0;
        }

        public void On()
        {
            Console.WriteLine($"{_component}: On");
        }

        public void Off()
        {
            Console.WriteLine($"{_component}: Off");
        }     

        public void SetVolume(int db)
        {
            _volume = db;
            Console.WriteLine($"{_component}: Set Volume to {_volume} db");
        }

        public void SurroundSoundOn()
        {
            Console.WriteLine($"{_component}: Surround Sound On");
        }

        public void StereoSoundOn()
        {
            Console.WriteLine($"{_component}: Stereo Sound On");
        }
    }
}
