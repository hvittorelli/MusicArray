using System;

namespace FunWithMusic
{
    class MusicGenre
    {
        enum Genre
        {
            Country,
            Pop,
            Reggae,
            Indy,
            Folk,
        }

        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private double Length;
            private Genre? Genre;

            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setLength(double length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            int size = int.Parse(Console.ReadLine());
            Music[] collection = new Music[size];
            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("What is the title of the song?");
                    collection[i].setTitle(Console.ReadLine());
                    Console.WriteLine("What is the Artist's Name?");
                    collection[i].setArtist(Console.ReadLine());
                    Console.WriteLine("What is the name of the Album?");
                    collection[i].setAlbum(Console.ReadLine());
                    Console.WriteLine("What is the length of the song?");
                    collection[i].setLength(double.Parse(Console.ReadLine()));
                    Console.WriteLine("What is the genre?");
                    Console.WriteLine("C - Country\nP - Pop\nR - Reggae\nI - Indy\nF - Folk");
                    char genre = char.Parse(Console.ReadLine());
                    switch (genre)
                    {
                        case 'C':
                            collection[i].setGenre(Genre.Country);
                            break;
                        case 'P':
                            collection[i].setGenre(Genre.Pop);
                            break;
                        case 'R':
                            collection[i].setGenre(Genre.Reggae);
                            break;
                        case 'I':
                            collection[i].setGenre(Genre.Indy);
                            break;
                        case 'F':
                            collection[i].setGenre(Genre.Folk);
                            break;
                    }
                }
            }
            catch (ArgumentException e) 
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e) 
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Here is the collection of your music: ");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"{collection[i].Display()}");
                }
            }
        }
    }
}