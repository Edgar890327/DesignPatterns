using System;
using System.Collections.Generic;

namespace Observer
{
    public interface IObserver
    {
        void Update(IObservable observable);
    }

    public interface IObservable
    {
        void Subscribe(IObserver observer);
        void Unsuscribe(IObserver observer);
        void Notify();
    }

    public class Artist : IObservable
    {
        private List<IObserver> Subscribers { get; set; } = new List<IObserver>();
        public string Event { get; set; }
        public void ReleaseNewAlbum(string title)
        {
            Event = $"Se publicó un nuevo album. Titulo {title}";
            Notify();
        }
        public void ReleaseNewSong(string title)
        {
            Event = $"Se publicó una nueva canción. Titulo {title}";
            Notify();
        }
        public void Notify()
        {
            Subscribers.ForEach(s=> s.Update(this));
        }

        public void Subscribe(IObserver observer)
        {
            Subscribers.Add(observer);
        }

        public void Unsuscribe(IObserver observer)
        {
            Subscribers.Remove(observer);
        }
    }

    public class MusicSubscriber : IObserver
    {
        public Action Action { get; set; }

        public void Update(IObservable observable)
        {
            if(observable is Artist artist)
            {
                Console.WriteLine(artist.Event);
            }
            else
            {
                Console.WriteLine("Nuevo evento registrado");
            }

            Action?.Invoke();
        }
    }
}
