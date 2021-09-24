using FreshMvvm;
using System;
using System.Collections.Generic;

namespace Imi.Project.Mobile.ViewModels.SpaceObjects
{
    public class SpaceBaseItemViewModel<TKey> : FreshBasePageModel
    {
        #region Fields

        private int apogee;
        private TKey id;

        private IEnumerable<string> imageUris;
        private string mass;
        private string name;

        private int perigee;
        private string shortname;
        private string size;
        private string spacetype;

        private Uri thumbnailImageUri;

        #endregion Fields

        #region Properties

        public int Apogee
        {
            get { return apogee; }
            set
            {
                apogee = value;
                RaisePropertyChanged();
            }
        }

        public TKey Id
        {
            get { return id; }
            set { id = value; }
        }

        public IEnumerable<string> ImageUris
        {
            get { return imageUris; }
            set
            {
                imageUris = value;
                RaisePropertyChanged();
            }
        }

        public string Mass
        {
            get { return $"{mass}"; }
            set
            {
                mass = value;
                RaisePropertyChanged();
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged();
            }
        }

        public int Perigee
        {
            get { return perigee; }
            set
            {
                perigee = value;
                RaisePropertyChanged();
            }
        }

        public string ShortName
        {
            get { return shortname; }
            set
            {
                shortname = value;
                RaisePropertyChanged();
            }
        }

        public string Size
        {
            get { return $"{size}"; }
            set
            {
                size = value;
                RaisePropertyChanged();
            }
        }

        public string SpaceType
        {
            get { return spacetype; }
            set
            {
                spacetype = value;
                RaisePropertyChanged();
            }
        }

        public Uri ThumbnailImageUri
        {
            get { return thumbnailImageUri; }
            set
            {
                thumbnailImageUri = value;
                RaisePropertyChanged();
            }
        }

        #endregion Properties
    }
}