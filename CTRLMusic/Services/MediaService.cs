
using Entities;
using Repositories;
using System.Collections.Generic;

namespace Services
{
    public class MediaService : IMediaRepository
    {
        public bool Delete(List<Media> medias)
        {
            throw new System.NotImplementedException();
        }

        public Media GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Insert(Media media)
        {
            throw new System.NotImplementedException();
        }

        public List<Media> SearchAll()
        {
            throw new System.NotImplementedException();
        }

        public List<Media> SearchByNameOrArtistOrGenresOrReleasedYear(string name, string artist, string genres, int releasedYear)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Media media)
        {
            throw new System.NotImplementedException();
        }
    }
}
