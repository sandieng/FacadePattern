using System;
using FacadePattern.Amplifier;
using FacadePattern.CdPlayer;
using FacadePattern.DvdPlayer;
using FacadePattern.Projector;

namespace FacadePattern
{
    public class HomeTheaterFacade : IHomeTheater
    {
        private readonly IAmplifier _amplifier;
        private readonly IProjector _projector;
        private readonly ICdPlayer _cdPlayer;
        private readonly IDvdPlayer _dvdPlayer;

        public HomeTheaterFacade(IProjector projector, IAmplifier amplifier, IDvdPlayer dvdPlayer, ICdPlayer cdPlayer)
        {
            _projector = projector;
            _amplifier = amplifier;
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
        }

        public void WatchMovie(string title)
        {
            Console.WriteLine($"Getting ready to watch a movie ...: {title}");
            _amplifier.On();
            _amplifier.SurroundSoundOn();
            _amplifier.SetVolume(30);
            _projector.On();
            _dvdPlayer.On();
            _dvdPlayer.Play();
        }
    
        public void EndMovie()
        {
            Console.WriteLine("Stopping the movie ...");
            _dvdPlayer.Stop();
            _dvdPlayer.Eject();
            _dvdPlayer.Off();
            _projector.Off();
            _amplifier.SetVolume(0);
            _amplifier.Off();
        }

        public void PlayMusic(string cd)
        {
            Console.WriteLine($"Getting ready to play some music: {cd}");
            _amplifier.On();
            _amplifier.StereoSoundOn();
            _amplifier.SetVolume(30);
            _cdPlayer.On();
            _cdPlayer.Play();
        }

        public void StopMusic()
        {
            Console.WriteLine("Stopping music ...");
            _cdPlayer.Stop();
            _cdPlayer.Off();
            _amplifier.SetVolume(0);
            _amplifier.Off();
        }
    }
}
