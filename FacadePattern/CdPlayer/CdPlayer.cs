using System;

namespace FacadePattern.CdPlayer
{
    public class CdPlayer : ICdPlayer
    {
        private readonly string _component;

        public CdPlayer()
        {
            _component = "CD Player";
        }
        public void On()
        {
            Console.WriteLine($"{_component}: On");
        }

        public void Off()
        {
            Console.WriteLine($"{_component}: Off");
        }

        public void Eject()
        {
            Console.WriteLine($"{_component}: Eject");
        }

        public void Pause()
        {
            Console.WriteLine($"{_component}: Pause");
        }

        public void Play()
        {
            Console.WriteLine($"{_component}: Play");
        }

        public void Stop()
        {
            Console.WriteLine($"{_component}: Stop");
        }

        public void SkipNext()
        {
            Console.WriteLine($"{_component}: Skip Next");
        }

        public void SkipPrevious()
        {
            Console.WriteLine($"{_component}: Skip Previous");
        }
    }
}
