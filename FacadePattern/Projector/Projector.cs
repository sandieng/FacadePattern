using System;

namespace FacadePattern.Projector
{
    public class Projector : IProjector
    {
        private readonly string _component;

        public Projector()
        {
            _component = "Projector";
        }

        public void On()
        {
            Console.WriteLine($"{_component}: On");
        }

        public void Off()
        {
            Console.WriteLine($"{_component}: Off");
        }
    }
}
