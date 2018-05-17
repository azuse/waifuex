﻿using System;

namespace PavoStudio.ExApi
{
    public class Msg
    {
        public const int ShowTextBubble = 11000;
        public const int SetBackground = 12000;
        public const int Set360Background = 12100;
        public const int SetModel = 13000;
        public const int RemoveModel = 13100;
        public const int SetEffect = 14000;
        public const int AddEffect = 14100;
        public const int RemoveEffect = 14200;
        public const int SyncResourceMonitor = 20000;
    }

    public class LocalMsg {
        public const int OnOpen = 0;
        public const int OnClose = 1;
        public const int OnError = 2;
    }
}

