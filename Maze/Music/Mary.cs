// This example demonstrates the Console.Beep(Int32, Int32) method
using System;
using System.Threading;
using Maze.Music;

namespace Maze.Music
{
    class Mary
    {
        public static void Main()
        {
            // Declare the first few notes of the song, "Mary Had A Little Lamb".

            Octave.Note[] Mary =
        {
        new Octave.Note(Octave.Tone.B, Octave.Duration.QUARTER),
        new Octave.Note(Octave.Tone.A, Octave.Duration.QUARTER),
        new Octave.Note(Octave.Tone.GbelowC, Octave.Duration.QUARTER),
        new Octave.Note(Octave.Tone.A, Octave.Duration.QUARTER),
        new Octave.Note(Octave.Tone.B, Octave.Duration.QUARTER),
        new Octave.Note(Octave.Tone.B, Octave.Duration.QUARTER),
        new Octave.Note(Octave.Tone.B, Octave.Duration.HALF),
        new Octave.Note(Octave.Tone.A, Octave.Duration.QUARTER),
        new Octave.Note(Octave.Tone.A, Octave.Duration.QUARTER),
        new Octave.Note(Octave.Tone.A, Octave.Duration.HALF),
        new Octave.Note(Octave.Tone.B, Octave.Duration.QUARTER),
        new Octave.Note(Octave.Tone.D, Octave.Duration.QUARTER),
        new Octave.Note(Octave.Tone.D, Octave.Duration.HALF)
        };
            // Play the song
            Play(Mary);
        }

        // Play the notes in a song.
        protected static void Play(Octave.Note[] tune)
        {
            foreach (Octave.Note n in tune)
            {
                if (n.NoteTone == Octave.Tone.REST)
                    Thread.Sleep((int)n.NoteDuration);
                else
                    Console.Beep((int)n.NoteTone, (int)n.NoteDuration);
            }
        }

        /*
        This example produces the following results:

        This example plays the first few notes of "Mary Had A Little Lamb"
        through the console speaker.
        */
    }
}
