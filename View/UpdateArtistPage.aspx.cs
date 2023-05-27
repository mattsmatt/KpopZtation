using KpopZtation.Controller;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class UpdateArtistPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            Artist artist = ArtistRepository.getArtistByID(id);

            string artistNameBefore = artist.ArtistName;
            string artistImageBefore = artist.ArtistImage;
            LblNameBefore.Text = artistNameBefore;
            LblImageBefore.Text = artistImageBefore;
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            LblError.ForeColor = System.Drawing.Color.Red;
            string artistName = TxtArtistName.Text;
            HttpPostedFile artistImage = ArtistImageFileUpload.PostedFile;

            int id = int.Parse(Request.QueryString["id"]);
            Artist artist = ArtistRepository.getArtistByID(id);

            string artistNameBefore = artist.ArtistName;
            string artistImageBefore = artist.ArtistImage;
            LblNameBefore.Text = artistNameBefore;
            LblImageBefore.Text = artistImageBefore;

            int errorNum = ArtistController.updateArtist(id, artistName, artistImage);
            if (errorNum == 6)
            {
                LblError.Text = "Update Successful";
                artistImage.SaveAs(Server.MapPath("~/Assets/" + artistImage.FileName));
                LblError.ForeColor = System.Drawing.Color.Green;
                Response.Redirect("UpdateArtistPage.aspx?id=" + id);
            }
            else if (errorNum == 5)
            {
                LblError.Text = "Artist Name must be unique";
            }
            else if (errorNum == 4)
            {
                LblError.Text = "file size must be lower than 2MB";
            }
            else if (errorNum == 3)
            {
                LblError.Text = "file extension must be .png, .jpg, .jpeg, or .jfif";
            }
            else if (errorNum == 2)
            {
                LblError.Text = "Artist image file must not be empty";
            }
            else if (errorNum == 1)
            {
                LblError.Text = "Artist name must not be empty";
            }
        }
    }
}