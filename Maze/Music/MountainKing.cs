using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Music
{
    class MountainKing
    {
        public static void Main()
        {

            Note[] MountainKing =
        {
        new Note(Tone.B4, Duration.EIGHTH),
        new Note(Tone.C5, Duration.EIGHTH),
        new Note(Tone.D5, Duration.EIGHTH),
        new Note(Tone.E5, Duration.EIGHTH),
        new Note(Tone.F5, Duration.EIGHTH),
        new Note(Tone.D5, Duration.EIGHTH),
        new Note(Tone.F5, Duration.QUARTER),

        new Note(Tone.F5, Duration.EIGHTH),
        new Note(Tone.C5, Duration.EIGHTH),
        new Note(Tone.F5, Duration.QUARTER),
        new Note(Tone.E5, Duration.EIGHTH),
        new Note(Tone.C5, Duration.EIGHTH),
        new Note(Tone.E5, Duration.QUARTER),

        new Note(Tone.B4, Duration.EIGHTH),
        new Note(Tone.C5, Duration.EIGHTH),
        new Note(Tone.D5, Duration.EIGHTH),
        new Note(Tone.E5, Duration.EIGHTH),
        new Note(Tone.F5, Duration.EIGHTH),
        new Note(Tone.D5, Duration.EIGHTH),
        new Note(Tone.F5, Duration.EIGHTH),
        new Note(Tone.B5, Duration.EIGHTH),

        new Note(Tone.A5, Duration.EIGHTH),
        new Note(Tone.F5, Duration.EIGHTH),
        new Note(Tone.D5, Duration.EIGHTH),
        new Note(Tone.F5, Duration.EIGHTH),
        new Note(Tone.A5, Duration.HALF),



        new Note(Tone.B4, Duration.EIGHTH),
        new Note(Tone.C5, Duration.EIGHTH),
        new Note(Tone.D5, Duration.EIGHTH),
        new Note(Tone.E5, Duration.EIGHTH),
        new Note(Tone.F5, Duration.EIGHTH),
        new Note(Tone.D5, Duration.EIGHTH),
        new Note(Tone.F5, Duration.QUARTER),

        new Note(Tone.F5, Duration.EIGHTH),
        new Note(Tone.C5, Duration.EIGHTH),
        new Note(Tone.F5, Duration.QUARTER),
        new Note(Tone.E5, Duration.EIGHTH),
        new Note(Tone.C5, Duration.EIGHTH),
        new Note(Tone.E5, Duration.QUARTER),

        new Note(Tone.B4, Duration.EIGHTH),
        new Note(Tone.C5, Duration.EIGHTH),
        new Note(Tone.D5, Duration.EIGHTH),
        new Note(Tone.E5, Duration.EIGHTH),
        new Note(Tone.F5, Duration.EIGHTH),
        new Note(Tone.D5, Duration.EIGHTH),
        new Note(Tone.F5, Duration.EIGHTH),
        new Note(Tone.B5, Duration.EIGHTH),

        new Note(Tone.A5, Duration.EIGHTH),
        new Note(Tone.F5, Duration.EIGHTH),
        new Note(Tone.D5, Duration.EIGHTH),
        new Note(Tone.C5, Duration.EIGHTH),
        new Note(Tone.B4, Duration.HALF),

        new Note(Tone.REST,Duration.WHOLE),


        new Note(Tone.B2, Duration.SIXTEENTH),
        new Note(Tone.C3, Duration.SIXTEENTH),
        new Note(Tone.D3, Duration.SIXTEENTH),
        new Note(Tone.E3, Duration.SIXTEENTH),
        new Note(Tone.F3, Duration.SIXTEENTH),
        new Note(Tone.D3, Duration.SIXTEENTH),
        new Note(Tone.E3, Duration.EIGHTH),

        new Note(Tone.F3, Duration.SIXTEENTH),
        new Note(Tone.C3, Duration.SIXTEENTH),
        new Note(Tone.F3, Duration.EIGHTH),
        new Note(Tone.E3, Duration.SIXTEENTH),
        new Note(Tone.C3, Duration.SIXTEENTH),
        new Note(Tone.E3, Duration.EIGHTH),

        new Note(Tone.B2, Duration.SIXTEENTH),
        new Note(Tone.C3, Duration.SIXTEENTH),
        new Note(Tone.D3, Duration.SIXTEENTH),
        new Note(Tone.E3, Duration.SIXTEENTH),
        new Note(Tone.F3, Duration.SIXTEENTH),
        new Note(Tone.D3, Duration.SIXTEENTH),
        new Note(Tone.F3, Duration.SIXTEENTH),
        new Note(Tone.B3, Duration.SIXTEENTH),

        new Note(Tone.A3, Duration.SIXTEENTH),
        new Note(Tone.F3, Duration.SIXTEENTH),
        new Note(Tone.D3, Duration.SIXTEENTH),
        new Note(Tone.F3, Duration.SIXTEENTH),
        new Note(Tone.A3, Duration.QUARTER),

        };
            // Play the song
            Play(MountainKing);
        }

        // Play the notes in a song.
        protected static void Play(Note[] tune)
        {
            foreach (Note n in tune)
            {
                if (n.NoteTone == Tone.REST)
                    Thread.Sleep((int)n.NoteDuration);
                else
                    Console.Beep((int)n.NoteTone, (int)n.NoteDuration);
            }
        }

        // Define the frequencies of notes in an octave, as well as
        // silence (rest).
        protected enum Tone
        {
            REST = 0,
            A1 = 55,
            A1sharp = 58,
            B1 = 62,

            C2 = 65,
            C2sharp = 69,
            D2 = 73,
            D2sharp = 78,
            E2 = 82,
            F2 = 87,
            F2sharp = 93,
            G2 = 98,
            G2sharp = 104,
            A2 = 110,
            A2sharp = 117,
            B2 = 123,

            C3 = 131,
            C3sharp = 139,
            D3 = 147,
            D3sharp = 156,
            E3 = 165,
            F3 = 175,
            F3sharp = 185,
            G3 = 196,
            G3sharp = 208,
            A3 = 220,
            A3sharp = 233,
            B3 = 247,


            C4 = 262,
            C4sharp = 277,
            D4 = 294,
            D4sharp = 311,
            E4 = 330,
            F4 = 349,
            F4sharp = 370,
            G4 = 392,
            G4sharp = 415,
            A4 = 440,
            B4 = 494,

            C5 = 523,
            C5sharp = 554,
            D5 = 587,
            E5 = 659,
            F5 = 698,
            F5sharp = 740,
            G5 = 784,
            A5 = 880,
            B5 = 988
        }

        // Define the duration of a note in units of milliseconds.
        protected enum Duration
        {
            WHOLE = 2500, //Quarter = 96 bpm
            HALF = WHOLE / 2,
            QUARTER = HALF / 2,
            EIGHTH = QUARTER / 2,
            SIXTEENTH = EIGHTH / 2,

        }

        // Define a note as a frequency (tone) and the amount of
        // time (duration) the note plays.
        protected struct Note
        {
            Tone toneVal;
            Duration durVal;

            // Define a constructor to create a specific note.
            public Note(Tone frequency, Duration time)
            {
                toneVal = frequency;
                durVal = time;
            }

            // Define properties to return the note's tone and duration.
            public Tone NoteTone { get { return toneVal; } }
            public Duration NoteDuration { get { return durVal; } }
        }
    }
}
