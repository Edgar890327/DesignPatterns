using Observer;
using System;

var luisMiguel = new Artist();

var edgar = new MusicSubscriber();
edgar.Action = () => Console.WriteLine("Reproducir");

var joaquin = new MusicSubscriber();
joaquin.Action = () => Console.WriteLine("Agregar a la lista");

luisMiguel.Subscribe(edgar);
luisMiguel.Subscribe(joaquin);
luisMiguel.Subscribe(new MusicSubscriber());

luisMiguel.ReleaseNewAlbum("Musica navideña");
luisMiguel.ReleaseNewSong("Santa llegó a la ciudad");