using FacadePattern;
using FacadePattern.Amplifier;
using FacadePattern.CdPlayer;
using FacadePattern.DvdPlayer;
using System;
using FacadePattern.Projector;

namespace FacadePatternClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IDvdPlayer dvdPlayer = new DvdPlayer();
            ICdPlayer cdPlayer = new CdPlayer();
            IAmplifier amplifier = new Amplifier();
            IProjector projector = new Projector();
            IHomeTheater homeTheater = new HomeTheaterFacade(projector, amplifier, dvdPlayer, cdPlayer);

            homeTheater.WatchMovie("Finding Nemo");
            homeTheater.EndMovie();

            homeTheater.PlayMusic("Beethoven Symphonie Number 6");
            homeTheater.StopMusic();

            Console.ReadKey();
        }
    }
}
