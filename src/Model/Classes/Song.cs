﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    public class Song
    {
        private int _duration;

        public string Title { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }

        public int Duration
        {
            get 
            { 
                return _duration; 
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }

        public Song()
        {
        }

        public Song(string title, string author, string genre, int duration)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Duration = duration;
        }
    }
}
