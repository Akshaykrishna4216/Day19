using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement3
{
    public class Song
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        private string _artist;
        public string Artist { get { return _artist; } set { _artist = value; } }

        private string _songType;
        public string SongType { get { return _songType; } set { _songType = value; } }

        private double _rating;
        public double Rating { get { return _rating; } set { _rating = value; } }

        private int _numberofDownloads;
        public int NumberofDownloads { get { return _numberofDownloads; } set { _numberofDownloads = value; } }

        private DateTime _dateDownloaded;
        public DateTime DateDownloaded
        {
            get { return _dateDownloaded; }
            set { _dateDownloaded = value; }
        }
           
            public Song() { }

           public Song(string name,string artist,string songtype,double rating,int numberofDownloads,DateTime datedownloaded)
        {
            _name = name;
            _artist = artist;
            _songType = songtype;
            _rating = rating;
            _numberofDownloads = numberofDownloads;
            _dateDownloaded = datedownloaded;
        }
        public override string ToString()
        {
            return $"Name:{_name}\n Artist:{_artist}\n Song Type{_songType}\n Rating{_rating}\n No of Downloads{_numberofDownloads}\n Date Downloaded{_dateDownloaded.ToString("dd-mm-yyyy")}";
        }

    }

    }

