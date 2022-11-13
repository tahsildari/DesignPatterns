using DesignPatternsAsISeeThem.Structural.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Testers
{
    class CompositeTester : Tester, ITester
    {
        protected override string GetName() => this.GetType().Name;
        public void Run()
        {
            IntroduceTester();

            var root = new Folder(@"D:\");
            
            var films = new Folder("Films");
            root.Add(films);
            
            var spiderManTrailer = new File("Spider-Man-trailer.mkv", 25000);
            var ironManTrailer = new File("Iron-Man-trailer.mkv", 48000);
            var watchList = new File("Watch-list.txt", 8);
            films.Add(spiderManTrailer);
            films.Add(ironManTrailer);
            films.Add(watchList);
            
            var music = new Folder("Music");
            root.Add(music);

            var michealJackson = new Folder("Michael Jackson");
            michealJackson.Add(new File("Billie-Jean.mp3", 3000));
            michealJackson.Add(new File("Beat-it.mp3", 2500));
            michealJackson.Add(new File("They-dont-care-about-us.mp3", 5200));
            music.Add(michealJackson);

            var rihanna = new Folder("Rihanna");
            rihanna.Add(new File("Diamonds.mp3", 3500));
            rihanna.Add(new File("Dont-stop-the-music.mp3", 2900));
            rihanna.Add(new File("Umbrella.mp3", 3700));
            rihanna.Add(new File("Man-down.mp3", 4100));
            music.Add(rihanna);

            var notes = new Folder("Notes");
            notes.Add(new File("Birthdates.txt", 2));
            notes.Add(new File("Address-book.txt", 120));
            notes.Add(new File("Contacts.txt", 15));
            root.Add(notes);

            DisplayInConsole("*** without size ***");
            DisplayInConsole(root.Display());
            DisplayInConsole("");
            DisplayInConsole("*** with size ***");
            DisplayInConsole(root.DisplayWithSize());
            DisplayInConsole("");
            DisplayInConsole("*** single folder ***");
            DisplayInConsole(films.DisplayWithSize());
            DisplayInConsole("");
            DisplayInConsole("*** single file ***");
            DisplayInConsole(spiderManTrailer.DisplayWithSize());

            void DisplayInConsole (string text) => Console.WriteLine(text);
        }
    }
}
