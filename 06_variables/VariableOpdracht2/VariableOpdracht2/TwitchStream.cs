﻿using System;
using System.Net.Http.Headers;

namespace VariableOpdracht2
{
    internal class TwitchStream
    {
        //maak hier class variables aan:
        // type=string, naam: name,
        // type=string, naam: lastStreamName
        // type=Game, naam: streamGame
        // type=int, naam: followers
        // type=bool, naam: automod
        internal string name;
        internal string lastStreamName;
        internal Game streamGame;
        internal int followers;
        internal bool automod;
        
    }
}