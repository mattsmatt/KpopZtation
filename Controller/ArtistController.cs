using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class ArtistController
    {
        public static int deleteArtist(string artistID, string artistName)
        {
            if (artistID.Equals("") || artistName.Equals(""))
            {
                return 0;
            }
            else if (ArtistRepository.getArtistByID(int.Parse(artistID)) == null)
            {
                return 1;
            }
            else if (ArtistRepository.getArtistByName(artistName) == null)
            {
                return 2;
            }
            else if (ArtistRepository.getArtistByIDandName(int.Parse(artistID), artistName) == null)
            {
                return 3;
            }
            else
            {
                ArtistRepository.deleteArtist(int.Parse(artistID), artistName);
                return 4;
            }
        }
        public static int insertArtist(string artistName, HttpPostedFile artistImage)
        {
            if (artistName.Equals(""))
            {
                return 1;
            }
            else if (artistImage.FileName.Equals(""))
            {
                return 2;
            }
            else if (
                    !(artistImage.ContentType.Equals("image/png") ||
                    artistImage.ContentType.Equals("image/jpg") ||
                    artistImage.ContentType.Equals("image/jpeg") ||
                    artistImage.ContentType.Equals("image/jfif"))
                    )
            {
                return 3;
            }
            else if (artistImage.ContentLength >= 2000000)
            {
                return 4;
            }
            else
            {
                Artist artist = ArtistRepository.getArtistByName(artistName);

                if (artist != null)
                {
                    return 5;
                }
                else
                {
                    ArtistRepository.insertArtist(artistName, artistImage);
                    return 6;
                }

            }
        }
        public static int updateArtist(int id, string artistName, HttpPostedFile artistImage)
        {
            if (artistName.Equals(""))
            {
                return 1;
            }
            else if (artistImage.FileName.Equals(""))
            {
                return 2;
            }
            else if (
                    !(artistImage.ContentType.Equals("image/png") ||
                    artistImage.ContentType.Equals("image/jpg") ||
                    artistImage.ContentType.Equals("image/jpeg") ||
                    artistImage.ContentType.Equals("image/jfif"))
                    )
            {
                return 3;
            }
            else if (artistImage.ContentLength >= 2000000)
            {
                return 4;
            }
            else
            {
                Artist artist = ArtistRepository.getArtistByName(artistName);

                if (artist != null)
                {
                    return 5;
                }
                else
                {
                    ArtistRepository.updateArtist(id, artistName, artistImage.FileName);
                    return 6;
                }

            }
        }
    }
}