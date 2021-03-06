﻿using Entities;
using System.Collections.Generic;

namespace Repositories
{
    public interface IMediaRepository
    {
        bool Insert(Media media);
        bool Update(Media media);
        bool Delete(List<Media> medias);

        List<Media> SearchAll();
        List<Media> SearchByNameOrArtistOrGenresOrReleasedYear(string name, string artist, string genres, int releasedYear);

        Media GetById(int id);
    }
}
