﻿using System;
using System.Threading;

class TragnalKos
{
    public static void Main()
    {
        Note[] TragnalKos =
        {
        new Note(Tone.G, Duration.EIGHTH),
        new Note(Tone.E, Duration.EIGHTH),
        new Note(Tone.E, Duration.QUARTER),
        new Note(Tone.F, Duration.EIGHTH),
        new Note(Tone.D, Duration.EIGHTH),
        new Note(Tone.D, Duration.QUARTER),
        new Note(Tone.C, Duration.EIGHTH),
        new Note(Tone.D, Duration.EIGHTH),
        new Note(Tone.E, Duration.EIGHTH),
        new Note(Tone.F, Duration.EIGHTH),
        new Note(Tone.G, Duration.EIGHTH),
        new Note(Tone.G, Duration.EIGHTH),
        new Note(Tone.G, Duration.QUARTER),

        new Note(Tone.G, Duration.EIGHTH),
        new Note(Tone.E, Duration.EIGHTH),
        new Note(Tone.E, Duration.QUARTER),
        new Note(Tone.F, Duration.EIGHTH),
        new Note(Tone.D, Duration.EIGHTH),
        new Note(Tone.D, Duration.QUARTER),
        new Note(Tone.C, Duration.EIGHTH),
        new Note(Tone.E, Duration.EIGHTH),
        new Note(Tone.G, Duration.EIGHTH),
        new Note(Tone.G, Duration.EIGHTH),
        new Note(Tone.C, Duration.EIGHTH),
        new Note(Tone.C, Duration.EIGHTH),
        new Note(Tone.C, Duration.QUARTER),

        new Note(Tone.D, Duration.EIGHTH),
        new Note(Tone.D, Duration.EIGHTH),
        new Note(Tone.D, Duration.EIGHTH),
        new Note(Tone.D, Duration.EIGHTH),
        new Note(Tone.D, Duration.EIGHTH),
        new Note(Tone.E, Duration.EIGHTH),
        new Note(Tone.F, Duration.QUARTER),

        new Note(Tone.E, Duration.EIGHTH),
        new Note(Tone.E, Duration.EIGHTH),
        new Note(Tone.E, Duration.EIGHTH),
        new Note(Tone.E, Duration.EIGHTH),
        new Note(Tone.E, Duration.EIGHTH),
        new Note(Tone.F, Duration.EIGHTH),
        new Note(Tone.G, Duration.QUARTER),

        new Note(Tone.G, Duration.EIGHTH),
        new Note(Tone.E, Duration.EIGHTH),
        new Note(Tone.E, Duration.QUARTER),
        new Note(Tone.F, Duration.EIGHTH),
        new Note(Tone.D, Duration.EIGHTH),
        new Note(Tone.D, Duration.QUARTER),
        new Note(Tone.C, Duration.EIGHTH),
        new Note(Tone.E, Duration.EIGHTH),
        new Note(Tone.G, Duration.EIGHTH),
        new Note(Tone.G, Duration.EIGHTH),
        new Note(Tone.C, Duration.EIGHTH),
        new Note(Tone.C, Duration.EIGHTH),
        new Note(Tone.C, Duration.QUARTER),
        };
        Play(TragnalKos);
    }
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
    protected enum Tone
    {
        REST = 0,
        GbelowC = 196,
        A = 220,
        Asharp = 233,
        B = 247,
        C = 262,
        Csharp = 277,
        D = 294,
        Dsharp = 311,
        E = 330,
        F = 349,
        Fsharp = 370,
        G = 392,
        Gsharp = 415,
    }
    protected enum Duration
    {
        WHOLE = 2600,
        HALF = WHOLE / 2,
        QUARTER = HALF / 2,
        EIGHTH = QUARTER / 2,
        SIXTEENTH = EIGHTH / 2,
        HALFplusPoint = EIGHTH * 3,
    }
    protected struct Note
    {
        Tone toneVal;
        Duration durVal;
        public Note(Tone frequency, Duration time)
        {
            toneVal = frequency;
            durVal = time;
        }
        public Tone NoteTone { get { return toneVal; } }
        public Duration NoteDuration { get { return durVal; } }
    }
}